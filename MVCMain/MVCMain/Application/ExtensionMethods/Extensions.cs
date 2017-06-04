using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMain.Application.ExtensionMethods
{
    public static class Extensions
    {
        public static Dictionary<string, string> map = new Dictionary<string, string>();

        static Extensions()
        {
            map.Add("topic", "this is test topic");
        }
        /// <summary>
        /// Gets the specific language text from the language key
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        //[Obsolete]
        public static string LanguageString(this HtmlHelper helper, string key)
        {
            if (map[key] != null)
                return map[key];

            return key;

            //return Lang(helper, key);
        }
    }
}