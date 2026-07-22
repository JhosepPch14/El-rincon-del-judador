using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logPlatillo : IlogPlatillo
    {
        private static readonly logPlatillo _instancia = new logPlatillo();
        public static logPlatillo Instancia { get { return _instancia; } }

        public List<entPlatillo> ListarPlatillo()
        {
            return datPlatillo.Instancia.ListarPlatillo();
        }

        public Result<int> InsertarPlatillo(entPlatillo pl)
        {
            if (string.IsNullOrWhiteSpace(pl.NombrePlatillo))
                return Result<int>.Fail("El nombre del platillo es obligatorio.");

            if (pl.PrecioPlatillo <= 0)
                return Result<int>.Fail("El precio debe ser mayor a cero.");

            if (pl.IdTipoPlatillo <= 0)
                return Result<int>.Fail("Debe seleccionar un tipo de platillo.");

            try
            {
                int newId = datPlatillo.Instancia.InsertarPlatillo(pl);
                return Result<int>.Ok(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Error al registrar platillo: " + ex.Message);
            }
        }

        public Result<bool> EditarPlatillo(entPlatillo pl)
        {
            if (pl.IdPlatillo <= 0)
                return Result<bool>.Fail("ID de platillo inválido.");

            if (string.IsNullOrWhiteSpace(pl.NombrePlatillo))
                return Result<bool>.Fail("El nombre del platillo es obligatorio.");

            try
            {
                bool result = datPlatillo.Instancia.EditarPlatillo(pl);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo modificar el platillo.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al modificar platillo: " + ex.Message);
            }
        }

        public Result<bool> DeshabilitarPlatillo(int platilloID)
        {
            if (platilloID <= 0)
                return Result<bool>.Fail("ID de platillo inválido.");

            try
            {
                bool result = datPlatillo.Instancia.DeshabilitarPlatillo(platilloID);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo deshabilitar el platillo.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al deshabilitar platillo: " + ex.Message);
            }
        }
    }
}
