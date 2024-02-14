namespace MenuApp
{
    partial class ProductForm
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
            this.productsArea = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // productsArea
            // 
            this.productsArea.Location = new System.Drawing.Point(14, 16);
            this.productsArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productsArea.Name = "productsArea";
            this.productsArea.Size = new System.Drawing.Size(887, 265);
            this.productsArea.TabIndex = 0;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 431);
            this.Controls.Add(this.productsArea);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel productsArea;
    }
}