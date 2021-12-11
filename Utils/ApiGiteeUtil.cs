using System;
using System.Collections.Generic;
using BedWorker.Entity.Base;
using BedWorker.Config;
using EasyHttp.Http;
using Newtonsoft.Json;

namespace BedWorker.Utils
{
    public class ApiGiteeUtil
    {

        public static MapExt RepoInfo()
        {
            string url = string.Format(UrlConstant.Gitee_Repos_Exist, Gitee().Username, Gitee().RepositoryName);

            MapExt repo = HttpUtil.Get<MapExt>(url, GetAccessTokenMap());
            return repo;
        }

        public static MapExt RepoCreate()
        {
            MapExt data = GetAccessTokenMap();

            // 仓库名称
            data.Add("name", Gitee().RepositoryName);
            // 初始化仓库
            data.Add("auto_init", true);
            // 描述
            data.Add("description", "Service For BedWorker | 服务于图床工");
            // 仓库名称
            data.Add("license_template", "GPL-3.0");

            MapExt resp = HttpUtil.Post<MapExt>(UrlConstant.Gitee_Repos_Create, data, HttpContentTypes.ApplicationXWwwFormUrlEncoded);
            return resp;
        }


        public static bool RepoExist()
        {
            MapExt repo = RepoInfo();
            return repo.IsNotNullOrEmpty() && null != repo.Get("id");
        }


        public static MapExt BranchInfo()
        {
            string url = string.Format(UrlConstant.Gitee_Repos_Branches_Exist, Gitee().Username, Gitee().RepositoryName, Gitee().Branch);

            MapExt branch = HttpUtil.Get<MapExt>(url, GetAccessTokenMap());
            return branch;
        }

        public static string BranchDefault()
        {
            MapExt repo = BranchInfo();
            if (null != repo)
            {
                return repo["default_branch"].ToString();
            }
            return null;
        }


        public static bool BranchExist()
        {
            MapExt branch = BranchInfo();

            return null != branch;
        }


        public static string GiteeUpload(string filePath)
        {
            //string x2 = "{'content':{'name':'145747-kxbg7B2t-黄瓶子.jpg','path':'img/2021/12/11/145747-kxbg7B2t-黄瓶子.jpg','size':801212,'sha':'41f200f87352c929a1ce5999546b6b9bb8508e71','type':'file','url':'https://gitee.com/api/v5/repos/niushuai233/bedworker_test/contents/img/2021/12/11/145747-kxbg7B2t-黄瓶子.jpg','html_url':'https://gitee.com/niushuai233/bedworker_test/blob/master/img/2021/12/11/145747-kxbg7B2t-黄瓶子.jpg','download_url':'https://gitee.com/niushuai233/bedworker_test/raw/master/img/2021/12/11/145747-kxbg7B2t-黄瓶子.jpg','_links':{'self':'https://gitee.com/api/v5/repos/niushuai233/bedworker_test/contents/img/2021/12/11/145747-kxbg7B2t-黄瓶子.jpg','html':'https://gitee.com/niushuai233/bedworker_test/blob/master/img/2021/12/11/145747-kxbg7B2t-黄瓶子.jpg'}},'commit':{'sha':'1697ad7b7dd9f8489344390d041e5a9815a52fc9','author':{'name':'niushuai','date':'2021-12-11T06:57:47+00:00','email':'niushuai951101@gmail.com'},'committer':{'name':'Gitee','date':'2021-12-11T06:57:47+00:00','email':'noreply@gitee.com'},'message':'feat: 添加图片: /img/2021/12/11/145747-kxbg7B2t-黄瓶子.jpg','tree':{'sha':'dbf6d6eb777ca928b4158d0ac25e57e935e8e8d4','url':'https://gitee.com/api/v5/repos/niushuai233/bedworker_test/git/trees/dbf6d6eb777ca928b4158d0ac25e57e935e8e8d4'},'parents':[{'sha':'5acd63d27c7dc3c1da61321b6f6e1b192ba992a9','url':'https://gitee.com/api/v5/repos/niushuai233/bedworker_test/commits/5acd63d27c7dc3c1da61321b6f6e1b192ba992a9'}]}}";
            //if (x2.Length > 1)
            //{
            //    string x23 = JsonConvert.DeserializeObject<MapExt>(x2).Get("content") + "";
            //    MapExt contentx23 = JsonConvert.DeserializeObject<MapExt>(x23);

            //    if (null != contentx23 && contentx23.IsNotNullOrEmpty())
            //    {
            //        return contentx23.Get("download_url") + "";
            //    }
            //    return null;
            //}
            Gitee gitee = Configs.Configs_Ref.Gitee;

            // 构建参数 其中文件夹以日期保存 且文件名前添加随机8位字符串作为前缀
            string path = gitee.Directory + "/" + CommonUtil.GetRandomFilePath(filePath);
            // 替换url参数
            string url = string.Format(UrlConstant.Gitee_Repos_Create_File, gitee.Username, gitee.RepositoryName, path);

            MapExt data = GetAccessTokenMap();
            // base64编码的文件
            data.Put("content", FileUtil.EncodeBase64(filePath));
            // 提交信息
            data.Put("message", "feat: 添加图片: " + path);
            // 提交分支
            data.Put("branch", gitee.Branch);

            // 上传
            MapExt respMap = HttpUtil.Post<MapExt>(url, data, HttpContentTypes.ApplicationXWwwFormUrlEncoded);

            if (respMap.IsNotNullOrEmpty())
            {
                string str = respMap.Get("content") + "";
                MapExt content = JsonConvert.DeserializeObject<MapExt>(str);

                if (null != content && content.IsNotNullOrEmpty())
                {
                    return content.Get("download_url") + "";
                }
            }

            return null;
        }
        public static Gitee Gitee()
        {
            return Configs.Configs_Ref.Gitee; ;
        }

        public static MapExt GetAccessTokenMap()
        {
            MapExt map = new MapExt();
            map.Put("access_token", Configs.Configs_Ref.Gitee.Token);

            return map;
        }

    }
}
