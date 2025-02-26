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
            this.clbConfigs = new System.Windows.Forms.CheckedListBox();
            this.ucTextBox1 = new MobileAuslesen.UI.UserControls.ucTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlBar.SuspendLayout();
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
            // clbConfigs
            // 
            this.clbConfigs.FormattingEnabled = true;
            this.clbConfigs.Location = new System.Drawing.Point(193, 181);
            this.clbConfigs.Name = "clbConfigs";
            this.clbConfigs.Size = new System.Drawing.Size(120, 94);
            this.clbConfigs.TabIndex = 6;
            // 
            // ucTextBox1
            // 
            this.ucTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTextBox1.Location = new System.Drawing.Point(0, 43);
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.ReadOnly = false;
            this.ucTextBox1.Size = new System.Drawing.Size(800, 20);
            this.ucTextBox1.SplitPos = 0;
            this.ucTextBox1.TabIndex = 7;
            this.ucTextBox1.TextBoxText = "";
            this.ucTextBox1.Titel = "aaa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // frmSetConfigEintrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ucTextBox1);
            this.Controls.Add(this.clbConfigs);
            this.Controls.Add(this.pnlBar);
            this.Name = "frmSetConfigEintrag";
            this.Text = "ConfigEintrag empfangen";
            this.pnlBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckedListBox clbConfigs;
        private UserControls.ucTextBox ucTextBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}