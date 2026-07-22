using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logCliente : IlogCliente
    {
        private static readonly logCliente _instancia = new logCliente();
        public static logCliente Instancia { get { return _instancia; } }

        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }

        public Result<int> agregarCliente(entCliente Cli)
        {
            if (string.IsNullOrWhiteSpace(Cli.Nombre_Cliente))
                return Result<int>.Fail("El nombre del cliente es obligatorio.");

            if (string.IsNullOrWhiteSpace(Cli.DNI) || !Regex.IsMatch(Cli.DNI, @"^\d{8}$"))
                return Result<int>.Fail("El DNI debe tener 8 dígitos numéricos.");

            if (string.IsNullOrWhiteSpace(Cli.Correo) || !Regex.IsMatch(Cli.Correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return Result<int>.Fail("El correo electrónico no tiene un formato válido.");

            try
            {
                int newId = datCliente.Instancia.agregarCliente(Cli);
                return Result<int>.Ok(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Error al registrar cliente: " + ex.Message);
            }
        }

        public Result<bool> modificarCliente(entCliente Cli)
        {
            if (Cli.ClienteID <= 0)
                return Result<bool>.Fail("ID de cliente inválido.");

            if (string.IsNullOrWhiteSpace(Cli.Nombre_Cliente))
                return Result<bool>.Fail("El nombre del cliente es obligatorio.");

            try
            {
                bool result = datCliente.Instancia.modificarCliente(Cli);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo modificar el cliente.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al modificar cliente: " + ex.Message);
            }
        }

        public Result<bool> inhabilitarCliente(int clienteID)
        {
            if (clienteID <= 0)
                return Result<bool>.Fail("ID de cliente inválido.");

            try
            {
                bool result = datCliente.Instancia.inhabilitarCliente(clienteID);
                return result
                    ? Result<bool>.Ok(true)
                    : Result<bool>.Fail("No se pudo inhabilitar el cliente.");
            }
            catch (Exception ex)
            {
                return Result<bool>.Fail("Error al inhabilitar cliente: " + ex.Message);
            }
        }
    }
}
