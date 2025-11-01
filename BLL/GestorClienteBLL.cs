using BE;
using BE.actores;

using MPP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace BLL
{
    public class GestorClienteBLL : IABM<Cliente>
    {
        private ClienteMPP clienteMPP = new ClienteMPP();
        public bool Agregar(Cliente objeto)
        {
            if (objeto == null)
                throw new Exception("Error al intentar agregar: El cliente es nulo.");
            
            if (string.IsNullOrWhiteSpace(objeto.NombreCompleto))
               throw new Exception("El Nombre Completo es obligatorio.");
            
            if (string.IsNullOrWhiteSpace(objeto.Email))
                throw new Exception("El Email es obligatorio.");
            
            // . VALIDACIÓN DE CUIL/CUIT (NroDocumento)

            var respuesta= Validador.EsCuitValido(objeto.NroDocumento);
            if (!respuesta) throw new Exception("cuit invalido");

            // Validación de existencia (usa la variable correcta 'clienteMPP')
            var existe = clienteMPP.ExisteCliente(objeto.NroDocumento.Trim());
            if (existe)
                throw new Exception("El cliente ya existe (mismo Nro. Documento).");
            
         
            // Si todo esta OK, se llama al MPP.
            return clienteMPP.Agregar(objeto);
        }
        

        public bool Borrar(int id)
        {
            return clienteMPP.Borrar(id);
        }

        public bool Modificar(Cliente objeto)
        {
            return clienteMPP.Modificar(objeto);
        }
        public DataTable ObtenerSeguimientoTicket(int codigo)
        {
            throw new NotImplementedException();
        }
        public List<Cliente> ObtenerClientes()
        {
            return clienteMPP.ObtenerTodos();
        }

        public int ObtenerIdClientePorDocumento(string nroDocumento)
        {
            if (string.IsNullOrWhiteSpace(nroDocumento))
                throw new Exception("El Nro documento es obligatorio");

            // . VALIDACIÓN DE CUIL/CUIT (NroDocumento)
            var respuesta = Validador.EsCuitValido(nroDocumento);
            if (!respuesta) throw new Exception("Cuit/Cuil invalido");

            return clienteMPP.ObtenerIdClientePorDocumento(nroDocumento);
        }
    }
    
}
