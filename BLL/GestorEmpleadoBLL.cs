using BE; 
using MPP; 
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Servicios;
using BLL.BLL;

namespace BLL
{
    public class GestorEmpleadoBLL : IABM<Empleado>
    {
        private EmpleadosMPP mppEmpleado = new EmpleadosMPP();
        private readonly LogsBLL logger = new LogsBLL(); // Instancia del logger

            // Propiedad auxiliar para obtener el ID del usuario actual de forma segura
            private int? IdUsuarioActual => SessionManager.Instancia.UsuarioActivo?.IdUsuario;

            public bool Agregar(Empleado objeto)
            {
                // 1. Validaciones de Negocio
                if (!Validador.ValidarGmail(objeto.Email))
                {
                    logger.RegistrarEvento(
                        IdUsuarioActual,
                        NivelLog.Alerta,
                        ModuloSistema.Empleados, 
                        $"Intento fallido de alta de empleado. Email inválido: {objeto.Email}",
                        Criticidad.Baja
                    );
                    throw new Exception("Ingrese correctamente el email");
                }

                try
                {
                    // 2. Ejecución
                    bool resultado = mppEmpleado.Agregar(objeto);

                    if (resultado)
                    {
                        // 3. Log de Éxito
                        logger.RegistrarEvento(
                            IdUsuarioActual,
                            NivelLog.Informacion,
                            ModuloSistema.Empleados,
                            $"Alta de empleado exitosa. Empleado: {objeto.NombreCompleto}, {objeto.Email}",
                            Criticidad.Baja
                        );
                    }
                    return resultado;
                }
                catch (Exception ex)
                {
                    // 4. Log de Error Crítico
                    logger.RegistrarEvento(
                        IdUsuarioActual,
                        NivelLog.Error,
                        ModuloSistema.Empleados,
                        $"Error al crear empleado: {ex.Message}",
                        Criticidad.Alta
                    );
                    throw; // Re-lanzamos la excepción para que la UI la muestre
                }
            }

            public bool Borrar(int id)
            {
                try
                {
                    bool resultado = mppEmpleado.Borrar(id);

                    if (resultado)
                    {
                        logger.RegistrarEvento(
                            IdUsuarioActual,
                            NivelLog.Informacion,
                            ModuloSistema.Empleados,
                            $"Baja de empleado exitosa. ID eliminado: {id}",
                            Criticidad.Alta // Borrar es una acción crítica que crear
                        );
                    }
                    else
                    {
                        // Si el MPP devuelve false (ej. no existía el ID)
                        logger.RegistrarEvento(
                            IdUsuarioActual,
                            NivelLog.Alerta,
                            ModuloSistema.Empleados,
                            $"Intento de borrar empleado inexistente. ID: {id}",
                            Criticidad.Baja
                        );
                    }

                    return resultado;
                }
                catch (Exception ex)
                {
                    logger.RegistrarEvento(
                        IdUsuarioActual,
                        NivelLog.Error,
                        ModuloSistema.Empleados,
                        $"Error al borrar empleado ID {id}: {ex.Message}",
                        Criticidad.Alta
                    );
                    throw;
                }
            }

            public bool Modificar(Empleado objeto)
            {
                // 1. Validaciones
                // Usando tu lógica de Regex existente
                if (string.IsNullOrWhiteSpace(objeto.Email) || !Regex.IsMatch(objeto.Email.Trim(), @"^[\w-\.]+@gmail\.com$"))
                {
                    logger.RegistrarEvento(
                        IdUsuarioActual,
                        NivelLog.Alerta,
                        ModuloSistema.Empleados,
                        $"Intento fallido de modificación. Email inválido: {objeto.Email}",
                        Criticidad.Baja
                    );
                    throw new Exception("El email del empleado debe ser una cuenta de @gmail.com válida.");
                }

                try
                {
                    // 2. Ejecución
                    bool resultado = mppEmpleado.Modificar(objeto);

                    if (resultado)
                    {
                        // 3. Log de Éxito
                        logger.RegistrarEvento(
                            IdUsuarioActual,
                            NivelLog.Informacion,
                            ModuloSistema.Empleados,
                            $"Modificación de empleado exitosa. ID: {objeto.IdUsuario}", // Asumiendo que Empleado tiene Id
                            Criticidad.Baja
                        );
                    }

                    return resultado;
                }
                catch (Exception ex)
                {
                    // 4. Log de Error
                    logger.RegistrarEvento(
                        IdUsuarioActual,
                        NivelLog.Error,
                        ModuloSistema.Empleados,
                        $"Error al modificar empleado ID {objeto.IdUsuario}: {ex.Message}",
                        Criticidad.Alta
                    );
                    throw;
                }
            }

            public List<Empleado> ObtenerTodos()
            {
                try
                {
                  
                    return mppEmpleado.ObtenerTodos();
                }
                catch (Exception ex)
                {
                    logger.RegistrarEvento(
                        IdUsuarioActual,
                        NivelLog.Error,
                        ModuloSistema.Empleados,
                        $"Error al obtener lista de empleados: {ex.Message}",
                        Criticidad.Alta
                    );
                    throw;
                }
            }
        }
    }