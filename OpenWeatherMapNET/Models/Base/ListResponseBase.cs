namespace OpenWeatherMapNET.Models
{
    /// <summary>
    /// Response body for array responses
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListResponseBase<T> : ResponseBody where T : IResponse
    {
        public List<T> Response { get; set; } = new List<T>();

        public ListResponseBase(HttpResponseMessage response) : base(response)
        {
        }
    }
}
