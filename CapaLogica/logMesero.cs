using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logMesero : IlogMesero
    {
        private static readonly logMesero _instancia = new logMesero();
        public static logMesero Instancia { get { return _instancia; } }

        public List<entMesero> ListarMesero()
        {
            return datMesero.Instancia.ListarMesero();
        }

        public Result<int> agregarMesero(entMesero m)
        {
            if (string.IsNullOrWhiteSpace(m.NombreMesero))
                return Result<int>.Fail("El nombre del mesero es obligatorio.");

            if (string.IsNullOrWhiteSpace(m.DNIMesero) || !Regex.IsMatch(m.DNIMesero, @"^\d{8}$"))
                return Result<int>.Fail("El DNI debe tener 8 dígitos numéricos.");

            try
            {
                int newId = datMesero.Instancia.agregarMesero(m);
                return Result<int>.Ok(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Error al registrar mesero: " + ex.Message);
            }
        }

        public Result<bool> modificarMesero(entMesero m)
        {
            if (m.IdMesero <= 0)
                return Result<bool>.Fail("ID de mesero inválido.");

            if (string.IsNullOrWhiteSpace(m.NombreMesero))
                return Result<bool>.Fail("El nombre del mesero es obligatorio.");

            try
            {
                bool result = datMesero.Instancia.modificarMesero(m);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo modificar el mesero.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al modificar mesero: " + ex.Message);
            }
        }

        public Result<bool> inhabilitarMesero(int meseroID)
        {
            if (meseroID <= 0)
                return Result<bool>.Fail("ID de mesero inválido.");

            try
            {
                bool result = datMesero.Instancia.inhabilitarMesero(meseroID);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo inhabilitar el mesero.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al inhabilitar mesero: " + ex.Message);
            }
        }
    }
}
