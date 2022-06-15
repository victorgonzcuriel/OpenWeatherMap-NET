using OpenWeatherMapNET.Attributes;
using System.Globalization;
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
        public virtual string ToQueryString()
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

                var value = string.Empty;

                if (prop.PropertyType == typeof(decimal))
                    value = ((decimal)prop.GetValue(this)!).ToString(CultureInfo.InvariantCulture);
                else
                    value = prop.GetValue(this)!.ToString();

                queryStringValues.Add($"{propName}={HttpUtility.UrlEncode(value)}");
            }

            return $"?{string.Join("&", queryStringValues)}";
        }
    }
}