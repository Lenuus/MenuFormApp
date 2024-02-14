using MenuApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuApp
{

    //openfile dialog button
    public partial class ProductForm : Form
    {
        Form1 frm = new Form1();


        private Guid _categoryId;
        public ProductForm(Guid categoryId)
        {
            InitializeComponent();
            _categoryId = categoryId;
        }


        public void ProductForm_Load(object sender, EventArgs e)
        {

            this.Text = $"{_categoryId} kategorisine ait ürünler";
            var products = ProductService.GetAllProducts(_categoryId);
            foreach (var product in products)
            {
                var productButton = new Button();
                productButton.Text = product.Name;
                productButton.Height = 250;
                productButton.Width = 250;
                productButton.Image = Image.FromFile(product.ImageData);
                productButton.Click += (source, args) =>
                {
                    var orders = Form1.Orders;
                    var order = orders.FirstOrDefault(f => f.ProductId == product.Id);
                    if (order != null)
                    {
                        order.Quantity++;
                        order.Total += product.Price;
                    }
                    else
                    {
                        Form1.Orders.Add(new Order { ProductId = product.Id, Quantity = 1, Total = product.Price });
                    }

                };
               

                productsArea.Controls.Add(productButton);
            }
        }

    }
}
