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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBar
            // 
            this.pnlBar.Controls.Add(this.btnAddToExport);
            this.pnlBar.Controls.Add(this.btnDelete);
            this.pnlBar.Controls.Add(this.btnOeffnen);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBar.MaximumSize = new System.Drawing.Size(0, 53);
            this.pnlBar.MinimumSize = new System.Drawing.Size(0, 53);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(1447, 53);
            this.pnlBar.TabIndex = 4;
            // 
            // btnAddToExport
            // 
            this.btnAddToExport.Location = new System.Drawing.Point(232, 15);
            this.btnAddToExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToExport.Name = "btnAddToExport";
            this.btnAddToExport.Size = new System.Drawing.Size(100, 28);
            this.btnAddToExport.TabIndex = 2;
            this.btnAddToExport.Text = "Zum Export hinzufügen";
            this.btnAddToExport.UseVisualStyleBackColor = true;
            this.btnAddToExport.Visible = false;
            this.btnAddToExport.Click += new System.EventHandler(this.btnAddToExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(124, 15);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOeffnen
            // 
            this.btnOeffnen.Location = new System.Drawing.Point(16, 15);
            this.btnOeffnen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOeffnen.Name = "btnOeffnen";
            this.btnOeffnen.Size = new System.Drawing.Size(100, 28);
            this.btnOeffnen.TabIndex = 0;
            this.btnOeffnen.Text = "Öffnen";
            this.btnOeffnen.UseVisualStyleBackColor = true;
            this.btnOeffnen.Click += new System.EventHandler(this.btnOeffnen_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1447, 501);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // frmAnzeige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlBar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1462, 591);
            this.Name = "frmAnzeige";
            this.Text = "frmAnzegei2";
            this.pnlBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Button btnAddToExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOeffnen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}