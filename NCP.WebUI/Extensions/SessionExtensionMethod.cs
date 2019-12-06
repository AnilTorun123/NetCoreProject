using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCP.WebUI.Extensions
{
    public static class SessionExtensionMethod
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            string result = JsonConvert.SerializeObject(value);
            session.SetString(key, result);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            string result = session.GetString(key);
            if (string.IsNullOrEmpty(result))
                return null;
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
