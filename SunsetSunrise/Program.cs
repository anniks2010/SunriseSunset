using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using System.Text;

namespace SunsetSunrise
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomJokeUrl = "https://api.sunrise-sunset.org/json?lat=59.437222&lng=24.745&date=today";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(randomJokeUrl);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd(); ////panen valmis koha, kuhu maha lugeda, mis on olemas vastuses
                SunMode sunMode = JsonConvert.DeserializeObject<SunMode>(response); ///võtab stringi ja loeb stringi maha SunMode klassist
                Console.WriteLine(sunMode.Status); ////nüüd vaatame, mis me saame
                Console.WriteLine($"Sunrise:{sunMode.Results.Sunrise}");
                Console.WriteLine($"Sunset:{sunMode.Results.Sunset}");

            }
        }
    }
}
