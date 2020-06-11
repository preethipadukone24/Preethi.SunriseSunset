using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using Preethi.SunriseSunset.Modelclass;

namespace Preethi.SunriseSunset
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Btnres_Click(object sender, RoutedEventArgs e)
        {
        public sealed class SunriseSunsetClient
        {
            private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
            {
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };

            private HttpClient Client { get; }

            public SunriseSunsetClient(
                HttpClient client)
            {
                Client = client ?? throw new ArgumentNullException(nameof(client));
            }

            public async Task<Response> GetAsync(
                decimal latitude,
                decimal longitude) => await GetAsync(new Request
                {
                    Latitude = latitude,
                    Longitude = longitude
                });

            public async Task<Response> GetAsync(
                decimal latitude,
                decimal longitude,
                DateTime dateOn) => await GetAsync(new Request
                {
                    DateOn = dateOn,
                    Latitude = latitude,
                    Longitude = longitude
                });

            public async Task<Response> GetAsync(
                Request request)
            {
                if (request is null)
                {
                    return null;
                }

                var response = await GetResponseAsync(request);

                return JsonConvert.DeserializeObject<Response>(response, SerializerSettings);
            }

            private async Task<string> GetResponseAsync(
                Request request)
            {
                try
                {
                    var response = await Client.GetAsync(request.Endpoint);

                    return await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException)
                {
                    return null;
                }
            }
        }
    }
}
}
        


