﻿namespace WebScraperAPP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStartScraping = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.firstUrlInput = new System.Windows.Forms.TextBox();
            this.pastedUrlBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.scrapedUrlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.scrapedSentenceBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStartScrape = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.currentURL = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExportLinks = new System.Windows.Forms.Button();
            this.btnExportSentences = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartScraping
            // 
            this.btnStartScraping.Location = new System.Drawing.Point(12, 70);
            this.btnStartScraping.Name = "btnStartScraping";
            this.btnStartScraping.Size = new System.Drawing.Size(91, 23);
            this.btnStartScraping.TabIndex = 0;
            this.btnStartScraping.Text = "Start Scraping";
            this.btnStartScraping.UseVisualStyleBackColor = true;
            this.btnStartScraping.Click += new System.EventHandler(this.btnStartScraping_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter start URL";
            // 
            // firstUrlInput
            // 
            this.firstUrlInput.Location = new System.Drawing.Point(12, 36);
            this.firstUrlInput.Name = "firstUrlInput";
            this.firstUrlInput.Size = new System.Drawing.Size(150, 20);
            this.firstUrlInput.TabIndex = 5;
            this.firstUrlInput.TextChanged += new System.EventHandler(this.firstUrlBox_TextChanged);
            // 
            // pastedUrlBox
            // 
            this.pastedUrlBox.Location = new System.Drawing.Point(12, 166);
            this.pastedUrlBox.Multiline = true;
            this.pastedUrlBox.Name = "pastedUrlBox";
            this.pastedUrlBox.Size = new System.Drawing.Size(228, 131);
            this.pastedUrlBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Paste URL list";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add to scraped list";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // scrapedUrlBox
            // 
            this.scrapedUrlBox.Location = new System.Drawing.Point(264, 36);
            this.scrapedUrlBox.Multiline = true;
            this.scrapedUrlBox.Name = "scrapedUrlBox";
            this.scrapedUrlBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.scrapedUrlBox.Size = new System.Drawing.Size(233, 261);
            this.scrapedUrlBox.TabIndex = 9;
            this.scrapedUrlBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Scraped URLS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Scrape sentences from URLS";
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(264, 354);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(119, 20);
            this.textBoxKeyword.TabIndex = 12;
            this.textBoxKeyword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Scraped sentences";
            // 
            // scrapedSentenceBox
            // 
            this.scrapedSentenceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrapedSentenceBox.BackColor = System.Drawing.Color.White;
            this.scrapedSentenceBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scrapedSentenceBox.Location = new System.Drawing.Point(503, 36);
            this.scrapedSentenceBox.Multiline = true;
            this.scrapedSentenceBox.Name = "scrapedSentenceBox";
            this.scrapedSentenceBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.scrapedSentenceBox.Size = new System.Drawing.Size(467, 347);
            this.scrapedSentenceBox.TabIndex = 14;
            this.scrapedSentenceBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Enter a word";
            // 
            // btnStartScrape
            // 
            this.btnStartScrape.Location = new System.Drawing.Point(264, 380);
            this.btnStartScrape.Name = "btnStartScrape";
            this.btnStartScrape.Size = new System.Drawing.Size(192, 30);
            this.btnStartScrape.TabIndex = 17;
            this.btnStartScrape.Text = "Start scraping sentences";
            this.btnStartScrape.UseVisualStyleBackColor = true;
            this.btnStartScrape.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(35, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Depth";
            // 
            // currentURL
            // 
            this.currentURL.Location = new System.Drawing.Point(12, 370);
            this.currentURL.Name = "currentURL";
            this.currentURL.Size = new System.Drawing.Size(225, 20);
            this.currentURL.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(123, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Only unique URL";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Currently scraping from";
            // 
            // btnExportLinks
            // 
            this.btnExportLinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportLinks.Location = new System.Drawing.Point(503, 400);
            this.btnExportLinks.Name = "btnExportLinks";
            this.btnExportLinks.Size = new System.Drawing.Size(223, 30);
            this.btnExportLinks.TabIndex = 24;
            this.btnExportLinks.Text = "Export urls as .txt";
            this.btnExportLinks.UseVisualStyleBackColor = true;
            this.btnExportLinks.Click += new System.EventHandler(this.btnExportLinks_Click);
            // 
            // btnExportSentences
            // 
            this.btnExportSentences.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportSentences.Location = new System.Drawing.Point(737, 400);
            this.btnExportSentences.Name = "btnExportSentences";
            this.btnExportSentences.Size = new System.Drawing.Size(234, 30);
            this.btnExportSentences.TabIndex = 25;
            this.btnExportSentences.Text = "Export sentences as .txt";
            this.btnExportSentences.UseVisualStyleBackColor = true;
            this.btnExportSentences.Click += new System.EventHandler(this.btnExportSentences_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(985, 440);
            this.Controls.Add(this.btnExportSentences);
            this.Controls.Add(this.btnExportLinks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.currentURL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnStartScrape);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.scrapedSentenceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scrapedUrlBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pastedUrlBox);
            this.Controls.Add(this.firstUrlInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStartScraping);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WebScrapper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartScraping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstUrlInput;
        private System.Windows.Forms.TextBox pastedUrlBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox scrapedUrlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox scrapedSentenceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStartScrape;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox currentURL;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExportLinks;
        private System.Windows.Forms.Button btnExportSentences;
    }
}

