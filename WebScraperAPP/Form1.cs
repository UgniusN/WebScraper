using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
            comboBox1.Items.Add(6);
            comboBox1.Items.Add(7);
            comboBox1.Items.Add(8);
            comboBox1.Items.Add(9);
            comboBox1.Text = "1";
            firstUrlInput.Text = "https://";

        }

        private void firstUrlBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnStartScraping_Click(object sender, EventArgs e)
        {
            if (firstUrlInput.Text == "" || firstUrlInput.Text == "https://")
            {
                MessageBox.Show("Please enter an url", "WebScraper");
            }
            else
            {
                if (IsUrl(firstUrlInput.Text))
                { 
                    urlRepository.addItem(firstUrlInput.Text);
                    htmlDownloader.downloadSourceOfUrl(urlRepository.getFirstItem(),checkBox1.Checked);
                    scrapedUrlBox.Text = string.Join(Environment.NewLine, htmlDownloader.retrieveUrls());
                    downloadUrlsMany(Convert.ToInt32(comboBox1.Text), urlRepository.retrieve());
                    MessageBox.Show("Done scraping Urls!", "WebScraper");
                }
                else
                    MessageBox.Show("Invalid url. Please enter a valid url.", "WebScraper");
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
            if (textBoxKeyword.Text == "")
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static bool IsUrl(string Url)
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

        public void downloadUrlsMany(int depth,List<String> links)
        {

            for(int i=0; i<depth; i++){
                int ilgis = links.Count;
                for (int k=0; k<ilgis; k++)
                {
                    currentURL.Text = links[k];
                    htmlDownloader.downloadSourceOfUrl(links[k],checkBox1.Checked);
                }
            }
        }

        private void btnExportLinks_Click(object sender, EventArgs e)
        {
            exportUrls();
            MessageBox.Show("Urls exported successfully!", "WebScraper");

        }





        private void btnExportSentences_Click(object sender, EventArgs e)
        {
            exportSentences();
            MessageBox.Show("Sentences exported successfully!", "WebScraper");
        }
        public void exportSentences()
        {
            TextWriter tw = new StreamWriter("ExportedSentences.txt");

            foreach (String s in sentenceRepository.retrieve())
                tw.WriteLine(s);

            tw.Close();
        }
        public void exportUrls()
        {
            TextWriter tw = new StreamWriter("ExportedLinks.txt");

            foreach (String s in urlRepository.retrieve())
                tw.WriteLine(s);

            tw.Close();
        }
    }
}
