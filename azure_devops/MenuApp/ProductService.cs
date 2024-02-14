using MenuApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp
{
    public class ProductService
    {

        public static List<Product> GetAllProducts()
        {
            var data = new List<Product>();
            using (SqlConnection cnn = new SqlConnection(Program.ConnectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Product", cnn))
                {
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var entity = new Product();
                        entity.Id = new Guid(dr["Id"].ToString());
                        entity.Name = dr["Name"].ToString();
                        entity.ImageData = dr["ImageData"].ToString();
                        entity.Price = Convert.ToDecimal(dr["Price"]);
                        data.Add(entity);
                    }
                }
                cnn.Close();
            }
            return data;
        }
        

        public static List<Product> GetAllProducts(Guid categoryId)
        {
            var data = new List<Product>();
            using (SqlConnection cnn = new SqlConnection(Program.ConnectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Product where CategoryId = @CategoryId", cnn))
                {
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var entity = new Product();
                        entity.Id = new Guid(dr["Id"].ToString());
                        entity.Name = dr["Name"].ToString();
                        entity.ImageData = dr["ImageData"].ToString();
                        entity.Price = Convert.ToDecimal(dr["Price"]);
                        data.Add(entity);
                    }
                }
                cnn.Close();
            }
            return data;
        }
    }
}
