using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileAuslesen.Models;

namespace MobileAuslesen.UI.UserControls
{
    public partial class ucImageBox : UserControl
    {

        private List<Bild> Images;
        private int Index = 0;
        public ucImageBox()
        {
            InitializeComponent();
        }
        private void SetImageSize(Image img)
        {
            // Berechne die Breite der PictureBox basierend auf dem Seitenverhältnis des Bildes
            float aspectRatio = (float)img.Width / img.Height;
            int newWidth = (int)(this.Height * aspectRatio);

            // Setze die neue Breite der PictureBox
            pbMain.Width = newWidth;

            // Setze den SizeMode auf Zoom, damit das Bild korrekt skaliert wird
            pbMain.SizeMode = PictureBoxSizeMode.Zoom;

            // Setze das Bild in die PictureBox
            pbMain.Image = img;
        }

        public void AddPictures(List<Bild> images)
        {
            //Vorabüberprüfung
            if (images == null || images.Count < 1) return;

            this.Images = images;

            SetImageSize(Images[0].Image);
            this.Index = 0;
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            //Vorabüberprüfung
            if (this.Images == null || this.Images.Count < 1) return;

            if ((this.Index - 1) < 0) this.Index = Images.Count - 1;
            else this.Index--;

            SetImageSize(Images[this.Index].Image);
        }

        private void btnVor_Click(object sender, EventArgs e)
        {
            //Vorabüberprüfung
            if (this.Images == null || this.Images.Count < 1) return;

            if ((this.Index + 1) >= this.Images.Count) this.Index = 0;
            else this.Index++;

            SetImageSize(Images[this.Index].Image);
        }

        private void ucImageBox_Resize(object sender, EventArgs e)
        {
        }
    }
}
