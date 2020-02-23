using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScraperAPP
{
    public partial class Form1 : Form
    {
        classes.UrlRepository urlRepository;
        classes.HtmlRepository htmlRepository;
        classes.SentenceRepository sentenceRepository;
        classes.KeywordScrapper keywordScrapper;
        classes.HtmlDownloader htmlDownloader;
        public Form1()
        {
            InitializeComponent();
            urlRepository = new classes.UrlRepository();
            htmlRepository = new classes.HtmlRepository();
            sentenceRepository = new classes.SentenceRepository();
            keywordScrapper = new classes.KeywordScrapper(htmlRepository, sentenceRepository);
            htmlDownloader = new classes.HtmlDownloader(htmlRepository, urlRepository);
        }

        private void firstUrlBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnStartScraping_Click(object sender, EventArgs e)
        {
            if(firstUrlInput.Text == "")
            {
                MessageBox.Show("Please enter an url", "WebScraper");
            }
            else
            {
                urlRepository.addItem(firstUrlInput.Text);
                htmlDownloader.downloadSourceOfUrl(urlRepository.getFirstItem());
                scrapedUrlBox.Text = string.Join(Environment.NewLine, htmlDownloader.retrieveUrls());
                MessageBox.Show("Done scraping Urls!", "WebScraper");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pastedUrlBox.Text == "")
            {
                MessageBox.Show("Please enter atleast one url", "WebScraper");
            }
            else
            {
                String pastedLinks = pastedUrlBox.Text;
                string[] links = pastedLinks.Split(' ');
                foreach (string link in links)
                {
                    urlRepository.addItem(link);
                }
                scrapedUrlBox.Text = string.Join(Environment.NewLine, urlRepository.retrieve());
                MessageBox.Show("Urls added successfully!", "WebScraper");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pastedUrlBox.Text == "")
            {
                MessageBox.Show("Please enter a one word", "WebScraper");
            }
            else
            {
                keywordScrapper.scrapeSentence(textBoxKeyword.Text);
                sentenceRepository.set(keywordScrapper.retrieveSentences());
                scrapedSentenceBox.Text = string.Join(Environment.NewLine, sentenceRepository.retrieve());
                MessageBox.Show("Done scraping sentences!", "WebScraper");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
