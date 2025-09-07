using BE;
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
    public class ProductoDAL : IDAL<Producto>
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

        public DataTable ObtenerTodos()
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = "SELECT * FROM Producto";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Update(Producto objeto)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string query = @"UPDATE Producto 
                            SET NombreCompleto = @NombreCompleto
                            WHERE CodigoProducto = @CodigoProducto";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
