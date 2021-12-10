using System;

namespace BedWorker.Utils
{
    public class DateUtil
    {
        public static string GetFolderTodayDate()
        {
            return DateTime.Now.ToString("yyyy/MM/dd");
        }

        public static string GetFolderTodayTime()
        {
            return DateTime.Now.ToString("HHmmss");
        }
    }
}
