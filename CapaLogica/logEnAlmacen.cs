using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logEnAlmacen : IlogEnAlmacen
    {
        private static readonly logEnAlmacen _instancia = new logEnAlmacen();
        public static logEnAlmacen Instancia { get { return _instancia; } }

        public List<entEnAlmacen> ListarEnAlmacen()
        {
            return datEnAlmacen.Instancia.ListarEnAlmacen();
        }

        public Result<int> agregarEnAlmacen(entEnAlmacen ea)
        {
            if (string.IsNullOrWhiteSpace(ea.Nombre))
                return Result<int>.Fail("El nombre del encargado es obligatorio.");

            if (string.IsNullOrWhiteSpace(ea.DNI) || !Regex.IsMatch(ea.DNI, @"^\d{8}$"))
                return Result<int>.Fail("El DNI debe tener 8 dígitos numéricos.");

            try
            {
                int newId = datEnAlmacen.Instancia.agregarEnAlmacen(ea);
                return Result<int>.Ok(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Error al registrar encargado: " + ex.Message);
            }
        }

        public Result<bool> modificarEnAlmacen(entEnAlmacen ea)
        {
            if (ea.IDEnAlmacen <= 0)
                return Result<bool>.Fail("ID de encargado inválido.");

            if (string.IsNullOrWhiteSpace(ea.Nombre))
                return Result<bool>.Fail("El nombre del encargado es obligatorio.");

            try
            {
                bool result = datEnAlmacen.Instancia.modificarEnAlmacen(ea);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo modificar el encargado.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al modificar encargado: " + ex.Message);
            }
        }

        public Result<bool> inhabilitarEnAlmacen(int idAlmacen)
        {
            if (idAlmacen <= 0)
                return Result<bool>.Fail("ID de encargado inválido.");

            try
            {
                bool result = datEnAlmacen.Instancia.inhabilitarEnAlmacen(idAlmacen);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo inhabilitar el encargado.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al inhabilitar encargado: " + ex.Message);
            }
        }
    }
}
