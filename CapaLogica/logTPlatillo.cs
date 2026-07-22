using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logTPlatillo : IlogTPlatillo
    {
        private static readonly logTPlatillo _instancia = new logTPlatillo();
        public static logTPlatillo Instancia { get { return _instancia; } }

        public List<entTPlatillo> ListarTPlatillo()
        {
            return datTPlatillo.Instancia.ListarTPlatillo();
        }

        public Result<int> agregarTPlatillo(entTPlatillo tp)
        {
            if (string.IsNullOrWhiteSpace(tp.NombreTipo))
                return Result<int>.Fail("El nombre del tipo de platillo es obligatorio.");

            try
            {
                int newId = datTPlatillo.Instancia.agregarTPlatillo(tp);
                return Result<int>.Ok(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Error al registrar tipo de platillo: " + ex.Message);
            }
        }

        public Result<bool> modificarTPlatillo(entTPlatillo tp)
        {
            if (tp.IdTipoPlatillo <= 0)
                return Result<bool>.Fail("ID de tipo de platillo inválido.");

            if (string.IsNullOrWhiteSpace(tp.NombreTipo))
                return Result<bool>.Fail("El nombre del tipo de platillo es obligatorio.");

            try
            {
                bool result = datTPlatillo.Instancia.modificarTPlatillo(tp);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo modificar el tipo de platillo.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al modificar tipo de platillo: " + ex.Message);
            }
        }

        public Result<bool> inhabilitarTPlatillo(int idTipo)
        {
            if (idTipo <= 0)
                return Result<bool>.Fail("ID de tipo de platillo inválido.");

            try
            {
                bool result = datTPlatillo.Instancia.inhabilitarTPlatillo(idTipo);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo inhabilitar el tipo de platillo.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al inhabilitar tipo de platillo: " + ex.Message);
            }
        }
    }
}
