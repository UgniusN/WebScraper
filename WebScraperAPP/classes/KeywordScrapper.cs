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
            String htmlkodas = htmlRepository.getFirstItem();
            htmlkodas = Regex.Replace(htmlkodas, @"\s+|&nbsp;", " ");
            string[] sentences = Regex.Split(htmlkodas, @"(?<=[\.!\?])\s+");

            foreach (string item in sentences)
            {
                    sentenceRepository.addItem(item);
            }
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
