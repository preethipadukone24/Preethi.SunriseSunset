using Preethi.SunriseSunset.Modelclass;
using System;
namespace Preethi.SunriseSunset
{
    public sealed class Response
    {
        [JsonProperty("results")]
        public Result Result { get; set; }

        public string Status { get; set; }
    }
    internal class JsonPropertyAttribute : Attribute
    {
        private string v;

        public JsonPropertyAttribute(string v)
        {
            this.v = v;
        }
    }
}
