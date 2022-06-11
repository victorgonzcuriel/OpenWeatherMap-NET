using OpenWeatherMapNET.Attributes;
using System.Web;

namespace OpenWeatherMapNET.Models
{
    /// <summary>
    /// Base model for HttpRequests
    /// </summary>
    public abstract class RequestBase
    {
        /// <summary>
        /// Get a query string with the object information
        /// </summary>
        /// <returns></returns>
        public string ToQueryString()
        {
            var propsString = string.Empty;

            var props = this.GetType()
                .GetProperties()
                .Where(x => x.GetValue(this) != null && !string.IsNullOrEmpty(x.GetValue(this)!.ToString()));

            var queryStringValues = new List<string>();

            foreach (var prop in props)
            {
                var attributes = prop.GetCustomAttributes(true);

                var propName = prop.Name;

                foreach(var attr in attributes)
                {
                    var nameAttr = attr as QueryNameAttribute;

                    // if there is a querynameattribute the name is overriden
                    if (nameAttr != null)
                    {
                        propName = nameAttr.Name;
                        break;
                    }
                }

                queryStringValues.Add($"{propName}={HttpUtility.UrlEncode(prop.GetValue(this)!.ToString())}");
            }

            return $"?{string.Join("&", queryStringValues)}";
        }
    }
}