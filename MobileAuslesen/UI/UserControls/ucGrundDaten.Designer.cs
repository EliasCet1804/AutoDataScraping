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
            this.txtErstzulassung = new MobileAuslesen.UI.UserControls.ucTextBox();
            this.txtKilometer = new MobileAuslesen.UI.UserControls.ucTextBox();
            this.txtPreis = new MobileAuslesen.UI.UserControls.ucTextBox();
            this.txtKurzBeschreibung = new MobileAuslesen.UI.UserControls.ucTextBox();
            this.txtTitel = new MobileAuslesen.UI.UserControls.ucTextBox();
            this.lblGrunddaten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtErstzulassung
            // 
            this.txtErstzulassung.Location = new System.Drawing.Point(4, 156);
            this.txtErstzulassung.Name = "txtErstzulassung";
            this.txtErstzulassung.ReadOnly = false;
            this.txtErstzulassung.Size = new System.Drawing.Size(348, 20);
            this.txtErstzulassung.SplitPos = 75;
            this.txtErstzulassung.TabIndex = 4;
            this.txtErstzulassung.TextBoxText = "";
            this.txtErstzulassung.Titel = "Erstzulassung";
            // 
            // txtKilometer
            // 
            this.txtKilometer.Location = new System.Drawing.Point(4, 130);
            this.txtKilometer.Name = "txtKilometer";
            this.txtKilometer.ReadOnly = false;
            this.txtKilometer.Size = new System.Drawing.Size(348, 20);
            this.txtKilometer.SplitPos = 79;
            this.txtKilometer.TabIndex = 3;
            this.txtKilometer.TextBoxText = "";
            this.txtKilometer.Titel = "Kilometerstand";
            // 
            // txtPreis
            // 
            this.txtPreis.Location = new System.Drawing.Point(4, 103);
            this.txtPreis.Name = "txtPreis";
            this.txtPreis.ReadOnly = false;
            this.txtPreis.Size = new System.Drawing.Size(348, 21);
            this.txtPreis.SplitPos = 33;
            this.txtPreis.TabIndex = 2;
            this.txtPreis.TextBoxText = "";
            this.txtPreis.Titel = "Preis";
            // 
            // txtKurzBeschreibung
            // 
            this.txtKurzBeschreibung.Location = new System.Drawing.Point(4, 76);
            this.txtKurzBeschreibung.Name = "txtKurzBeschreibung";
            this.txtKurzBeschreibung.ReadOnly = false;
            this.txtKurzBeschreibung.Size = new System.Drawing.Size(348, 21);
            this.txtKurzBeschreibung.SplitPos = 95;
            this.txtKurzBeschreibung.TabIndex = 1;
            this.txtKurzBeschreibung.TextBoxText = "";
            this.txtKurzBeschreibung.Titel = "Kurzbeschreibung";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(4, 49);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.ReadOnly = false;
            this.txtTitel.Size = new System.Drawing.Size(348, 21);
            this.txtTitel.SplitPos = 30;
            this.txtTitel.TabIndex = 0;
            this.txtTitel.TextBoxText = "";
            this.txtTitel.Titel = "Titel";
            // 
            // lblGrunddaten
            // 
            this.lblGrunddaten.AutoSize = true;
            this.lblGrunddaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrunddaten.Location = new System.Drawing.Point(3, 10);
            this.lblGrunddaten.Name = "lblGrunddaten";
            this.lblGrunddaten.Size = new System.Drawing.Size(117, 24);
            this.lblGrunddaten.TabIndex = 5;
            this.lblGrunddaten.Text = "Grund Daten";
            // 
            // ucGrundDaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGrunddaten);
            this.Controls.Add(this.txtErstzulassung);
            this.Controls.Add(this.txtKilometer);
            this.Controls.Add(this.txtPreis);
            this.Controls.Add(this.txtKurzBeschreibung);
            this.Controls.Add(this.txtTitel);
            this.Name = "ucGrundDaten";
            this.Size = new System.Drawing.Size(356, 182);
            this.Load += new System.EventHandler(this.ucGrundDaten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucTextBox txtTitel;
        private ucTextBox txtKurzBeschreibung;
        private ucTextBox txtPreis;
        private ucTextBox txtKilometer;
        private ucTextBox txtErstzulassung;
        private System.Windows.Forms.Label lblGrunddaten;
    }
}
