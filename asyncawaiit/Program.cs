using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace asyncawaiit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start");
            GetContent();
            Console.WriteLine("Main End");
            Console.ReadLine();
        }

        static async void GetContent()
        {
            Console.WriteLine("GetContent Start");
            var http = new HttpWrapper();
            var content = await http.GetUrlString("http://microsoft.com/");
            Console.WriteLine();
            Console.WriteLine(content);
            Console.WriteLine("GetContent End");
        }
    }

    class HttpWrapper
    {
        public async Task<string> GetUrlString(string url)
        {
            Console.WriteLine("HttpWrapper.GetUrlString Start");
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(url);
            Console.WriteLine("HttpWrapper.GetUrlString End");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
