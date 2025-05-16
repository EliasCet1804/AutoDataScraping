namespace MobileAuslesen.UI.UserControls
{
    partial class ucImageBox
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
            this.btnVor = new System.Windows.Forms.Button();
            this.btnZurueck = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVor
            // 
            this.btnVor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVor.Location = new System.Drawing.Point(748, 4);
            this.btnVor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVor.Name = "btnVor";
            this.btnVor.Size = new System.Drawing.Size(179, 406);
            this.btnVor.TabIndex = 3;
            this.btnVor.Text = "----->";
            this.btnVor.UseVisualStyleBackColor = true;
            this.btnVor.Click += new System.EventHandler(this.btnVor_Click);
            // 
            // btnZurueck
            // 
            this.btnZurueck.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnZurueck.Location = new System.Drawing.Point(4, 4);
            this.btnZurueck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZurueck.Name = "btnZurueck";
            this.btnZurueck.Size = new System.Drawing.Size(178, 406);
            this.btnZurueck.TabIndex = 2;
            this.btnZurueck.Text = "<-----";
            this.btnZurueck.UseVisualStyleBackColor = true;
            this.btnZurueck.Click += new System.EventHandler(this.btnZurueck_Click);
            // 
            // pbMain
            // 
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMain.Location = new System.Drawing.Point(190, 4);
            this.pbMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(550, 406);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 1;
            this.pbMain.TabStop = false;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.Controls.Add(this.pbMain, 1, 0);
            this.tlpMain.Controls.Add(this.btnZurueck, 0, 0);
            this.tlpMain.Controls.Add(this.btnVor, 2, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(931, 414);
            this.tlpMain.TabIndex = 0;
            // 
            // ucImageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucImageBox";
            this.Size = new System.Drawing.Size(931, 414);
            this.Resize += new System.EventHandler(this.ucImageBox_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVor;
        private System.Windows.Forms.Button btnZurueck;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
    }
}
