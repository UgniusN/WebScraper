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
        classes.HtmlDownloader htmlDownloader;
        public Form1()
        {
            InitializeComponent();
            urlRepository = new classes.UrlRepository();
            htmlDownloader = new classes.HtmlDownloader();
        }

        private void firstUrlBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnStartScraping_Click(object sender, EventArgs e)
        {
            urlRepository.addItem(firstUrlInput.Text);
            htmlDownloader.downloadSourceOfUrl(urlRepository.getFirstItem());
            foreach (String item in htmlDownloader.retrieveUrls())
                scrapedUrlBox.Text = string.Join(Environment.NewLine, htmlDownloader.retrieveUrls());
            MessageBox.Show("Done scraping Urls!", "WebScraper");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String pastedLinks = pastedUrlBox.Text;
            string[] links = pastedLinks.Split(' ');
            foreach(string link in links)
            {
                urlRepository.addItem(link);
            }
            scrapedUrlBox.Text = string.Join(Environment.NewLine, urlRepository.retrieve());
            MessageBox.Show("Urls added successfully!", "WebScraper");
        }
    }
}
