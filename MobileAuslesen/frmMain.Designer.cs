namespace MobileAuslesen
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurzbeschreibungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anbieterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAnzeigen = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnzeigen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 43);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(174, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Anschauen";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(93, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Entfernen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titelDataGridViewTextBoxColumn,
            this.kurzbeschreibungDataGridViewTextBoxColumn,
            this.preisDataGridViewTextBoxColumn,
            this.anbieterNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsAnzeigen;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(564, 154);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titelDataGridViewTextBoxColumn
            // 
            this.titelDataGridViewTextBoxColumn.DataPropertyName = "Titel";
            this.titelDataGridViewTextBoxColumn.HeaderText = "Titel";
            this.titelDataGridViewTextBoxColumn.Name = "titelDataGridViewTextBoxColumn";
            this.titelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kurzbeschreibungDataGridViewTextBoxColumn
            // 
            this.kurzbeschreibungDataGridViewTextBoxColumn.DataPropertyName = "Kurzbeschreibung";
            this.kurzbeschreibungDataGridViewTextBoxColumn.HeaderText = "Kurzbeschreibung";
            this.kurzbeschreibungDataGridViewTextBoxColumn.Name = "kurzbeschreibungDataGridViewTextBoxColumn";
            this.kurzbeschreibungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preisDataGridViewTextBoxColumn
            // 
            this.preisDataGridViewTextBoxColumn.DataPropertyName = "Preis";
            this.preisDataGridViewTextBoxColumn.HeaderText = "Preis";
            this.preisDataGridViewTextBoxColumn.Name = "preisDataGridViewTextBoxColumn";
            this.preisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anbieterNameDataGridViewTextBoxColumn
            // 
            this.anbieterNameDataGridViewTextBoxColumn.DataPropertyName = "AnbieterName";
            this.anbieterNameDataGridViewTextBoxColumn.HeaderText = "AnbieterName";
            this.anbieterNameDataGridViewTextBoxColumn.Name = "anbieterNameDataGridViewTextBoxColumn";
            this.anbieterNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsAnzeigen
            // 
            this.bsAnzeigen.DataSource = typeof(MobileAuslesen.Models.Anzeige);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 197);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(580, 236);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnzeigen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsAnzeigen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kurzbeschreibungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anbieterNameDataGridViewTextBoxColumn;
    }
}