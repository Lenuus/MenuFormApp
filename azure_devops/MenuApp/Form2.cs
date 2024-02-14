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
using MenuApp.Model;


namespace MenuApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            var data = Listele();
            foreach (var item in data)
            {
                listView1.Items.Add(new ListViewItem(item.Split(',')));
            }
        }

        public List<string> Listele()
        {
            var data = new List<string>();
            using (SqlConnection cnn = new SqlConnection(Program.ConnectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select Name,Price from Product", cnn))
                {
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        data.Add(dr["Name"].ToString() + "," + dr["Price"].ToString());
                    }
                }
                cnn.Close();
            }
            return data;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
