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
    public class ProductoMPP : IABM<Producto> 
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

        //public List<Producto> MapearTodos(DataTable dt)
        //{
        //    List<Producto> productos = new List<Producto>();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        Producto producto = new Producto
        //        {
        //            CodigoProducto = Convert.ToInt32(row["CodigoProducto"]),
        //            CostoProducto = Convert.ToDecimal(row["CostoProducto"]),
        //            CondicionProducto = (CondicionProducto)Enum.Parse(typeof(CondicionProducto), row["CondicionProducto"].ToString()),
        //            NombreProducto = row["NombreProducto"].ToString(),
        //            ProblemaEntrada = row["ProblemaEntrada"].ToString(),
        //            Cliente = new Cliente { IdCliente = Convert.ToInt32(row["Cliente"]) },
        //            CostoManoObra = Convert.ToDecimal(row["CostoPerdidaManoObra"]),
        //            CostoPerdidaMateriaPrima = Convert.ToDecimal(row["CostoPerdidaMateriaPrima"]),
        //            FechaRecibidaProducto = row["FechaRecibida"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row["FechaRecibida"]),
        //            FechaEstimadaDevolucion = row["FechaEstimadaDevolucion"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row["FechaEstimadaDevolucion"]),
        //            FechaDevolucionReal = row["FechaDevolucionReal"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["FechaDevolucionReal"])
        //        };

        //        if (row["Dimensiones"] != DBNull.Value)
        //        {
        //            string dimensionesString = row["Dimensiones"].ToString();
        //            string[] partes = dimensionesString.Split('x');

        //            if (partes.Length == 3)
        //            {
        //                decimal ancho = decimal.Parse(partes[0]);
        //                decimal largo = decimal.Parse(partes[1]);
        //                decimal alto = decimal.Parse(partes[2]);

        //                producto.Dimensiones = new Dimensiones(ancho, largo, alto);
        //            }
        //        }

        //        productos.Add(producto);
        //    }

        //    return productos;
        //}

        public bool ExisteProducto(int codProducto)
        {
            return dalProducto.ExisteProducto(codProducto);
        }

        public List<Producto> ObtenerTodos()
        {
            return dalProducto.ObtenerTodos();
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
