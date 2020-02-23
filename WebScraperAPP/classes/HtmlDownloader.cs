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


        public void downloadSourceOfUrl(String Url,bool unique)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            HtmlWeb web = new HtmlWeb();
            if (IsUrl(Url))
            {
                try {
                    doc = web.Load(Url);
                }
                catch (System.ArgumentException)
                {

                }
                catch (System.Net.WebException)
                {

                }
                finally
                {
                    String htmlkodas = doc.DocumentNode.InnerText;
                    htmlRepository.addItem(htmlkodas);
                    if (doc.DocumentNode.SelectNodes("//a[@href]") != null)
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
                                if (IsUrl(att.Value)) {
                                    if (unique)
                                    {
                                        if (!att.Value.Contains(Url))
                                        {
                                            urlRepository.addItem(att.Value);
                                        }
                                        else
                                        {

                                        }
                                    }
                                    else
                                    {
                                        urlRepository.addItem(att.Value);
                                    }
                                    }
                            }
                        }
                }

            }
        }

        public List<String> retrieveUrls()
        {
            return urlRepository.retrieve();
        }
        public List<String> retrieveHtml()
        {
            return htmlRepository.retrieve();
        }
        public bool IsUrl(string Url)
        {
            string strRegex = "^(https?://)"
            + "?(([0-9a-z_!~*'().&=+$%-]+: )?[0-9a-z_!~*'().&=+$%-]+@)?" //user@
            + @"(([0-9]{1,3}\.){3}[0-9]{1,3}" // IP- 199.194.52.184
            + "|" // allows either IP or domain
            + @"([0-9a-z_!~*'()-]+\.)*" // tertiary domain(s)- www.
            + @"([0-9a-z][0-9a-z-]{0,61})?[0-9a-z]\." // second level domain
            + "[a-z]{2,6})" // first level domain- .com or .museum
            + "(:[0-9]{1,4})?" // port number- :80
            + "((/?)|" // a slash isn't required if there is no file name
            + "(/[0-9a-z_!~*'().;?:@&=+$,%#-]+)+/?)$";
            Regex re = new Regex(strRegex);

            if (re.IsMatch(Url))
                return (true);
            else
                return (false);
        }
    }
}

