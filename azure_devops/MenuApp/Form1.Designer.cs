namespace MenuApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoriesArea = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.lstViewSepet = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnSepetBosalt = new System.Windows.Forms.Button();
            this.btnSepetiYenile = new System.Windows.Forms.Button();
            this.btn_Total = new System.Windows.Forms.Button();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesArea.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesArea
            // 
            this.categoriesArea.Controls.Add(this.menuStrip1);
            this.categoriesArea.Location = new System.Drawing.Point(12, 13);
            this.categoriesArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoriesArea.Name = "categoriesArea";
            this.categoriesArea.Size = new System.Drawing.Size(1158, 422);
            this.categoriesArea.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(312, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.Location = new System.Drawing.Point(853, 560);
            this.btnSiparisTamamla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(148, 129);
            this.btnSiparisTamamla.TabIndex = 3;
            this.btnSiparisTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // lstViewSepet
            // 
            this.lstViewSepet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstViewSepet.FullRowSelect = true;
            this.lstViewSepet.Location = new System.Drawing.Point(12, 443);
            this.lstViewSepet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstViewSepet.Name = "lstViewSepet";
            this.lstViewSepet.Size = new System.Drawing.Size(835, 246);
            this.lstViewSepet.TabIndex = 1;
            this.lstViewSepet.UseCompatibleStateImageBehavior = false;
            this.lstViewSepet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 240;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Miktarı";
            this.columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ToplamTutar";
            this.columnHeader3.Width = 240;
            // 
            // btnSepetBosalt
            // 
            this.btnSepetBosalt.Location = new System.Drawing.Point(1007, 449);
            this.btnSepetBosalt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSepetBosalt.Name = "btnSepetBosalt";
            this.btnSepetBosalt.Size = new System.Drawing.Size(163, 103);
            this.btnSepetBosalt.TabIndex = 2;
            this.btnSepetBosalt.Text = "Sepeti Boşalt";
            this.btnSepetBosalt.UseVisualStyleBackColor = true;
            this.btnSepetBosalt.Click += new System.EventHandler(this.btnSepetBosalt_Click);
            // 
            // btnSepetiYenile
            // 
            this.btnSepetiYenile.Location = new System.Drawing.Point(853, 449);
            this.btnSepetiYenile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSepetiYenile.Name = "btnSepetiYenile";
            this.btnSepetiYenile.Size = new System.Drawing.Size(148, 103);
            this.btnSepetiYenile.TabIndex = 4;
            this.btnSepetiYenile.Text = "Sepeti Yenile";
            this.btnSepetiYenile.UseVisualStyleBackColor = true;
            this.btnSepetiYenile.Click += new System.EventHandler(this.btnSepetiYenile_Click);
            // 
            // btn_Total
            // 
            this.btn_Total.Location = new System.Drawing.Point(1007, 560);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(163, 129);
            this.btn_Total.TabIndex = 5;
            this.btn_Total.Text = "Toplam Satış";
            this.btn_Total.UseVisualStyleBackColor = true;
            this.btn_Total.Click += new System.EventHandler(this.btn_Total_Click);
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.listeleToolStripMenuItem.Text = "Listele";
            this.listeleToolStripMenuItem.Click += new System.EventHandler(this.listeleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btn_Total);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.btnSepetiYenile);
            this.Controls.Add(this.btnSepetBosalt);
            this.Controls.Add(this.lstViewSepet);
            this.Controls.Add(this.categoriesArea);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.categoriesArea.ResumeLayout(false);
            this.categoriesArea.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel categoriesArea;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnSepetBosalt;
        private Button btnSiparisTamamla;
        private Button btnSepetiYenile;
        public ListView lstViewSepet;
        private Button btn_Total;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ekleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem listeleToolStripMenuItem;
    }
}