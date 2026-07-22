using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logProveedor : IlogProveedor
    {
        private static readonly logProveedor _instancia = new logProveedor();
        public static logProveedor Instancia { get { return _instancia; } }

        public List<entProveedor> ListarProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();
        }

        public Result<int> InsertarProveedor(entProveedor pr)
        {
            if (string.IsNullOrWhiteSpace(pr.NombreProveedor))
                return Result<int>.Fail("El nombre del proveedor es obligatorio.");

            if (string.IsNullOrWhiteSpace(pr.RUC) || !Regex.IsMatch(pr.RUC, @"^\d{11}$"))
                return Result<int>.Fail("El RUC debe tener 11 dígitos numéricos.");

            if (!string.IsNullOrWhiteSpace(pr.EmailProveedor) &&
                !Regex.IsMatch(pr.EmailProveedor, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return Result<int>.Fail("El correo electrónico no tiene un formato válido.");

            try
            {
                int newId = datProveedor.Instancia.InsertarProveedor(pr);
                return Result<int>.Ok(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Error al registrar proveedor: " + ex.Message);
            }
        }

        public Result<bool> EditarProveedor(entProveedor pr)
        {
            if (pr.IdProveedor <= 0)
                return Result<bool>.Fail("ID de proveedor inválido.");

            if (string.IsNullOrWhiteSpace(pr.NombreProveedor))
                return Result<bool>.Fail("El nombre del proveedor es obligatorio.");

            try
            {
                bool result = datProveedor.Instancia.EditarProveedor(pr);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo modificar el proveedor.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al modificar proveedor: " + ex.Message);
            }
        }

        public Result<bool> DeshabilitarProveedor(int proveedorID)
        {
            if (proveedorID <= 0)
                return Result<bool>.Fail("ID de proveedor inválido.");

            try
            {
                bool result = datProveedor.Instancia.DeshabilitarProveedor(proveedorID);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo deshabilitar el proveedor.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al deshabilitar proveedor: " + ex.Message);
            }
        }
    }
}
