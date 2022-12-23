using HtmlAgilityPack;
using System.Diagnostics;
using System.Net;

namespace WebCrawler
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            //Abfrage von Webseiten-URL
            Console.WriteLine("URL eingeben. Bsp. https://www.google.com");
            string url = Console.ReadLine();

            //Herunterladen der html Datei und abspeichern bei angegebenem Pfad
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        string result = content.ReadAsStringAsync().Result;
                        File.WriteAllText("C:/Users/Rentsch/Desktop/test.html", result);
                    }
                }
            }
        }   
    }
}