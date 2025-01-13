using System.Net;

namespace Evidencias_13_Crear_Referencias
{
    public class Scrape : ScrapeBase
    {
        public string ScrapeWebpage (string url)
        {
            return GetWebpage(url);
            //Console.WriteLine(reply);
            //File.WriteAllText(url, reply);
        }
        public string ScrapeWebpage(string url, string filepath)
        {
            //WebClient client = new WebClient();
            //string reply = client.DownloadString(url);

            string reply = GetWebpage(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }
    }
}
