using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace Sample_Web_App.CustomSession
{
    public static class CustomSessionExtension
    {
        public static void SetObject<T>(this ISession session, string key,T value)
        {
            // Serialze the 'value' into JSON form and save it
            session.SetString(key, JsonSerializer.Serialize(value));

        }

        public static T GetObject<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            if(value == null)
                // the default is an operataor to provide default instance of the type
                return default(T);

            // get the object from the session
            return JsonSerializer.Deserialize<T>(value);
        }

    }
}
