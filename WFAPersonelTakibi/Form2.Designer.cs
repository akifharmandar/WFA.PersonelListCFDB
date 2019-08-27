namespace WFAPersonelTakibi
{
    partial class Form2
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.cmsMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.tsmDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDetay = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbDepartmanlar = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.ContextMenuStrip = this.cmsMenu;
            this.dgvEmployees.Location = new System.Drawing.Point(20, 102);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(760, 327);
            this.dgvEmployees.TabIndex = 1;
            // 
            // cmsMenu
            // 
            this.cmsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDuzenle,
            this.tsmSil,
            this.tsmYeni,
            this.tsmDetay});
            this.cmsMenu.Name = "metroContextMenu1";
            this.cmsMenu.Size = new System.Drawing.Size(181, 114);
            // 
            // tsmDuzenle
            // 
            this.tsmDuzenle.Name = "tsmDuzenle";
            this.tsmDuzenle.Size = new System.Drawing.Size(180, 22);
            this.tsmDuzenle.Text = "Düzenle";
            this.tsmDuzenle.Click += new System.EventHandler(this.TsmDuzenle_Click);
            // 
            // tsmSil
            // 
            this.tsmSil.Name = "tsmSil";
            this.tsmSil.Size = new System.Drawing.Size(180, 22);
            this.tsmSil.Text = "Sil";
            this.tsmSil.Click += new System.EventHandler(this.TsmSil_Click);
            // 
            // tsmYeni
            // 
            this.tsmYeni.Name = "tsmYeni";
            this.tsmYeni.Size = new System.Drawing.Size(180, 22);
            this.tsmYeni.Text = "Yeni Kayıt";
            this.tsmYeni.Click += new System.EventHandler(this.TsmYeni_Click);
            // 
            // tsmDetay
            // 
            this.tsmDetay.Name = "tsmDetay";
            this.tsmDetay.Size = new System.Drawing.Size(180, 22);
            this.tsmDetay.Text = "Detay";
            this.tsmDetay.Click += new System.EventHandler(this.TsmDetay_Click);
            // 
            // cmbDepartmanlar
            // 
            this.cmbDepartmanlar.FormattingEnabled = true;
            this.cmbDepartmanlar.ItemHeight = 23;
            this.cmbDepartmanlar.Location = new System.Drawing.Point(20, 63);
            this.cmbDepartmanlar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDepartmanlar.Name = "cmbDepartmanlar";
            this.cmbDepartmanlar.Size = new System.Drawing.Size(761, 29);
            this.cmbDepartmanlar.TabIndex = 2;
            this.cmbDepartmanlar.UseSelectable = true;
            this.cmbDepartmanlar.SelectionChangeCommitted += new System.EventHandler(this.CmbDepartmanlar_SelectionChangeCommitted);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbDepartmanlar);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private MetroFramework.Controls.MetroContextMenu cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmDuzenle;
        private System.Windows.Forms.ToolStripMenuItem tsmSil;
        private System.Windows.Forms.ToolStripMenuItem tsmYeni;
        private System.Windows.Forms.ToolStripMenuItem tsmDetay;
        private MetroFramework.Controls.MetroComboBox cmbDepartmanlar;
    }
}