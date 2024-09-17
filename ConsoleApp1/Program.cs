using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://webapi"); // Use Docker service name

            HttpResponseMessage response = await client.GetAsync("/weatherforecast");
            string result = await response.Content.ReadAsStringAsync();

            Console.WriteLine("Response from Web API:");
            Console.WriteLine(result);
        }
    }
}
