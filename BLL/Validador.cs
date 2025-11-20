using BE;
using System;
using System.Text.RegularExpressions;

namespace BLL
{
    public static class Validador
    {
        public static bool EsCuitValido(string cuit)
        {
            if (string.IsNullOrWhiteSpace(cuit))
                return false;

            // 1. Quitar guiones y espacios
            cuit = cuit.Replace("-", "").Replace(" ", "");

            // 2. Validar longitud (11 dígitos)
            if (cuit.Length != 11)
                return false;

            // 3. Validación de prefijo y que el resto sean números
            string patron = @"^(20|23|24|27|30|33|34)\d{9}$";
            if (!Regex.IsMatch(cuit, patron))
                return false;

            // 4. Validar dígito verificador (Módulo 11)
            int[] coeficientes = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                if (!int.TryParse(cuit[i].ToString(), out int digito))
                    return false;

                suma += digito * coeficientes[i];
            }

            int resto = suma % 11;
            int digitoEsperado = 11 - resto;

            if (digitoEsperado == 11)
                digitoEsperado = 0;
            else if (digitoEsperado == 10)
                return false; // dígito 10 no válido

            if (!int.TryParse(cuit[10].ToString(), out int digitoReal))
                return false;

            return digitoEsperado == digitoReal;
        }
    


    public static bool ValidarGmail(string gmail)
        {
            //  INICIO DE VALIDACIONES BLL 

            if (gmail == null)
            {
                throw new Exception("Error al intentar agregar: El empleado es nulo.");
            }

            //  VALIDACIÓN DE GMAIL 
            string patronGmail = @"^[\w-\.]+@gmail\.com$";

            if (string.IsNullOrWhiteSpace(gmail) || !Regex.IsMatch(gmail.Trim(), patronGmail))
            {
                // Si NO es un email de @gmail.com válido, lanzamos la excepción
                throw new Exception("El email del empleado debe ser una cuenta de @gmail.com válida.");
            }

            //  Validación de Contraseña
            if (string.IsNullOrWhiteSpace(gmail))
            {
                throw new Exception("La contraseña es obligatoria.");
            }

            // Si todas las validaciones pasan
            return true;
        }
        
        
    }
}