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
            this.pnlBar = new System.Windows.Forms.Panel();
            this.btnAddToExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOeffnen = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlInformationen = new System.Windows.Forms.Panel();
            this.pnlBeschreibung = new System.Windows.Forms.Panel();
            this.pnlBar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBar
            // 
            this.pnlBar.Controls.Add(this.btnAddToExport);
            this.pnlBar.Controls.Add(this.btnDelete);
            this.pnlBar.Controls.Add(this.btnOeffnen);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.MaximumSize = new System.Drawing.Size(0, 43);
            this.pnlBar.MinimumSize = new System.Drawing.Size(0, 43);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(800, 43);
            this.pnlBar.TabIndex = 3;
            // 
            // btnAddToExport
            // 
            this.btnAddToExport.Location = new System.Drawing.Point(174, 12);
            this.btnAddToExport.Name = "btnAddToExport";
            this.btnAddToExport.Size = new System.Drawing.Size(75, 23);
            this.btnAddToExport.TabIndex = 2;
            this.btnAddToExport.Text = "Zum Export hinzufügen";
            this.btnAddToExport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOeffnen
            // 
            this.btnOeffnen.Location = new System.Drawing.Point(12, 12);
            this.btnOeffnen.Name = "btnOeffnen";
            this.btnOeffnen.Size = new System.Drawing.Size(75, 23);
            this.btnOeffnen.TabIndex = 0;
            this.btnOeffnen.Text = "Öffnen";
            this.btnOeffnen.UseVisualStyleBackColor = true;
            this.btnOeffnen.Click += new System.EventHandler(this.btnOeffnen_Click_1);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlBeschreibung);
            this.pnlMain.Controls.Add(this.pnlInformationen);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 43);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 407);
            this.pnlMain.TabIndex = 4;
            // 
            // pnlInformationen
            // 
            this.pnlInformationen.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInformationen.Location = new System.Drawing.Point(0, 0);
            this.pnlInformationen.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.pnlInformationen.Name = "pnlInformationen";
            this.pnlInformationen.Size = new System.Drawing.Size(341, 407);
            this.pnlInformationen.TabIndex = 3;
            // 
            // pnlBeschreibung
            // 
            this.pnlBeschreibung.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBeschreibung.Location = new System.Drawing.Point(420, 0);
            this.pnlBeschreibung.Name = "pnlBeschreibung";
            this.pnlBeschreibung.Size = new System.Drawing.Size(380, 407);
            this.pnlBeschreibung.TabIndex = 4;
            // 
            // frmAnzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBar);
            this.Name = "frmAnzeige";
            this.Text = "frmAnzeige";
            this.pnlBar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Button btnAddToExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOeffnen;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlInformationen;
        private System.Windows.Forms.Panel pnlBeschreibung;
    }
}