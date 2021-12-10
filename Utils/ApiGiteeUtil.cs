using System;
using System.Collections.Generic;
using BedWorker.Entity.Base;
using BedWorker.Config;
using EasyHttp.Http;

namespace BedWorker.Utils
{
    public class ApiGiteeUtil
    {

        public static MapExt RepoInfo()
        {
            string url = string.Format(UrlConstant.Gitee_Repos_Exist, Gitee().Username, Gitee().RepositoryName);

            MapExt repo = HttpUtil.Get<MapExt>(url, GetAccessTokenDict());
            return repo;
        }

        public static bool RepoCreate()
        {
            Dictionary<string, object> data = GetAccessTokenDict();

            // 仓库名称
            data.Add("name", Gitee().RepositoryName);
            // 初始化仓库
            data.Add("auto_init", true);
            // 描述
            data.Add("description", "Service For BedWorker | 服务于图床工");
            // 仓库名称
            data.Add("license_template", "GPL-3.0");

            MapExt resp = HttpUtil.Post<MapExt>(UrlConstant.Gitee_Repos_Create, data, HttpContentTypes.ApplicationXWwwFormUrlEncoded);
            return (resp != null && null != resp["id"]) ? true : false;
        }


        public static bool RepoExist()
        {
            MapExt repo = RepoInfo();
            return !repo.IsNullOrEmpty() && null != repo.Get("id");
        }


        public static Dictionary<string, object> BranchInfo()
        {
            string url = string.Format(UrlConstant.Gitee_Repos_Branches_Exist, Gitee().Username, Gitee().RepositoryName, Gitee().Branch);

            Dictionary<string, object> branch = HttpUtil.Get<Dictionary<string, object>>(url, GetAccessTokenDict());
            return branch;
        }

        public static string BranchDefault()
        {
            Dictionary<string, object> repo = BranchInfo();
            if (null != repo)
            {
                return repo["default_branch"].ToString();
            }
            return null;
        }


        public static bool BranchExist()
        {
            Dictionary<string, object> branch = BranchInfo();

            return null != branch;
        }

        public static string FileCreate(string originFileName, string base64)
        {
            string fileUrl = "";

            Dictionary<string, object> data = GetAccessTokenDict();
            data.Add("content", base64);

            string finalFilePath = CommonUtil.getRandomFilePath(originFileName);

            string url = string.Format(UrlConstant.Gitee_Repos_Create_File, Gitee().Username, Gitee().RepositoryName, finalFilePath);
            Dictionary<string, object> response = HttpUtil.Post<Dictionary<string, object>>(url, data, HttpContentTypes.ApplicationXWwwFormUrlEncoded);

            Console.WriteLine(response.ToString());

            return fileUrl;
        } 

        public static Gitee Gitee()
        {
            return Configs.Configs_Ref.Gitee; ;
        }

        public static Dictionary<string, object> GetAccessTokenDict()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("access_token", Configs.Configs_Ref.Gitee.Token);

            return dict;
        }
    }
}
