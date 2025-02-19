using MobileAuslesen.Controller.InstanzController;
using MobileAuslesen.Events;
using MobileAuslesen.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileAuslesen.UI
{
    public partial class frmNew : Form
    {
        public frmNew()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            //Vorabüberprüfung
            if (string.IsNullOrEmpty(textBox1.Text) || Uri.TryCreate(textBox1.Text, UriKind.Absolute, out Uri uriresult) == false || uriresult.Host == "https://www.mobile.de")
            {
                this.lblInfo.Text = "URL konnte nicht ausgelesen werden, bitte überprüfe";
                this.lblInfo.ForeColor = Color.Red;
                return;
            }
            //Lese die URL ein und erstelle html doc
            WebSiteReader webSiteReader = new WebSiteReader();
            var code = await webSiteReader.GetHtmlCode(textBox1.Text);

            WebSocketData ws = new WebSocketData();
            ws.Url = textBox1.Text;
            ws.HtmlCode = code;

            WebSocketEventPool.TriggerMessageReceive(ws);

            DialogResult = DialogResult.OK;

        }
    }
}
