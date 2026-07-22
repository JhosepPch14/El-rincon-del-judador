using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class MantenedorBebida : Form
    {
        private int _bebidaID = 0;

        public MantenedorBebida()
        {
            InitializeComponent();
            gbBebida.Enabled = false;
            listarBebida();
            llenarDatosCB();
        }

        public void listarBebida()
        {
            dgvBebida.DataSource = logBebida.Instancia.ListarBebida();
        }

        public void limpiarVariables()
        {
            txtNombreBebida.Text = "";
            txtPrecioBebida.Text = "";
            txtTamBebida.Text = "";
            chbEstadoBebida.Checked = true;
            _bebidaID = 0;
        }

        public void llenarDatosCB()
        {
            cbTBebida.DataSource = logTipoBebida.Instancia.ListarTBebida();
            cbTBebida.DisplayMember = "NombreTipo";
            cbTBebida.ValueMember = "IdTipoBebida";
        }

        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrecioBebida.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("Precio debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entBebida eb = new entBebida
            {
                NombreBebida = txtNombreBebida.Text.Trim(),
                Precio = precio,
                Tamaño = txtTamBebida.Text.Trim(),
                EstadoBebida = chbEstadoBebida.Checked,
                TipoBebida = Convert.ToInt32(cbTBebida.SelectedValue)
            };

            var result = logBebida.Instancia.agregarBebida(eb);
            if (result.Success)
                MessageBox.Show("Bebida registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbBebida.Enabled = false;
            listarBebida();
        }

        private void btnModificarBebida_Click(object sender, EventArgs e)
        {
            if (_bebidaID == 0)
            {
                MessageBox.Show("Seleccione una bebida de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecioBebida.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("Precio debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entBebida eb = new entBebida
            {
                IdBebida = _bebidaID,
                NombreBebida = txtNombreBebida.Text.Trim(),
                Precio = precio,
                Tamaño = txtTamBebida.Text.Trim(),
                EstadoBebida = chbEstadoBebida.Checked,
                TipoBebida = Convert.ToInt32(cbTBebida.SelectedValue)
            };

            var result = logBebida.Instancia.modificarBebida(eb);
            if (result.Success)
                MessageBox.Show("Bebida modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbBebida.Enabled = false;
            listarBebida();
        }

        private void btnInhabilitarBebida_Click(object sender, EventArgs e)
        {
            if (_bebidaID == 0)
            {
                MessageBox.Show("Seleccione una bebida de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logBebida.Instancia.inhabilitarBebida(_bebidaID);
            if (result.Success)
                MessageBox.Show("Bebida inhabilitada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbBebida.Enabled = false;
            listarBebida();
        }

        private void dgvBebida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvBebida.Rows[e.RowIndex];
            _bebidaID = Convert.ToInt32(filaActual.Cells[0].Value);
            txtNombreBebida.Text = filaActual.Cells[1].Value.ToString();
            txtPrecioBebida.Text = filaActual.Cells[2].Value.ToString();
            txtTamBebida.Text = filaActual.Cells[3].Value.ToString();
            chbEstadoBebida.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbBebida.Enabled = true;
            btnModificarBebida.Enabled = false;
            limpiarVariables();
            btnAgregarBebida.Enabled = true;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            gbBebida.Enabled = true;
            btnModificarBebida.Enabled = true;
            btnAgregarBebida.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
