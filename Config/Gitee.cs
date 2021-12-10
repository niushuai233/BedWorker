using BedWorker.Entity;

namespace BedWorker.Config
{
    public class Gitee
    {
        /// <summary>
        /// 主机
        /// </summary>
        public string Host { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// 仓库
        /// </summary>
        public string RepositoryName { get; set; }
        /// <summary>
        /// 完整路径
        /// </summary>
        public string RepoAbsolutePath { get; set; }
        /// <summary>
        /// 分支
        /// </summary>
        public string Branch { get; set; }
        /// <summary>
        /// Api Token
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// 仓库内目录
        /// </summary>
        public string Directory { get; set; }

        public GiteeAuthResponse AuthResponse { get; set; }

        public Gitee()
        {
            Host = "https://gitee.com";
            Username = "";
            RepositoryName = "";
            Branch = "master";
            Token = "";
            Directory = "/img";
            AuthResponse = new GiteeAuthResponse();
        }

        public string GetRepoAbsolutePath()
        {
            return Host + "/" + Username + "/" + RepositoryName;
        }
    }
}
