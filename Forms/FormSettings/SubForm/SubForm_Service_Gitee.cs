﻿using System;
using System.Net;
using System.Windows.Forms;

using Newtonsoft.Json;

using BedWorker.Config;
using BedWorker.Utils;
using BedWorker.Entity.Gitee;
using System.Threading.Tasks;
using System.IO;
using EasyHttp.Http;
using System.Collections.Generic;
using BedWorker.Entity;
using System.Threading;

namespace BedWorker.Forms.FormSettings.SubForm
{
    public partial class SubForm_Service_Gitee : Form
    {
        public Form_Settings parentForm = null;
        public SubForm_Service_Gitee(Form_Settings _this)
        {
            parentForm = _this;
            InitializeComponent();
        }

        /// <summary>
        /// gitee confirm click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GiteeConfirm_click(object sender, EventArgs e)
        {
            this.GiteeApply_click(sender, e);
            this.GiteeCancel_click(sender, e);
        }

        /// <summary>
        /// gitee cancel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GiteeCancel_click(object sender, EventArgs e)
        {
            parentForm.Dispose();
        }

        /// <summary>
        /// gitee apply click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GiteeApply_click(object sender, EventArgs e)
        {
            string _branch = string.IsNullOrEmpty(this.textBox_gitee_branch.Text) ? "master" : this.textBox_gitee_branch.Text;
            string _directory = string.IsNullOrEmpty(this.textBox_gitee_directory_path.Text) ? "/img" : this.textBox_gitee_directory_path.Text;
            if (!_directory.StartsWith("/"))
            {
                _directory = "/" + _directory;
            }
            Configs.Configs_Ref.Gitee = new Gitee()
            {
                Username = this.textBox_gitee_username.Text,
                RepositoryName = this.textBox_gitee_repo.Text,
                Branch = _branch,
                Token = this.textBox_gitee_token.Text,
                Directory = _directory
            };

            // 如果branch为null 默认为master
            this.textBox_gitee_branch.Text = _branch;
            // 如果directory_path为null 默认为/img 且强制以‘/’开头
            this.textBox_gitee_directory_path.Text = _directory;

            // 完整地址
            Configs.Configs_Ref.Gitee.RepoAbsolutePath = Configs.Configs_Ref.Gitee.GetRepoAbsolutePath();
            this.textBox_gitee_repoAbsolutePath.Text = Configs.Configs_Ref.Gitee.GetRepoAbsolutePath();
            XmlUtil.Obj2Xml<Configs>(CommonUtil.GetConfigLocation(), Configs.Configs_Ref);
        }

        private void Gitee_OAuth_Click(object sender, EventArgs e)
        {
            // 使用默认浏览器打开应用地址
            System.Diagnostics.Process.Start(string.Format(UrlConstant.Url_Gitee_GetCode, CommonConstant.GITEE_CLIENT_ID, CommonConstant.GITEE_REDIRECT_URI));
            // 开启httpserver 用于回调
            HttpListener httpListener = HttpServerUtil.StartListenServer(UrlConstant.Url_HttpServer);

            CancellationTokenSource cancelToken = new CancellationTokenSource();

            Task task = Task.Factory.StartNew(() =>
            {
                while (null != httpListener && httpListener.IsListening)
                {
                    try
                    {
                        AuthWait(httpListener, cancelToken);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("authWait 失败, {0}", ex.ToString());
                        // 终止循环
                        break;
                    }
                }
            }, cancelToken.Token);

            Task.Run(() =>
            {
                Console.WriteLine("60s 内需要完成认证操作, 否则需要重新认证");
                Task.Delay(60000).Wait();
                if (httpListener != null && httpListener.IsListening)
                {
                    httpListener.Stop();
                    httpListener.Close();
                }
                if (cancelToken.IsCancellationRequested) {
                    cancelToken.Cancel(true);
                }
                Console.WriteLine("Task ended delay complete...");
            });

            task.Wait();
        }

        private void AuthWait(HttpListener httpListener, CancellationTokenSource cancelToken)
        {
            HttpListenerContext context = httpListener.GetContext();
            Console.WriteLine("Http requesting...");
            HttpListenerRequest request = context.Request;

            string code = CommonUtil.GetValueByKeyFromUrl(request.Url.ToString(), "code");

            if (!string.IsNullOrEmpty(code))
            {
                // code存在 拿code换token
                string token = this.Code2Token(code);

                // System.InvalidOperationException: 线程间操作无效: 从不是创建控件“textBox_gitee_token”的线程访问它。
                Action<string> actionDelegate = delegate(string _value) { this.textBox_gitee_token.Text = _value; };
                this.textBox_gitee_token.BeginInvoke(actionDelegate, token);
                Configs.Configs_Ref.Gitee.Token = token;
                // 重写到xml中
                XmlUtil.Obj2Xml<Configs>(CommonUtil.GetConfigLocation(), Configs.Configs_Ref);
            }

            HttpListenerResponse response = context.Response;
            Console.WriteLine("Http responseting...");
            string responseString = "Hello  现在你可以关闭当前页面了.";
            using (StreamWriter writer = new StreamWriter(response.OutputStream, System.Text.Encoding.GetEncoding("UTF-8")))
            {
                Console.WriteLine("Http WriteLine...");
                writer.WriteLine(responseString);
                writer.Close();

                httpListener.Stop();
                httpListener.Close();
                cancelToken.Cancel();
            }
            Console.WriteLine("Http end...");
        }

        private string Code2Token(string code)
        {
            GiteeAuthRequest authRequest = new GiteeAuthRequest();
            authRequest.grant_type = CommonConstant.GITEE_AUTHORIZATION_CODE;
            authRequest.client_id = CommonConstant.GITEE_CLIENT_ID;
            authRequest.client_secret = CommonConstant.GITEE_CLIENT_SECRET;
            authRequest.redirect_uri = CommonConstant.GITEE_REDIRECT_URI;
            authRequest.code = code;

            // 需要替换内容
            string url = string.Format(UrlConstant.Url_Gitee_Code2Token, code, authRequest.client_id, authRequest.redirect_uri, authRequest.client_secret);

            GiteeAuthResponse response = HttpUtil.Post<GiteeAuthResponse>(url, authRequest, HttpContentTypes.ApplicationXWwwFormUrlEncoded);

            if (null != response)
            {
                return response.AccessToken;
            }
            return null;
        }
    }
}
