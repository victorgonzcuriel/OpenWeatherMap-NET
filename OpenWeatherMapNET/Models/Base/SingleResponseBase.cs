namespace OpenWeatherMapNET.Models
{
    /// <summary>
    /// Response body for single responses
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleResponseBase<T> : ResponseBody where T : IResponse
    {
        public T? Response { get; set; }

        public SingleResponseBase(HttpResponseMessage response) : base(response)
        { }
    }
}
