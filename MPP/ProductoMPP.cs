using BE;
using BE.actores;
using DAL;
using MPP.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class ProductoMPP : IABM<Producto> , IMapeableTodos<Producto>
    {
        private ProductoDAL dalProducto = new ProductoDAL();
        public bool Agregar(Producto objeto)
        {
            return dalProducto.Insertar(objeto);
        }

        public bool Borrar(int id)
        {
            return dalProducto.Delete(id);
        }

        public List<Producto> MapearTodos(DataTable dt)
        {
            List<Producto> productos = new List<Producto>();
            foreach (DataRow row in dt.Rows)    
            {
                Producto producto = new Producto();
                {
                    producto.CodigoProducto = Convert.ToInt32(row["CodigoProducto"]);
                    producto.CostoProducto = Convert.ToInt32(row["CostoProducto"]);
                    producto.CondicionProducto = (CondicionProducto)Enum.Parse(typeof(CondicionProducto), row["CondicionProducto"].ToString());
                    producto.NombreProducto = row["NombreProducto"].ToString();
                    producto.ProblemaEntrada = row["ProblemaEntrada"].ToString();
                    int idCliente = Convert.ToInt32(row["Cliente"]);
                    producto.Cliente = new Cliente
                    {
                        IdCliente = idCliente
                    };
                    producto.CostoManoObra = Convert.ToDecimal(row["CostoPerdidaManoObra"]);
                    producto.CostoPerdidaMateriaPrima = Convert.ToDecimal(row["CostoPerdidaMateriaPrima"]);

                    if (row["FechaRecibida"] != DBNull.Value)
                    {
                        producto.FechaRecibidaProducto = Convert.ToDateTime(row["FechaRecibida"]);
                    }
                    else
                    {
                        producto.FechaRecibidaProducto = DateTime.Now; 
                    }

                    if (row["FechaEstimadaDevolucion"] != DBNull.Value)
                    {
                        producto.FechaEstimadaDevolucion = Convert.ToDateTime(row["FechaEstimadaDevolucion"]);
                    }

                    if (row["FechaDevolucionReal"] != DBNull.Value)
                    {
                        producto.FechaDevolucionReal = Convert.ToDateTime(row["FechaDevolucionReal"]);
                    }


                    ////no entendi lo de DIMENSIONES. no lo supe hacer solo
                    //if (row["Dimensiones"] != DBNull.Value)
                    //{
                    //    string dimensionesString = row["Dimensiones"].ToString();
                    //    // Aquí debes implementar la lógica para extraer Ancho, Largo y Alto de ese string.
                    //    // Por ejemplo, puedes usar el método Split() o un Regex.

                    //    // Ejemplo con Split()
                    //    string[] partes = dimensionesString.Split('x');
                    //    decimal ancho = decimal.Parse(partes[0].Replace("Ancho:", ""));
                    //    decimal largo = decimal.Parse(partes[1].Replace("Largo", ""));
                    //    decimal alto = decimal.Parse(partes[2].Replace("Alto", ""));

                    //    // Crea una nueva instancia de Dimensiones con los valores extraídos.
                    //    producto.Dimensiones = new Dimensiones(ancho, largo, alto);
                    //}
                }
                productos.Add(producto);
            }

            return productos;
        }

        public List<Producto> ObtenerTodos()
        {
            DataTable dt = dalProducto.ObtenerTodos();
            return MapearTodos(dt);
        }
        public bool Modificar(Producto objeto)
        {
            return dalProducto.Update(objeto);
        }

        public DataTable ObtenerProductosPorCliente(int idCliente)
        {
            using (SqlConnection con = new SqlConnection(StringConnection.stringConnection))
            {
                string query = "SELECT * FROM Producto WHERE Cliente = @IdCliente";
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
