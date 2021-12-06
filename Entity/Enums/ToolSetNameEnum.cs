using System;

namespace BedWorker.Entity.Enums
{
    public enum ToolSetNameEnum
    {
        /// <summary>
        /// 网络
        /// </summary>
        SetNetowrkNode,
        /// <summary>
        /// 代理
        /// </summary>
        SetNetworkProxySubNode,
        /// <summary>
        /// 服务
        /// </summary>
        SetServiceNode,
        /// <summary>
        /// Gitee
        /// </summary>
        SetServiceGiteeSubNode,
        /// <summary>
        /// default
        /// </summary>
        DEFAULT
    }

    public static class ToolSetNameProgram
    {
        public static ToolSetNameEnum match(this string name)
        {
            if (name == ToolSetNameEnum.SetNetowrkNode.ToString())
            {
                return ToolSetNameEnum.SetNetowrkNode;
            }
            else if (name == ToolSetNameEnum.SetNetworkProxySubNode.ToString())
            {
                return ToolSetNameEnum.SetNetworkProxySubNode;
            }
            else if (name == ToolSetNameEnum.SetServiceNode.ToString())
            {
                return ToolSetNameEnum.SetServiceNode;
            }
            else if (name == ToolSetNameEnum.SetServiceGiteeSubNode.ToString())
            {
                return ToolSetNameEnum.SetServiceGiteeSubNode;
            }
            else
            {
                return ToolSetNameEnum.DEFAULT;
            }
        }
    }
}
