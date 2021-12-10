namespace BedWorker.Utils
{
    public class UrlConstant
    {
        /// <summary>
        /// 服务开启窗口
        /// </summary>
        public static string HttpServer = "http://localhost:65501/BedWorker/";
        /// <summary>
        /// 请求用户通过授权
        /// </summary>
        public static string Gitee_GetCode = "https://gitee.com/oauth/authorize?client_id={0}&redirect_uri={1}&response_type=code";
        /// <summary>
        /// 通过code换token
        /// </summary>
        public static string Gitee_Code2Token = "https://gitee.com/oauth/token?grant_type=authorization_code&code={0}&client_id={1}&redirect_uri={2}&client_secret={3}";
        /// <summary>
        /// 获取用户信息
        /// </summary>
        public static string Gitee_Userinfo = "https://gitee.com/api/v5/user";
        /// <summary>
        /// 创建仓库
        /// </summary>
        public static string Gitee_Repos_Create = "https://gitee.com/api/v5/user/repos";
        /// <summary>
        /// 仓库是否存在 https://gitee.com/api/v5/repos/{owner}/{repo}
        /// </summary>
        public static string Gitee_Repos_Exist = "https://gitee.com/api/v5/repos/{0}/{1}";
        /// <summary>
        /// 创建新分支 https://gitee.com/api/v5/repos/{owner}/{repo}/branches
        /// </summary>
        public static string Gitee_Repos_Branches_Create = "https://gitee.com/api/v5/repos/{0}/{1}/branches";
        /// <summary>
        /// 检查分支是否存在 https://gitee.com/api/v5/repos/{owner}/{repo}/branches/{branch}
        /// </summary>
        public static string Gitee_Repos_Branches_Exist = "https://gitee.com/api/v5/repos/{0}/{1}/branches/{2}";
        /// <summary>
        /// 新建文件 https://gitee.com/api/v5/repos/{owner}/{repo}/contents/{path}
        /// </summary>
        public static string Gitee_Repos_Create_File = "https://gitee.com/api/v5/repos/{0}/{1}/contents/{2}";
    }
}
