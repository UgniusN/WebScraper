using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.RegularExpressions;
using HtmlAgilityPack;


namespace WebScraperAPP.classes
{
    public class HtmlDownloader
    {
        private HtmlRepository htmlRepository;
        private UrlRepository urlRepository;

        public HtmlDownloader(HtmlRepository htmlRepository, UrlRepository urlRepository)
        {
            this.htmlRepository = htmlRepository;
            this.urlRepository = urlRepository;
        }


        public void downloadSourceOfUrl(String Url)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HtmlWeb web = new HtmlWeb();
            doc = web.Load(Url);
            String htmlkodas = doc.DocumentNode.InnerText;
            htmlRepository.addItem(htmlkodas);
            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                HtmlAttribute att = link.Attributes["href"];
                if (att.Value.Contains("#"))
                {
                    string[] substring = att.Value.Split('#');
                    Console.Write(substring[0]);
                }
                else
                {
                    urlRepository.addItem(att.Value);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public List<String> retrieveUrls()
        {
            return urlRepository.retrieve();
        }
        public List<String> retrieveHtml()
        {
            return htmlRepository.retrieve();
        }
    }
}

