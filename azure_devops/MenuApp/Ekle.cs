using MenuApp.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace MenuApp
{
    public partial class Ekle : Form
    {
        Order ord = new Order();
        Product product = new Product();
        public Ekle()
        {
            InitializeComponent();
        }


        private void btn_Ekle_Tamamla_Click(object sender, EventArgs e)
        {

            product.Name = txt_productname.Text;
            product.ImageData = txt_ımagedata.Text;
            product.Price = Convert.ToInt32(txt_Price.Text);
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection cnn = new SqlConnection(Program.ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        string query = string.Empty;


                        query = $"insert into Product (Id,Name,CategoryId,ImageData,Price) Values(NEWID(),'{product.Name}','{comboBox1.SelectedValue}','{product.ImageData}',{product.Price})";

                    
                        cmd.CommandText = query;
                        cmd.Connection = cnn;
                        cmd.ExecuteNonQuery();
                    }
                    cnn.Close();
                }
                scope.Complete();
            }

        }

        private void Ekle_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(Program.ConnectionString))
            {
                DataTable dat = new DataTable();
                cnn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    string query = "select ıd, name from Category";

                    cmd.CommandText = query;
                    cmd.Connection = cnn;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dat);
                        comboBox1.DataSource = dat;
                        comboBox1.DisplayMember = "name";
                        comboBox1.ValueMember = "ıd";
                    }

                }
            }
        }
    }


}
