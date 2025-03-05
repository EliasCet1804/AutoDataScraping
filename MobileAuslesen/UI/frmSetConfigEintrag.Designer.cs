namespace MobileAuslesen.UI
{
    partial class frmSetConfigEintrag
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
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlTexte = new System.Windows.Forms.Panel();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pnlBar.SuspendLayout();
            this.pnlTexte.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBar
            // 
            this.pnlBar.Controls.Add(this.btnCancle);
            this.pnlBar.Controls.Add(this.btnSave);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.MaximumSize = new System.Drawing.Size(0, 43);
            this.pnlBar.MinimumSize = new System.Drawing.Size(0, 43);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(800, 43);
            this.pnlBar.TabIndex = 5;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(93, 12);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "Abbrechen";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlTexte
            // 
            this.pnlTexte.Controls.Add(this.btnSelect);
            this.pnlTexte.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTexte.Location = new System.Drawing.Point(0, 43);
            this.pnlTexte.Name = "pnlTexte";
            this.pnlTexte.Size = new System.Drawing.Size(800, 75);
            this.pnlTexte.TabIndex = 6;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 49);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Auswählen";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 124);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(442, 199);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // frmSetConfigEintrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pnlTexte);
            this.Controls.Add(this.pnlBar);
            this.Name = "frmSetConfigEintrag";
            this.Text = "ConfigEintrag empfangen";
            this.pnlBar.ResumeLayout(false);
            this.pnlTexte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlTexte;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}