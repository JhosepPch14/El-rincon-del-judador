using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logTipoBebida : IlogTipoBebida
    {
        private static readonly logTipoBebida _instancia = new logTipoBebida();
        public static logTipoBebida Instancia => _instancia;

        public List<entTipoBebida> ListarTBebida()
        {
            return datTipoBebida.Instancia.ListarTBebida();
        }

        public Result<int> InsertarTBebida(entTipoBebida tb)
        {
            if (string.IsNullOrWhiteSpace(tb.NombreTipo))
                return Result<int>.Fail("El nombre del tipo de bebida es obligatorio.");

            try
            {
                int newId = datTipoBebida.Instancia.InsertarTBebida(tb);
                return Result<int>.Ok(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Error al registrar tipo de bebida: " + ex.Message);
            }
        }

        public Result<bool> ModificarTBebida(entTipoBebida tb)
        {
            if (tb.IdTipoBebida <= 0)
                return Result<bool>.Fail("ID de tipo de bebida inválido.");

            if (string.IsNullOrWhiteSpace(tb.NombreTipo))
                return Result<bool>.Fail("El nombre del tipo de bebida es obligatorio.");

            try
            {
                bool result = datTipoBebida.Instancia.ModificarTBebida(tb);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo modificar el tipo de bebida.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al modificar tipo de bebida: " + ex.Message);
            }
        }

        public Result<bool> InhabilitarTBebida(int idTipo)
        {
            if (idTipo <= 0)
                return Result<bool>.Fail("ID de tipo de bebida inválido.");

            try
            {
                bool result = datTipoBebida.Instancia.InhabilitarTBebida(idTipo);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo inhabilitar el tipo de bebida.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al inhabilitar tipo de bebida: " + ex.Message);
            }
        }
    }
}
