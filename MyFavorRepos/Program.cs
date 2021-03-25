using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Net.Http;
using HtmlAgilityPack;


namespace MyFavorRepos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CreateHostBuilder(args).Build().Run();

            var httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (s, c, ch, ssl) => true
            };
            HttpClient httpClient = new HttpClient(httpClientHandler);
            var domStr = httpClient.GetStringAsync("http://github.com/idcf-boat-house").Result.ToString();

            var html = new HtmlDocument();
            html.LoadHtml(domStr);
            //寻找XPATH.....正在进行中
            var liNodes = html.DocumentNode.SelectNodes("//div[@class='flex-auto ']/");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
