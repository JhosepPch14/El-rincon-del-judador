using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logInsumos : IlogInsumos
    {
        private static readonly logInsumos _instancia = new logInsumos();
        public static logInsumos Instancia { get { return _instancia; } }

        public List<entInsumos> ListarInsumos()
        {
            return datInsumos.Instancia.ListarInsumos();
        }

        public Result<int> InsertarInsumo(entInsumos ins)
        {
            if (string.IsNullOrWhiteSpace(ins.NombreInsumo))
                return Result<int>.Fail("El nombre del insumo es obligatorio.");

            if (ins.Cantidad < 0)
                return Result<int>.Fail("La cantidad no puede ser negativa.");

            try
            {
                int newId = datInsumos.Instancia.InsertarInsumo(ins);
                return Result<int>.Ok(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Error al registrar insumo: " + ex.Message);
            }
        }

        public Result<bool> ModificarInsumo(entInsumos ins)
        {
            if (ins.IdInsumo <= 0)
                return Result<bool>.Fail("ID de insumo inválido.");

            if (string.IsNullOrWhiteSpace(ins.NombreInsumo))
                return Result<bool>.Fail("El nombre del insumo es obligatorio.");

            try
            {
                bool result = datInsumos.Instancia.ModificarInsumo(ins);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo modificar el insumo.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al modificar insumo: " + ex.Message);
            }
        }

        public Result<bool> InhabilitarInsumo(int insumoID)
        {
            if (insumoID <= 0)
                return Result<bool>.Fail("ID de insumo inválido.");

            try
            {
                bool result = datInsumos.Instancia.InhabilitarInsumo(insumoID);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo inhabilitar el insumo.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al inhabilitar insumo: " + ex.Message);
            }
        }
    }
}
