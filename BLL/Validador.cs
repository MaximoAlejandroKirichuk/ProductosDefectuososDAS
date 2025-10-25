using System;
using System.Text.RegularExpressions;

namespace BLL
{
    public static class Validador
    {
        public static bool EsCuitValido(string cuit)
        {
            // 1. Quitar guiones y espacios (si los hubiera)
            cuit = cuit.Replace("-", "").Replace(" ", "");

            // 2. Validación de formato y prefijos con Regex
            string patron = @"^(20|23|24|27|30|33|34)[0-9]{9}$";
            if (!Regex.IsMatch(cuit, patron))
            {
                return false;
            }

            // 3. Validación del dígito verificador (Algoritmo Módulo 11)
            try
            {
                // Coeficientes del algoritmo
                int[] coeficientes = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
                int suma = 0;

                // Calcular la suma ponderada de los primeros 10 dígitos
                for (int i = 0; i < 10; i++)
                {
                    suma += int.Parse(cuit[i].ToString()) * coeficientes[i];
                }

                // Obtener el resto de la división por 11
                int resto = suma % 11;

                // Calcular el dígito verificador esperado
                int digitoEsperado = 11 - resto;
                if (digitoEsperado == 11)
                {
                    digitoEsperado = 0;
                }
                else if (digitoEsperado == 10)
                {
                    // Un CUIT/CUIL con dígito verificador 10 es inválido
                    // (Nota: existen casos históricos raros, pero para nuevos registros se considera inválido)
                    return false;
                }

                // Obtener el dígito verificador real (el último dígito del CUIT)
                int digitoReal = int.Parse(cuit[10].ToString());

                // Comparar
                return digitoEsperado == digitoReal;
            }
            catch
            {
                // Si falla cualquier conversión, es inválido
                return false;
            }
        }
    }
}