using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraperAPP.classes
{
    class KeywordScrapper
    {
        private HtmlRepository htmlRepository;
        private SentenceRepository sentenceRepository;

        public KeywordScrapper(HtmlRepository htmlRepository, SentenceRepository sentenceRepository)
        {
            this.htmlRepository = htmlRepository;
            this.sentenceRepository = sentenceRepository;
        }

        public void scrapeSentence(String keyword)
        {
            foreach (string kodas in htmlRepository.retrieve())
            {
                String htmlkodas = kodas;
                htmlkodas = Regex.Replace(htmlkodas, @"\s+|&nbsp;|&#8230;|&#039;|&#8217|&#8211;|&middot;", " ");
                string[] sentences = Regex.Split(htmlkodas, @"(?<=[\.!\?])\s+");

                foreach (string item in sentences)
                {
                    String itemHolder = item.ToLower();
                    if (itemHolder.Contains(keyword.ToLower()))
                    {
                        sentenceRepository.addItem(item);
                    }
                }
            }
            sentenceRepository.removeDubs();
        }

        public List<String> retrieveHtml()
        {
            return htmlRepository.retrieve();
        }
        public List<String> retrieveSentences()
        {
            return sentenceRepository.retrieve();
        }
    }
}
