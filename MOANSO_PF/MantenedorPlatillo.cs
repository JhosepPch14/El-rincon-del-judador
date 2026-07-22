using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class MantenedorPlatillo : Form
    {
        private int _platilloID = 0;

        public MantenedorPlatillo()
        {
            InitializeComponent();
            gbDatosPlatillo.Enabled = false;
            listarPlatillo();
            llenarDatosCBTPlatillo();
        }

        public void listarPlatillo()
        {
            dgvPlatillo.DataSource = logPlatillo.Instancia.ListarPlatillo();
        }

        public void limpiarVariables()
        {
            txtNombrePlatillo.Text = "";
            txtPrecioPlatillo.Text = "";
            chbEstadoPlatillo.Checked = true;
            _platilloID = 0;
        }

        public void llenarDatosCBTPlatillo()
        {
            cbTPlatillo.DataSource = logTPlatillo.Instancia.ListarTPlatillo();
            cbTPlatillo.DisplayMember = "NombreTipo";
            cbTPlatillo.ValueMember = "IdTipoPlatillo";
        }

        private void btnAgregarPlatillo_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrecioPlatillo.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("Precio debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entPlatillo pl = new entPlatillo
            {
                NombrePlatillo = txtNombrePlatillo.Text.Trim(),
                PrecioPlatillo = precio,
                EstadoPlatillo = chbEstadoPlatillo.Checked,
                IdTipoPlatillo = Convert.ToInt32(cbTPlatillo.SelectedValue)
            };

            var result = logPlatillo.Instancia.InsertarPlatillo(pl);
            if (result.Success)
                MessageBox.Show("Platillo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosPlatillo.Enabled = false;
            listarPlatillo();
        }

        private void btnModificarPlatillo_Click(object sender, EventArgs e)
        {
            if (_platilloID == 0)
            {
                MessageBox.Show("Seleccione un platillo de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecioPlatillo.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("Precio debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entPlatillo pl = new entPlatillo
            {
                IdPlatillo = _platilloID,
                NombrePlatillo = txtNombrePlatillo.Text.Trim(),
                PrecioPlatillo = precio,
                EstadoPlatillo = chbEstadoPlatillo.Checked
            };

            var result = logPlatillo.Instancia.EditarPlatillo(pl);
            if (result.Success)
                MessageBox.Show("Platillo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosPlatillo.Enabled = false;
            listarPlatillo();
        }

        private void btnInhabilitarPlatillo_Click(object sender, EventArgs e)
        {
            if (_platilloID == 0)
            {
                MessageBox.Show("Seleccione un platillo de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logPlatillo.Instancia.DeshabilitarPlatillo(_platilloID);
            if (result.Success)
                MessageBox.Show("Platillo deshabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosPlatillo.Enabled = false;
            listarPlatillo();
        }

        private void dgvPlatillo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvPlatillo.Rows[e.RowIndex];
            _platilloID = Convert.ToInt32(filaActual.Cells[0].Value);
            txtNombrePlatillo.Text = filaActual.Cells[1].Value.ToString();
            txtPrecioPlatillo.Text = filaActual.Cells[2].Value.ToString();
            chbEstadoPlatillo.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }

        private void btnNuevoPlatillo_Click(object sender, EventArgs e)
        {
            gbDatosPlatillo.Enabled = true;
            btnModificarPlatillo.Enabled = false;
            btnAgregarPlatillo.Enabled = true;
            limpiarVariables();
        }

        private void btnDatosPlatillo_Click(object sender, EventArgs e)
        {
            gbDatosPlatillo.Enabled = true;
            btnAgregarPlatillo.Enabled = false;
            btnModificarPlatillo.Enabled = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
