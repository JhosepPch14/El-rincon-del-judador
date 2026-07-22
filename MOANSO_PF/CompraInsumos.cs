using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class CompraInsumos : Form
    {
        private int _compraID = 0;

        public CompraInsumos()
        {
            InitializeComponent();
            listarCompraReq();
            llenarDatosCB();
        }

        public void listarCompraReq()
        {
            dgvCompraReq.DataSource = logCompraReq.Instancia.ListarCompraReq();
        }

        public void limpiarVariables()
        {
            txtEncargado.Text = "";
            txtMetodoPago.Text = "";
            txtMontoTotal.Text = "";
            chbEstadoCompra.Checked = true;
            _compraID = 0;
        }

        public void llenarDatosCB()
        {
            cbIDReq.DataSource = logReqInsumos.Instancia.ListarReqInsumos();
            cbIDReq.DisplayMember = "IDRequerimiento";
            cbIDReq.ValueMember = "IDRequerimiento";

            cbIDProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
            cbIDProveedor.DisplayMember = "NombreProveedor";
            cbIDProveedor.ValueMember = "IdProveedor";
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtMontoTotal.Text.Trim(), out decimal monto))
            {
                MessageBox.Show("Monto Total debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entCompraReq cr = new entCompraReq
            {
                IDRequerimiento = Convert.ToInt32(cbIDReq.SelectedValue),
                IDProveedor = Convert.ToInt32(cbIDProveedor.SelectedValue),
                Encargado = txtEncargado.Text.Trim(),
                FechaCompra = dtpFechaCompra.Value,
                MetodoPago = txtMetodoPago.Text.Trim(),
                MontoTotal = monto,
                EstadoCompra = chbEstadoCompra.Checked
            };

            var result = logCompraReq.Instancia.registrarCompraReq(cr);
            if (result.Success)
                MessageBox.Show("Compra registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            listarCompraReq();
        }

        private void btnAnularReq_Click(object sender, EventArgs e)
        {
            if (_compraID == 0)
            {
                MessageBox.Show("Seleccione una compra de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logCompraReq.Instancia.anularCompraReq(_compraID);
            if (result.Success)
                MessageBox.Show("Compra anulada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            listarCompraReq();
        }

        private void dgvCompraReq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvCompraReq.Rows[e.RowIndex];
            _compraID = Convert.ToInt32(filaActual.Cells["ComprainsumosID"].Value);
            txtEncargado.Text = filaActual.Cells["Encargado"].Value.ToString();
            txtMetodoPago.Text = filaActual.Cells["MetodoPago"].Value.ToString();
            txtMontoTotal.Text = filaActual.Cells["MontoTotal"].Value.ToString();
            chbEstadoCompra.Checked = Convert.ToBoolean(filaActual.Cells["EstadoCompra"].Value);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosCompra.Enabled = false;
        }
    }
}
