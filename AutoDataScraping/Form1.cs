using AutoDataScraping.Controller.InstanzController;
using AutoDataScraping.Controller.StaticController;
using AutoDataScraping.Models;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Security.Policy;
using System.IO;
using System.Web;
using Newtonsoft.Json;

namespace AutoDataScraping
{
    public partial class Form1 : Form
    {

        private List<Anzeige> anzeigeList;
        private WebSiteReader WebSiteReader;

        public Form1()
        {
            InitializeComponent();
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            //Vorabüberprüfung
            if (string.IsNullOrEmpty(textBox1.Text) || Uri.TryCreate(textBox1.Text, UriKind.Absolute, out Uri uriresult) == false) return;


            if (this.WebSiteReader == null) this.WebSiteReader = new WebSiteReader();

            var htmlDoc = await WebSiteReader.GetHtmlDocumenthttp(textBox1.Text);

            Anzeige anzeige = HtmlDocumentController.CreateAnzeige(htmlDoc, textBox1.Text);
            if (anzeige == null) return;

            if (anzeigeList == null) anzeigeList = new List<Anzeige>();

            anzeigeList.Add(anzeige);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Vorabüberprüfung
            if (this.anzeigeList == null || this.anzeigeList.Count < 1) return;

            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.ShowDialog();

            if (string.IsNullOrEmpty(fileDialog.FileName)) return;

            string jsonString = JsonConvert.SerializeObject(this.anzeigeList);

            File.WriteAllText(fileDialog.FileName, jsonString);

        }
    }
}
