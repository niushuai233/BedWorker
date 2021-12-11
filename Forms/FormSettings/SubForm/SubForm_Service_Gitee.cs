using System;
using System.Net;
using System.Windows.Forms;

using BedWorker.Config;
using BedWorker.Utils;
using BedWorker.Entity.Gitee;
using System.Threading.Tasks;
using System.IO;
using EasyHttp.Http;
using System.Threading;
using BedWorker.Entity.Base;

namespace BedWorker.Forms.FormSettings.SubForm
{
    public partial class SubForm_Service_Gitee : Form
    {
        private bool applyOkFlag = false;
        public Form_Settings parentForm = null;
        public SubForm_Service_Gitee(Form_Settings _this)
        {
            parentForm = _this;
            InitializeComponent();
            LoadGiteeConfig();
        }

        private void LoadGiteeConfig()
        {
            Configs.Configs_Ref = XmlUtil.Xml2Obj<Configs>(CommonUtil.GetConfigLocation());

            this.textBox_gitee_username.Text = Configs.Configs_Ref.Gitee.Username;
            this.textBox_gitee_repo.Text = Configs.Configs_Ref.Gitee.RepositoryName;
            this.textBox_gitee_repoAbsolutePath.Text = Configs.Configs_Ref.Gitee.GetRepoAbsolutePath();
            this.textBox_gitee_branch.Text = Configs.Configs_Ref.Gitee.Branch;
            this.textBox_gitee_token.Text = Configs.Configs_Ref.Gitee.Token;
            this.textBox_gitee_directory_path.Text = Configs.Configs_Ref.Gitee.Directory;
        }

        /// <summary>
        /// gitee confirm click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GiteeConfirm_click(object sender, EventArgs e)
        {
            this.GiteeApply_click(sender, e);
            if (applyOkFlag)
            { 
                this.GiteeCancel_click(sender, e);
            }
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
            applyOkFlag = false;

            if (!this.ValidateData())
            {
                return;
            }

            string _branch = string.IsNullOrEmpty(this.textBox_gitee_branch.Text) ? "master" : this.textBox_gitee_branch.Text;
            string _directory = string.IsNullOrEmpty(this.textBox_gitee_directory_path.Text) ? "/img" : this.textBox_gitee_directory_path.Text;
            if (!_directory.StartsWith("/"))
            {
                _directory = "/" + _directory;
            }

            Configs.Configs_Ref.Gitee.Username  = this.textBox_gitee_username.Text;
            Configs.Configs_Ref.Gitee.RepositoryName = this.textBox_gitee_repo.Text;
            Configs.Configs_Ref.Gitee.Branch = _branch;
            Configs.Configs_Ref.Gitee.Token = this.textBox_gitee_token.Text;
            Configs.Configs_Ref.Gitee.Directory = _directory;

            // 如果branch为null 默认为master
            this.textBox_gitee_branch.Text = _branch;
            // 如果directory_path为null 默认为/img 且强制以‘/’开头
            this.textBox_gitee_directory_path.Text = _directory;

            // 完整地址
            Configs.Configs_Ref.Gitee.RepoAbsolutePath = Configs.Configs_Ref.Gitee.GetRepoAbsolutePath();
            this.textBox_gitee_repoAbsolutePath.Text = Configs.Configs_Ref.Gitee.GetRepoAbsolutePath();

            if (!ApiGiteeUtil.RepoExist())
            {
                DialogResult dialogResult = MessageBox.Show("远端仓库不存在, 是否创建?", "错误", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    // 确认创建
                    MapExt resp = ApiGiteeUtil.RepoCreate();
                    if (resp != null && null != resp.Get("id"))
                    {
                        MessageBox.Show("创建仓库成功");
                    } else
                    {
                        MessageBox.Show("创建仓库失败");
                        return;
                    }
                }
            }

            XmlUtil.Obj2Xml<Configs>(CommonUtil.GetConfigLocation(), Configs.Configs_Ref);
            applyOkFlag = true;
        }

        private bool ValidateData()
        {
            if (string.IsNullOrEmpty(this.textBox_gitee_username.Text.Trim()))
            {
                MessageBox.Show("用户名不能为空", "参数不合法");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBox_gitee_repo.Text.Trim()))
            {
                MessageBox.Show("仓库名不能为空", "参数不合法");
                return false;
            }
            return true;
        }

        private void Gitee_OAuth_Click(object sender, EventArgs e)
        {
            // 使用默认浏览器打开应用地址
            System.Diagnostics.Process.Start(string.Format(UrlConstant.Gitee_GetCode, CommonConstant.GITEE_CLIENT_ID, CommonConstant.GITEE_REDIRECT_URI));
            // 开启httpserver 用于回调
            HttpListener httpListener = HttpServerUtil.StartListenServer(UrlConstant.HttpServer);

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

            // 获取到token后 尝试获取用户名
            string token = Configs.Configs_Ref.Gitee.Token;
            if (!string.IsNullOrEmpty(token)) { 
                MapExt result = new MapExt();
                result.Put("access_token", token);
                GiteeUserInfo userInfo = HttpUtil.Get<GiteeUserInfo>(UrlConstant.Gitee_Userinfo, result);

                if (userInfo != null)
                {
                    Configs.Configs_Ref.Gitee.GiteeUserInfo = userInfo;
                    this.textBox_gitee_username.Text = userInfo.Login;
                }
            }
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
                GiteeAuthResponse token = this.Code2Token(code);

                // System.InvalidOperationException: 线程间操作无效: 从不是创建控件“textBox_gitee_token”的线程访问它。
                Action<string> actionDelegate = delegate(string _value) { this.textBox_gitee_token.Text = _value; };
                this.textBox_gitee_token.BeginInvoke(actionDelegate, token.AccessToken);
                Configs.Configs_Ref.Gitee.AuthResponse = token;
                Configs.Configs_Ref.Gitee.Token = token.AccessToken;
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

        private GiteeAuthResponse Code2Token(string code)
        {
            GiteeAuthRequest authRequest = new GiteeAuthRequest();
            authRequest.grant_type = CommonConstant.GITEE_AUTHORIZATION_CODE;
            authRequest.client_id = CommonConstant.GITEE_CLIENT_ID;
            authRequest.client_secret = CommonConstant.GITEE_CLIENT_SECRET;
            authRequest.redirect_uri = CommonConstant.GITEE_REDIRECT_URI;
            authRequest.code = code;

            // 需要替换内容
            string url = string.Format(UrlConstant.Gitee_Code2Token, code, authRequest.client_id, authRequest.redirect_uri, authRequest.client_secret);

            GiteeAuthResponse response = HttpUtil.Post<GiteeAuthResponse>(url, authRequest, HttpContentTypes.ApplicationXWwwFormUrlEncoded);

            if (null != response)
            {
                return response;
            }
            return null;
        }
    }
}
