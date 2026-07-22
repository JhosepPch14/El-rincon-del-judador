using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class OrdenPedido : Form
    {
        private readonly List<entDetallePedido> listaDetalles = new List<entDetallePedido>();
        private int _pedidoID = 0;
        private int _detalleSeleccionado = -1;

        public OrdenPedido()
        {
            InitializeComponent();
            listarOrdenPedido();
            llenarDatosCB();
        }

        public void listarOrdenPedido()
        {
            dgvOrden.DataSource = logOrdenPedido.Instancia.ListarOrdenes();
        }

        public void listarDetallePedido(int pedidoID)
        {
            dgvDetalles.DataSource = logDetallePedido.Instancia.ListarDetalles(pedidoID);
        }

        public void limpiarVariables()
        {
            txtNroMesa.Text = "";
        }

        public void llenarDatosCB()
        {
            cbTPlatillo.DataSource = logTPlatillo.Instancia.ListarTPlatillo();
            cbTPlatillo.DisplayMember = "NombreTipo";
            cbTPlatillo.ValueMember = "IdTipoPlatillo";

            cbPlatilloPedido.DataSource = logPlatillo.Instancia.ListarPlatillo();
            cbPlatilloPedido.DisplayMember = "NombrePlatillo";
            cbPlatilloPedido.ValueMember = "IdPlatillo";

            cbMeseros.DataSource = logMesero.Instancia.ListarMesero();
            cbMeseros.DisplayMember = "NombreMesero";
            cbMeseros.ValueMember = "IdMesero";
        }

        private decimal obtenerPrecioPlatillo()
        {
            if (cbPlatilloPedido.SelectedItem is entPlatillo platillo)
                return platillo.PrecioPlatillo;
            return 0;
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNroMesa.Text.Trim(), out int nroMesa))
            {
                MessageBox.Show("Nro de Mesa debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entOrdenPedido op = new entOrdenPedido
            {
                Fecha = dtpFechaOrden.Value,
                NroMesa = nroMesa,
                Total = 0,
                EstadoPedido = chbEstadoOrden.Checked,
                MeseroID = Convert.ToInt32(cbMeseros.SelectedValue)
            };

            var result = logOrdenPedido.Instancia.agregarOrden(op);
            if (result.Success)
            {
                _pedidoID = result.Data;
                MessageBox.Show("Orden registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            listarOrdenPedido();
        }

        private void btnGuardarDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                int platilloID = Convert.ToInt32(cbPlatilloPedido.SelectedValue);
                string nombre = cbPlatilloPedido.Text;
                int cantidad = (int)nudCantidadPlatillo.Value;
                decimal precio = obtenerPrecioPlatillo();
                decimal subtotal = cantidad * precio;

                listaDetalles.Add(new entDetallePedido
                {
                    PlatilloID = platilloID,
                    NombrePlatillo = nombre,
                    Cantidad = cantidad,
                    Precio = precio,
                    Subtotal = subtotal
                });

                dgvDetalles.DataSource = null;
                dgvDetalles.DataSource = listaDetalles;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al agregar detalle: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (_pedidoID == 0)
            {
                MessageBox.Show("Primero registre la orden antes de guardar los detalles.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (logDetallePedido.Instancia.registrarDetallePedido(listaDetalles, _pedidoID))
            {
                MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                decimal total = logDetallePedido.Instancia.CalcularTotalPorPedido(_pedidoID);
                logOrdenPedido.Instancia.actualizarTotal(_pedidoID, total);

                listarDetallePedido(_pedidoID);
                listarOrdenPedido();
                listaDetalles.Clear();
            }
            else
            {
                MessageBox.Show("No se pudieron registrar los detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            if (_detalleSeleccionado < 0 || _detalleSeleccionado >= listaDetalles.Count)
            {
                MessageBox.Show("Seleccione un detalle de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var detalle = listaDetalles[_detalleSeleccionado];
                detalle.PlatilloID = Convert.ToInt32(cbPlatilloPedido.SelectedValue);
                detalle.NombrePlatillo = cbPlatilloPedido.Text;
                detalle.Cantidad = Convert.ToInt32(nudCantidadPlatillo.Value);
                detalle.Precio = obtenerPrecioPlatillo();
                detalle.Subtotal = detalle.Cantidad * detalle.Precio;

                dgvDetalles.DataSource = null;
                dgvDetalles.DataSource = listaDetalles;
                _detalleSeleccionado = -1;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al modificar detalle: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvOrden.Rows[e.RowIndex];
            _pedidoID = Convert.ToInt32(filaActual.Cells[0].Value);
            dtpFechaOrden.Value = Convert.ToDateTime(filaActual.Cells[1].Value);
            txtNroMesa.Text = filaActual.Cells[2].Value.ToString();
            chbEstadoOrden.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
            cbMeseros.Text = filaActual.Cells[5].Value.ToString();

            dgvDetalles.DataSource = logDetallePedido.Instancia.ListarDetalles(_pedidoID);
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvDetalles.Rows[e.RowIndex];
            cbPlatilloPedido.Text = fila.Cells["NombrePlatillo"].Value.ToString();
            nudCantidadPlatillo.Value = Convert.ToInt32(fila.Cells["Cantidad"].Value);
            _detalleSeleccionado = e.RowIndex;
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            if (_detalleSeleccionado >= 0 && _detalleSeleccionado < listaDetalles.Count)
            {
                var confirmar = MessageBox.Show("¿Desea eliminar este platillo del pedido?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    listaDetalles.RemoveAt(_detalleSeleccionado);
                    dgvDetalles.DataSource = null;
                    dgvDetalles.DataSource = listaDetalles;
                    _detalleSeleccionado = -1;
                    dgvDetalles.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un platillo del pedido antes de eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbTPlatillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTPlatillo.SelectedValue is int tipoID)
            {
                var platillos = logPlatillo.Instancia.ListarPlatillo()
                    .Where(p => p.IdTipoPlatillo == tipoID).ToList();

                cbPlatilloPedido.DataSource = platillos;
                cbPlatilloPedido.DisplayMember = "NombrePlatillo";
                cbPlatilloPedido.ValueMember = "IdPlatillo";
            }
        }

        private void btnDeshOrden_Click(object sender, EventArgs e)
        {
            if (_pedidoID == 0)
            {
                MessageBox.Show("Seleccione una orden de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logOrdenPedido.Instancia.inhabilitarOrden(_pedidoID);
            if (result.Success)
                MessageBox.Show("Orden anulada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            listarOrdenPedido();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
