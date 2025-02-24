namespace MobileAuslesen.UI
{
    partial class frmAnzeige
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
            this.btnOeffnen = new System.Windows.Forms.Button();
            this.pnlGrundDaten = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnOeffnen
            // 
            this.btnOeffnen.Location = new System.Drawing.Point(713, 12);
            this.btnOeffnen.Name = "btnOeffnen";
            this.btnOeffnen.Size = new System.Drawing.Size(75, 23);
            this.btnOeffnen.TabIndex = 1;
            this.btnOeffnen.Text = "Öffne Anzeige";
            this.btnOeffnen.UseVisualStyleBackColor = true;
            this.btnOeffnen.Click += new System.EventHandler(this.btnOeffnen_Click);
            // 
            // pnlGrundDaten
            // 
            this.pnlGrundDaten.Location = new System.Drawing.Point(0, 0);
            this.pnlGrundDaten.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.pnlGrundDaten.Name = "pnlGrundDaten";
            this.pnlGrundDaten.Size = new System.Drawing.Size(200, 100);
            this.pnlGrundDaten.TabIndex = 2;
            // 
            // frmAnzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGrundDaten);
            this.Controls.Add(this.btnOeffnen);
            this.Name = "frmAnzeige";
            this.Text = "frmAnzeige";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOeffnen;
        private System.Windows.Forms.Panel pnlGrundDaten;
    }
}