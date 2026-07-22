using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class MantenedorCliente : Form
    {
        private int _clienteID = 0;

        public MantenedorCliente()
        {
            InitializeComponent();
            gbDatosCliente.Enabled = false;
            listarCliente();
        }

        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        public void limpiarVariables()
        {
            txtNombreCliente.Text = "";
            txtDNICliente.Text = "";
            txtNumeroCliente.Text = "";
            txtCorreoCliente.Text = "";
            dtpFechaCliente.Value = DateTime.Now;
            chbEstadoCliente.Checked = true;
            _clienteID = 0;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            entCliente c = new entCliente
            {
                Nombre_Cliente = txtNombreCliente.Text.Trim(),
                DNI = txtDNICliente.Text.Trim(),
                Numero = txtNumeroCliente.Text.Trim(),
                Correo = txtCorreoCliente.Text.Trim(),
                Fecha = dtpFechaCliente.Value,
                EstadoCliente = chbEstadoCliente.Checked
            };

            var result = logCliente.Instancia.agregarCliente(c);
            if (result.Success)
                MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosCliente.Enabled = false;
            listarCliente();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (_clienteID == 0)
            {
                MessageBox.Show("Seleccione un cliente de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entCliente c = new entCliente
            {
                ClienteID = _clienteID,
                Nombre_Cliente = txtNombreCliente.Text.Trim(),
                DNI = txtDNICliente.Text.Trim(),
                Numero = txtNumeroCliente.Text.Trim(),
                Correo = txtCorreoCliente.Text.Trim(),
                Fecha = dtpFechaCliente.Value,
                EstadoCliente = chbEstadoCliente.Checked
            };

            var result = logCliente.Instancia.modificarCliente(c);
            if (result.Success)
                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosCliente.Enabled = false;
            listarCliente();
        }

        private void btnInhabilitarCliente_Click(object sender, EventArgs e)
        {
            if (_clienteID == 0)
            {
                MessageBox.Show("Seleccione un cliente de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logCliente.Instancia.inhabilitarCliente(_clienteID);
            if (result.Success)
                MessageBox.Show("Cliente inhabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosCliente.Enabled = false;
            listarCliente();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosCliente.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex];
            _clienteID = Convert.ToInt32(filaActual.Cells[0].Value);
            txtNombreCliente.Text = filaActual.Cells[1].Value.ToString();
            txtDNICliente.Text = filaActual.Cells[2].Value.ToString();
            txtNumeroCliente.Text = filaActual.Cells[3].Value.ToString();
            txtCorreoCliente.Text = filaActual.Cells[4].Value.ToString();
            dtpFechaCliente.Value = Convert.ToDateTime(filaActual.Cells[5].Value);
            chbEstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
        }

        private void btnDatosCliente_Click(object sender, EventArgs e)
        {
            gbDatosCliente.Enabled = true;
            btnModificarCliente.Enabled = true;
            btnAgregarCliente.Enabled = false;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            gbDatosCliente.Enabled = true;
            btnAgregarCliente.Enabled = true;
            limpiarVariables();
            btnModificarCliente.Enabled = false;
        }
    }
}
