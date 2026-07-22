using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class ComprobanteVenta : Form
    {
        private int _comprobanteID = 0;

        public ComprobanteVenta()
        {
            InitializeComponent();
            listarComprobantes();
            llenarDatosCB();
        }

        public void listarComprobantes()
        {
            dgvComprobantes.DataSource = logComprobantePago.Instancia.ListarComprobantes();
        }

        public void limpiarVariables()
        {
            txtTComprobante.Text = "";
            txtMontoTotal.Text = "0";
            chbCompVenta.Checked = true;
            _comprobanteID = 0;
        }

        public void llenarDatosCB()
        {
            cbCliente.DataSource = logCliente.Instancia.ListarCliente();
            cbCliente.DisplayMember = "DNI";
            cbCliente.ValueMember = "ClienteID";

            cbIDVenta.DataSource = logOrdenPedido.Instancia.ListarOrdenes();
            cbIDVenta.DisplayMember = "PedidoID";
            cbIDVenta.ValueMember = "PedidoID";
        }

        private void btnRegistrarComprobante_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtMontoTotal.Text.Trim(), out decimal monto))
            {
                MessageBox.Show("Monto debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entComprobantePago cop = new entComprobantePago
            {
                ClienteID = Convert.ToInt32(cbCliente.SelectedValue),
                PedidoID = Convert.ToInt32(cbIDVenta.SelectedValue),
                TipoComprobante = txtTComprobante.Text.Trim(),
                MontoTotal = monto,
                FechaEmision = dtpFechaEmision.Value,
                EstadoComprobante = chbCompVenta.Checked
            };

            var result = logComprobantePago.Instancia.registrarComprobante(cop);
            if (result.Success)
                MessageBox.Show("Comprobante registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            listarComprobantes();
        }

        private void btnAnularComprobante_Click(object sender, EventArgs e)
        {
            if (_comprobanteID == 0)
            {
                MessageBox.Show("Seleccione un comprobante de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logComprobantePago.Instancia.deshabilitarComprobante(_comprobanteID);
            if (result.Success)
                MessageBox.Show("Comprobante anulado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            listarComprobantes();
        }

        private void dgvComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvComprobantes.Rows[e.RowIndex];
            _comprobanteID = Convert.ToInt32(filaActual.Cells["ComprobanteDeVentaID"].Value);
            txtTComprobante.Text = filaActual.Cells["TipoComprobante"].Value.ToString();
            txtMontoTotal.Text = filaActual.Cells["MontoTotal"].Value.ToString();
            dtpFechaEmision.Value = Convert.ToDateTime(filaActual.Cells["FechaEmision"].Value);
            chbCompVenta.Checked = Convert.ToBoolean(filaActual.Cells["EstadoComprobante"].Value);
        }

        private void btnNCliente_Click(object sender, EventArgs e)
        {
            MantenedorCliente formCliente = new MantenedorCliente();
            formCliente.Show();
        }

        private void cbIDVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            entOrdenPedido ordenSeleccionada = cbIDVenta.SelectedItem as entOrdenPedido;
            if (ordenSeleccionada != null)
            {
                txtMontoTotal.Text = ordenSeleccionada.Total.ToString();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
