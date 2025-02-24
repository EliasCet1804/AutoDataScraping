namespace MobileAuslesen.UI.UserControls
{
    partial class ucGrundDaten
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitel = new MobileAuslesen.UI.UserControls.ucTextBox();
            this.txtKurzBeschreibung = new MobileAuslesen.UI.UserControls.ucTextBox();
            this.txtPreis = new MobileAuslesen.UI.UserControls.ucTextBox();
            this.SuspendLayout();
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(3, 3);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.ReadOnly = false;
            this.txtTitel.Size = new System.Drawing.Size(348, 21);
            this.txtTitel.SplitPos = 30;
            this.txtTitel.TabIndex = 0;
            this.txtTitel.TextBoxText = "";
            this.txtTitel.Titel = "Titel";
            // 
            // txtKurzBeschreibung
            // 
            this.txtKurzBeschreibung.Location = new System.Drawing.Point(3, 30);
            this.txtKurzBeschreibung.Name = "txtKurzBeschreibung";
            this.txtKurzBeschreibung.ReadOnly = false;
            this.txtKurzBeschreibung.Size = new System.Drawing.Size(348, 21);
            this.txtKurzBeschreibung.SplitPos = 95;
            this.txtKurzBeschreibung.TabIndex = 1;
            this.txtKurzBeschreibung.TextBoxText = "";
            this.txtKurzBeschreibung.Titel = "Kurzbeschreibung";
            // 
            // txtPreis
            // 
            this.txtPreis.Location = new System.Drawing.Point(3, 57);
            this.txtPreis.Name = "txtPreis";
            this.txtPreis.ReadOnly = false;
            this.txtPreis.Size = new System.Drawing.Size(348, 21);
            this.txtPreis.SplitPos = 33;
            this.txtPreis.TabIndex = 2;
            this.txtPreis.TextBoxText = "";
            this.txtPreis.Titel = "Preis";
            // 
            // ucGrundDaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPreis);
            this.Controls.Add(this.txtKurzBeschreibung);
            this.Controls.Add(this.txtTitel);
            this.Name = "ucGrundDaten";
            this.Size = new System.Drawing.Size(355, 264);
            this.ResumeLayout(false);

        }

        #endregion

        private ucTextBox txtTitel;
        private ucTextBox txtKurzBeschreibung;
        private ucTextBox txtPreis;
    }
}
