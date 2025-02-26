using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileAuslesen.UI.UserControls
{
    public partial class ucTextBox : UserControl
    {
        public bool ReadOnly
        {
            get
            { return this.txtInfo.ReadOnly; }
            set
            {
                this.txtInfo.ReadOnly = value;
            }
        }

        public string Titel
        {
            get
            { return this.lblInfo.Text; }
            set
            {
                //OnTitleChanged();
                this.lblInfo.Text = value;
            }
        }
        public string TextBoxText
        {
            get
            { return this.txtInfo.Text; }
            set
            {
                this.txtInfo.Text = value;
            }
        }

        public int SplitPos { get; set; }

        public ucTextBox()
        {
            InitializeComponent();
        }

        private void lblInfo_SizeChanged(object sender, EventArgs e)
        {
            int splitPos = lblInfo.Location.X + lblInfo.Size.Width;
            this.SplitPos = splitPos;

            panel1.Size = new Size(splitPos, panel1.Size.Height);
        }


        public void AddInfos(string titel, string textBoxText, bool isReadOnly)
        {
            this.Titel = titel;
            this.TextBoxText = textBoxText;
            this.ReadOnly = isReadOnly;
        }

        internal void SetSplitPos(int splitPos)
        {
            this.SplitPos = splitPos;
            panel1.Size = new Size(splitPos, panel1.Size.Height);
        }

        internal string GetSelectedText()
        {
            return txtInfo.SelectedText;
        }
    }
}
