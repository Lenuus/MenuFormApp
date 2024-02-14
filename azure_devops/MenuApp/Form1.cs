using MenuApp.Model;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenuApp
{
    public partial class Form1 : Form
    {
        public static List<Order> Orders = new List<Order>();

        public Form1()
        {
            InitializeComponent();
        }


        public List<Category> GetAllCategories()
        {

            var data = new List<Category>();
            using (SqlConnection cnn = new SqlConnection(Program.ConnectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Category", cnn))
                {
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var entity = new Category();
                        entity.Id = new Guid(dr["Id"].ToString());
                        entity.Name = dr["Name"].ToString();
                        entity.ImageData = dr["ImageData"].ToString();
                        data.Add(entity);
                    }
                }
                cnn.Close();
            }
            return data;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var categories = GetAllCategories();
            foreach (var category in categories)
            {
                var categoryButton = new System.Windows.Forms.Button();
                categoryButton.Text = category.Name;
                categoryButton.Height = 250;
                categoryButton.Width = 250;
                categoryButton.Image = Image.FromFile(category.ImageData);
                categoryButton.Click += (source, args) =>
                {
                    ProductForm productForm = new ProductForm(category.Id);
                    productForm.Show();
                };
                categoriesArea.Controls.Add(categoryButton);
            }
        }

        public void FillOrders()
        {
            lstViewSepet.Items.Clear();
            if (Orders.Any())
            {
                var products = ProductService.GetAllProducts();
                foreach (var order in Orders)
                {
                    var product = products.FirstOrDefault(f => f.Id == order.ProductId);
                    lstViewSepet.Items.Add(new ListViewItem(new string[3] { product.Name, order.Quantity.ToString(), order.Total.ToString("n") }));
                }

            }

        }

        private void btnSepetiYenile_Click(object sender, EventArgs e)
        {
            FillOrders();
        }

        private void btnSepetBosalt_Click(object sender, EventArgs e)
        {
            Orders.Clear();
            FillOrders();
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            CreateOrder();
            Orders.Clear();
            FillOrders();
        }

        private void CreateOrder()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection cnn = new SqlConnection(Program.ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        string query = string.Empty;
                        foreach (var order in Orders)
                        {
                            query += $"insert into [Order] (Id, ProductId, Quantity, Total, Date) values (newid(), '{order.ProductId}', {order.Quantity}, '{order.Total.ToString().Replace(",", ".")}', getdate());";
                        }
                        cmd.CommandText = query;
                        cmd.Connection = cnn;
                        cmd.ExecuteNonQuery();
                    }
                    cnn.Close();
                }
                scope.Complete();
            }
        }

        public void BringTotal()
        {
            Tot_Income Tot = new Tot_Income();

            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection cnn = new SqlConnection(Program.ConnectionString))
                {
                    cnn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        DataTable Total = new DataTable();
                        string query = "SELECT Product.Name, SUM([Order].Total) AS 'Total' FROM [Order] JOIN Product ON [Order].ProductId = Product.Id GROUP BY Product.Name";

                        cmd.CommandText = query;
                        cmd.Connection = cnn;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(Total);
                        }
                        Tot.Grid.DataSource = Total;
                        Tot.Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        Tot.Grid.Refresh();
                        Tot.Show();
                    }
                }

                scope.Complete();
            }
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            BringTotal();
        }
        Ekle ek = new Ekle();
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ek.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstViewSepet.SelectedItems.Count > 1)
            {
                foreach (ListViewItem eachItem in lstViewSepet.SelectedItems)
                {
                    lstViewSepet.Items.Remove(eachItem);
                }
            }
            else
            {
                lstViewSepet.SelectedItems[0].Remove();
            }
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
        }


    }
}