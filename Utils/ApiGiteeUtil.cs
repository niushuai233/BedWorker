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

        public static bool RepoCreate()
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
            return (resp != null && null != resp.Get("id"));
        }


        public static bool RepoExist()
        {
            MapExt repo = RepoInfo();
            return !repo.IsNullOrEmpty() && null != repo.Get("id");
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
