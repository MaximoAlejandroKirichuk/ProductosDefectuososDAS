using BE;
using BE.actores;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class ProductoDAL 
    {
        string stringConnection = StringConnection.stringConnection;
        public bool Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                //TODO: VERIFICAR QUERY
                string query = "DELETE FROM Producto WHERE CodigoProducto = @CodigoProducto";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@CodigoProducto", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Insertar(Producto objeto)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                //TODO QUERY
                string query = @"
            INSERT INTO Producto (
                CostoProducto,
                CondicionProducto,
                NombreProducto,
                ProblemaEntrada,
                Cliente,
                FechaRecibida,
                FechaEstimadaDevolucion,
                Dimensiones,
                CostoPerdidaManoObra,
                CostoPerdidaMateriaPrima,
                FechaDevolucionReal
            )
            VALUES (
                @CostoProducto,
                @CondicionProducto,
                @NombreProducto,
                @ProblemaEntrada,
                @Cliente,
                @FechaRecibida,
                @FechaEstimadaDevolucion,
                @Dimensiones,
                @CostoPerdidaManoObra,
                @CostoPerdidaMateriaPrima,
                @FechaDevolucionReal
            );";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    // Parámetros
                    cmd.Parameters.AddWithValue("@CostoProducto", objeto.CostoProducto);
                    cmd.Parameters.AddWithValue("@CondicionProducto", objeto.CondicionProducto.ToString());
                    cmd.Parameters.AddWithValue("@NombreProducto", objeto.NombreProducto);
                    cmd.Parameters.AddWithValue("@ProblemaEntrada", objeto.ProblemaEntrada);
                    cmd.Parameters.AddWithValue("@Cliente", objeto.Cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@FechaRecibida",objeto.FechaRecibidaProducto);
                    cmd.Parameters.AddWithValue("@FechaEstimadaDevolucion",objeto.FechaEstimadaDevolucion);
                    cmd.Parameters.AddWithValue("@Dimensiones", objeto.Dimensiones.ToString());
                    cmd.Parameters.AddWithValue("@CostoPerdidaManoObra", objeto.CostoManoObra);
                    cmd.Parameters.AddWithValue("@CostoPerdidaMateriaPrima", objeto.CostoPerdidaMateriaPrima);
                    cmd.Parameters.AddWithValue("@FechaDevolucionReal", DBNull.Value);
                   

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool ExisteProducto(int codigoProducto)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = "SELECT COUNT(*) FROM Producto WHERE CodigoProducto = @CodigoProducto";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public List<Producto> ObtenerTodos()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = "SELECT * FROM Producto";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dimensiones dimensiones = null;
                            string dimensionesString = reader["Dimensiones"].ToString();

                            if (!string.IsNullOrEmpty(dimensionesString))
                            {
                                try
                                {
                                    string[] partes = dimensionesString.Split('x');

                                    decimal ancho = decimal.Parse(partes[0].Replace("Ancho:", "").Trim());
                                    decimal largo = decimal.Parse(partes[1].Replace("Largo:", "").Trim());
                                    decimal alto = decimal.Parse(partes[2].Replace("Alto:", "").Trim());

                                    dimensiones = new Dimensiones(ancho, largo, alto);
                                }
                                catch
                                {
                                    dimensiones = new Dimensiones(0, 0, 0);
                                }
                            }

                            Producto p = new Producto
                            {
                                CodigoProducto = Convert.ToInt32(reader["CodigoProducto"]),
                                NombreProducto = reader["NombreProducto"].ToString(),
                                CondicionProducto = (CondicionProducto)Enum.Parse(typeof(CondicionProducto), reader["CondicionProducto"].ToString()),
                                Dimensiones = dimensiones,
                                ProblemaEntrada = reader["ProblemaEntrada"].ToString(),
                                CostoProducto = Convert.ToDecimal(reader["CostoProducto"]),
                                CostoManoObra = Convert.ToDecimal(reader["CostoPerdidaManoObra"]),
                                CostoPerdidaMateriaPrima = Convert.ToDecimal(reader["CostoPerdidaMateriaPrima"]),
                                Cliente = new Cliente { IdCliente = Convert.ToInt32(reader["Cliente"]) },
                                FechaRecibidaProducto = reader["FechaRecibida"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["FechaRecibida"]),
                                FechaEstimadaDevolucion = reader["FechaEstimadaDevolucion"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["FechaEstimadaDevolucion"]),
                                FechaDevolucionReal = reader["FechaDevolucionReal"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaDevolucionReal"])
                            };
                            productos.Add(p);
                        }
                    }
                }
            }

            return productos;
        }

        public bool Update(Producto objeto)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = @"UPDATE Producto
                         SET CostoProducto = @CostoProducto,
                             CondicionProducto = @CondicionProducto,
                             NombreProducto = @NombreProducto,
                             ProblemaEntrada = @ProblemaEntrada,
                             Cliente = @Cliente,
                             FechaRecibida = @FechaRecibida,
                             FechaEstimadaDevolucion = @FechaEstimadaDevolucion,
                             Dimensiones = @Dimensiones,
                             CostoPerdidaManoObra = @CostoPerdidaManoObra,
                             CostoPerdidaMateriaPrima = @CostoPerdidaMateriaPrima,
                             FechaDevolucionReal = @FechaDevolucionReal
                         WHERE CodigoProducto = @CodigoProducto";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Parámetros
                    cmd.Parameters.AddWithValue("@CodigoProducto", objeto.CodigoProducto);
                    cmd.Parameters.AddWithValue("@CostoProducto", objeto.CostoProducto);
                    cmd.Parameters.AddWithValue("@CondicionProducto", objeto.CondicionProducto);
                    cmd.Parameters.AddWithValue("@NombreProducto", objeto.NombreProducto);
                    cmd.Parameters.AddWithValue("@ProblemaEntrada", objeto.ProblemaEntrada);
                    cmd.Parameters.AddWithValue("@Cliente", objeto.Cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@Dimensiones", objeto.Dimensiones.ToString());
                    cmd.Parameters.AddWithValue("@CostoPerdidaManoObra", objeto.CostoManoObra);
                    cmd.Parameters.AddWithValue("@CostoPerdidaMateriaPrima", objeto.CostoPerdidaMateriaPrima);

                    

                    cmd.Parameters.AddWithValue("@FechaRecibida",
                        objeto.FechaRecibidaProducto == DateTime.MinValue ? (object)DBNull.Value : objeto.FechaRecibidaProducto);

                    cmd.Parameters.AddWithValue("@FechaEstimadaDevolucion",
                        objeto.FechaEstimadaDevolucion == DateTime.MinValue ? (object)DBNull.Value : objeto.FechaEstimadaDevolucion);

                    cmd.Parameters.AddWithValue("@FechaDevolucionReal",
                        (object)objeto.FechaDevolucionReal ?? DBNull.Value);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public DataTable ObtenerProductosPorCliente(int idCliente)
        {
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = "SELECT * FROM Producto WHERE IdCliente = @IdCliente";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
