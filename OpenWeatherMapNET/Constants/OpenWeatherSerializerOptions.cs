using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenWeatherMapNET.Constants
{
    internal class OpenWeatherSerializerOptions
    {
        internal static JsonSerializerOptions SerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = new OpenWeatherNamingPolicy()
        };

        private class OpenWeatherNamingPolicy : JsonNamingPolicy
        {
            public override string ConvertName(string name)
            {
                var output = string.Empty;

                for(int i= 0; i < name.Length; i++)
                {
                    if (char.IsUpper(name[i]))
                    {
                        if (i == 0)
                            output += char.ToLower(name[i]);
                        else
                            output += $"_{char.ToLower(name[i])}";
                    }
                    else
                        output += name[i];
                }

                return output;
            }
        }
    }
}
