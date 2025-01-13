using System.Net;

namespace Evidencias_13_Crear_Referencias
{
    public class ScrapeBase
    {
        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);

        }
    }
}