using System;
using System.Collections.Generic;

namespace BedWorker.Entity.Base
{
    public class MapExt : Dictionary<string, object>
    {
        public bool IsNullOrEmpty()
        {
            return this.Count == 0;
        }

        public void Put(string key, string value)
        {
            this.Add(key, value);
        }

        public object Get(string key)
        {
            try
            {
                return this[key];
            } 
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
