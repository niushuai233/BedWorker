using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BedWorker.Config;
using EasyHttp.Http;

namespace BedWorker.Utils
{
    public class ApiGiteeHelper
    {

        public static Dictionary<string, object> RepoInfo()
        {
            Gitee gitee = Configs.Configs_Ref.Gitee;
            string url = string.Format(UrlConstant.Gitee_Repos_Exist, gitee.Username, gitee.RepositoryName);

            Dictionary<string, object> repo = HttpUtil.Get<Dictionary<string, object>>(url, GetAccessTokenDict());
            return repo;
        }
        public static bool RepoExist()
        {
            return null != RepoInfo();
        }


        public static Dictionary<string, object> BranchInfo()
        {
            Gitee gitee = Configs.Configs_Ref.Gitee;
            string url = string.Format(UrlConstant.Gitee_Repos_Branches_Exist, gitee.Username, gitee.RepositoryName, gitee.Branch);

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

            Gitee gitee = Configs.Configs_Ref.Gitee;

            Dictionary<string, object> data = GetAccessTokenDict();
            //data.Add("", );

            string finalFilePath = CommonUtil.getRandomFilePath(originFileName);

            string url = string.Format(UrlConstant.Gitee_Repos_Create_File, gitee.Username, gitee.RepositoryName, finalFilePath);
            Dictionary<string, object> response = HttpUtil.Post<Dictionary<string, object>>(url, data, HttpContentTypes.ApplicationXWwwFormUrlEncoded);

            Console.WriteLine(response.ToString());

            return fileUrl;
        } 

        public static Dictionary<string, object> GetAccessTokenDict()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("access_token", Configs.Configs_Ref.Gitee.Token);

            return dict;
        }
    }
}
