using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;

namespace MobileAuslesen.UI.UserControls
{
    public partial class ucTextControl : UserControl
    {
        public ucTextControl(List<ucTextBox> textBoxes, string ueberschrift = "")
        {
            InitializeComponent();

            //Füge Controls hinzu
            AddControls(textBoxes);

            //Setzt alle SplitPos auf den höchsten wert
            ChangeSplitPosition();

            //Füge ggf. überschirft hinzu
            if (string.IsNullOrEmpty(ueberschrift) == false) AddUeberschrift(ueberschrift);
        }

        public ucTextControl(Dictionary<string, string> values, string ueberschrift = "")
        {
            InitializeComponent();

            //Erstellt Controls aus den Values
            var textBoxes = CreateBoxes(values);

            //Füge Controls hinzu
            AddControls(textBoxes);

            //Setzt alle SplitPos auf den höchsten wert
            ChangeSplitPosition();

            //Füge ggf. überschirft hinzu
            if (string.IsNullOrEmpty(ueberschrift) == false) AddUeberschrift(ueberschrift);

            this.Dock = DockStyle.Fill;
        }

        private void AddUeberschrift(string ueberschrift)
        {
            Label lbl = new Label();

            lbl.Text = ueberschrift;
            lbl.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Underline, GraphicsUnit.Point, 0);

            lbl.Dock = DockStyle.Top;
            this.Controls.Add(lbl);

            int place = lbl.Size.Height + 10;

            foreach (var txt in this.Controls.OfType<ucTextBox>())
            {
                txt.Location = new Point(4, txt.Location.Y + place);
            }
        }

        private List<ucTextBox> CreateBoxes(Dictionary<string, string> values)
        {
            List<ucTextBox> ucTextBoxes = new List<ucTextBox>();

            foreach (var pair in values)
            {
                var tmpControl = new ucTextBox();
                tmpControl.AddInfos(pair.Key, pair.Value, true);


                ucTextBoxes.Add(tmpControl);
            }

            return ucTextBoxes;
        }

        private void ChangeSplitPosition()
        {
            var controls = this.Controls.OfType<ucTextBox>();
            if (controls.Count() < 1) return;

            //Finde den Größten wert von SplitPos
            int maxSplitPos = controls.Max(uc => uc.SplitPos);

            foreach (var control in controls)
            {
                control.setSplitPos(maxSplitPos);
            }

        }

        private void AddControls(List<ucTextBox> textBoxes)
        {
            int lastPos = 0;
            foreach (var box in textBoxes)
            {
                this.Controls.Add(box);
                box.Location = new Point(4, lastPos);

                lastPos = box.Location.Y + box.Size.Height + 6;
            }
        }
    }
}
