using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Preethi.SunriseSunset.Modelclass
{
    public sealed class Request
    {
        public DateTime DateOn { get; set; }
        public string Endpoint => $"https://api.sunrise-sunset.org/json?lat={Latitude}&lng={Longitude}&date={DateOn:yyyy-MM-dd}&formatted=0";
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
