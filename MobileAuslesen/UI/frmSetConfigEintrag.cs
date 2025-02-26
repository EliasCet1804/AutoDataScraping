using MobileAuslesen.Models;
using System;
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
    public partial class frmSetConfigEintrag : Form
    {
        internal frmSetConfigEintrag(WebSocketData data)
        {
            InitializeComponent();

            //Vorabüberprüfung
            if (data == null) return;

            this.ucTextBox1.AddInfos("Empfangene Nachricht:", data.HtmlCode, true);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var x = this.ucTextBox1.GetSelectedText();
        }
    }
}
