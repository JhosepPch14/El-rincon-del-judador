using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logBebida : IlogBebida
    {
        private static readonly logBebida _instancia = new logBebida();
        public static logBebida Instancia { get { return _instancia; } }

        public List<entBebida> ListarBebida()
        {
            return datBebida.Instancia.ListarBebida();
        }

        public Result<int> agregarBebida(entBebida b)
        {
            if (string.IsNullOrWhiteSpace(b.NombreBebida))
                return Result<int>.Fail("El nombre de la bebida es obligatorio.");

            if (b.Precio <= 0)
                return Result<int>.Fail("El precio debe ser mayor a cero.");

            if (b.TipoBebida <= 0)
                return Result<int>.Fail("Debe seleccionar un tipo de bebida.");

            try
            {
                int newId = datBebida.Instancia.agregarBebida(b);
                return Result<int>.Ok(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Error al registrar bebida: " + ex.Message);
            }
        }

        public Result<bool> modificarBebida(entBebida b)
        {
            if (b.IdBebida <= 0)
                return Result<bool>.Fail("ID de bebida inválido.");

            if (string.IsNullOrWhiteSpace(b.NombreBebida))
                return Result<bool>.Fail("El nombre de la bebida es obligatorio.");

            try
            {
                bool result = datBebida.Instancia.modificarBebida(b);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo modificar la bebida.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al modificar bebida: " + ex.Message);
            }
        }

        public Result<bool> inhabilitarBebida(int bebidaID)
        {
            if (bebidaID <= 0)
                return Result<bool>.Fail("ID de bebida inválido.");

            try
            {
                bool result = datBebida.Instancia.inhabilitarBebida(bebidaID);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo inhabilitar la bebida.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al inhabilitar bebida: " + ex.Message);
            }
        }
    }
}
