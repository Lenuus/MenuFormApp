namespace MenuApp
{
    partial class Ekle
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
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_ımagedata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Ekle_Tamamla = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(153, 31);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(125, 27);
            this.txt_productname.TabIndex = 0;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(153, 126);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(125, 27);
            this.txt_Price.TabIndex = 2;
            // 
            // txt_ımagedata
            // 
            this.txt_ımagedata.Location = new System.Drawing.Point(153, 178);
            this.txt_ımagedata.Name = "txt_ımagedata";
            this.txt_ımagedata.Size = new System.Drawing.Size(125, 27);
            this.txt_ımagedata.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Image Data";
            // 
            // btn_Ekle_Tamamla
            // 
            this.btn_Ekle_Tamamla.Location = new System.Drawing.Point(262, 248);
            this.btn_Ekle_Tamamla.Name = "btn_Ekle_Tamamla";
            this.btn_Ekle_Tamamla.Size = new System.Drawing.Size(94, 29);
            this.btn_Ekle_Tamamla.TabIndex = 8;
            this.btn_Ekle_Tamamla.Text = "Complete";
            this.btn_Ekle_Tamamla.UseVisualStyleBackColor = true;
            this.btn_Ekle_Tamamla.Click += new System.EventHandler(this.btn_Ekle_Tamamla_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 310);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Ekle_Tamamla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ımagedata);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_productname);
            this.Name = "Ekle";
            this.Text = "Ekle";
            this.Load += new System.EventHandler(this.Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_productname;
        private TextBox txt_Price;
        private TextBox txt_ımagedata;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_Ekle_Tamamla;
        private ComboBox comboBox1;
    }
}