using System;
using System.Net;

namespace WebClientDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient=new WebClient();
            WebClientDecorator webClientDecorator = new WebClientDecorator(webClient);
            string source = webClientDecorator.DownLoadString("https://www.google.com");


        }
    }
    public class WebClientDecorator:WebClient
    {
        private readonly WebClient _webClient;
        public WebClientDecorator(WebClient webClient)
        {
            _webClient = webClient;
        }
        public string DownLoadString(string address)
        {
            if (address.StartsWith("https://www.bugeto.net"))
            {
                return _webClient.DownloadString("address");
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
