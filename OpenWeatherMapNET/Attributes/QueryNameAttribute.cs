namespace OpenWeatherMapNET.Attributes
{
    /// <summary>
    /// Determines the alternative queryname for RequestBase ToQueryString method
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class QueryNameAttribute : Attribute
    {
        public string Name { get; set; }

        public QueryNameAttribute(string name)
        {
            Name = name;
        }
    }
}
