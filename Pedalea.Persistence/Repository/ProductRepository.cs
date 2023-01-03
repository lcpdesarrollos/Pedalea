using Pedalea.DomainEntities.Entities;
using Pedalea.Persistence.Context;
using Pedalea.Persistence.IRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalea.Persistence.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ConnectionStrings Connection;
        public ProductRepository(ConnectionStrings connectionStrings)
        {
            this.Connection = connectionStrings;
        }

        public bool DeleteProduct(int Id)
        {
            int result = 0;

            using (SqlConnection sqlConnection = new SqlConnection(Connection.PedaleaConnectionString()))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "spDeleteProduct";

                    cmd.Parameters.AddWithValue("@Id", Id);

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result > 0 ? true : false;
        }

        public bool EditProduct(ProductEntity entity)
        {
            int result = 0;

            using (SqlConnection sqlConnection = new SqlConnection(Connection.PedaleaConnectionString()))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "spEditProduct";

                    cmd.Parameters.AddWithValue("@Id", entity.Id);
                    cmd.Parameters.AddWithValue("@ProductName", entity.ProductName);
                    cmd.Parameters.AddWithValue("@Description", entity.Description);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result > 0 ? true : false;
        }

        public List<ProductEntity> GetAllProducts()
        {
            List<ProductEntity> products = new List<ProductEntity>();

            using (SqlConnection sqlConnection = new SqlConnection(Connection.PedaleaConnectionString()))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "spSelectProduct";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductEntity product = new ProductEntity();
                            product.Id = reader.GetInt32(0);
                            product.ProductName = reader.GetString(1);
                            product.Description = reader.GetString(2);
                            product.Price = reader.GetDecimal(3);
                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }

        public bool InsertProduct(ProductEntity entity)
        {
            int result = 0;

            using (SqlConnection sqlConnection = new SqlConnection(Connection.PedaleaConnectionString()))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "spInsertProduct";

                    cmd.Parameters.AddWithValue("@ProductName", entity.ProductName);
                    cmd.Parameters.AddWithValue("@Description", entity.Description);
                    cmd.Parameters.AddWithValue("@Price", entity.Price);

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result > 0 ? true : false;
        }
    }
}
