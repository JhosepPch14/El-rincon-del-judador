using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class MantenedorInsumos : Form
    {
        private int _insumoID = 0;

        public MantenedorInsumos()
        {
            InitializeComponent();
            gbDatosInsumo.Enabled = false;
            listarInsumos();
        }

        public void listarInsumos()
        {
            dgvInsumos.DataSource = logInsumos.Instancia.ListarInsumos();
        }

        public void limpiarVariables()
        {
            txtNombreInsumo.Text = "";
            txtCantidadInsumo.Text = "";
            chbEstadoInsumo.Checked = true;
            _insumoID = 0;
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCantidadInsumo.Text.Trim(), out decimal cantidad))
            {
                MessageBox.Show("Cantidad debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entInsumos c = new entInsumos
            {
                NombreInsumo = txtNombreInsumo.Text.Trim(),
                Cantidad = cantidad,
                EstadoInsumos = chbEstadoInsumo.Checked
            };

            var result = logInsumos.Instancia.InsertarInsumo(c);
            if (result.Success)
                MessageBox.Show("Insumo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosInsumo.Enabled = false;
            listarInsumos();
        }

        private void btnModificarInsumo_Click(object sender, EventArgs e)
        {
            if (_insumoID == 0)
            {
                MessageBox.Show("Seleccione un insumo de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCantidadInsumo.Text.Trim(), out decimal cantidad))
            {
                MessageBox.Show("Cantidad debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entInsumos c = new entInsumos
            {
                IdInsumo = _insumoID,
                NombreInsumo = txtNombreInsumo.Text.Trim(),
                Cantidad = cantidad,
                EstadoInsumos = chbEstadoInsumo.Checked
            };

            var result = logInsumos.Instancia.ModificarInsumo(c);
            if (result.Success)
                MessageBox.Show("Insumo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosInsumo.Enabled = false;
            listarInsumos();
        }

        private void btnInhabilitarInsumo_Click(object sender, EventArgs e)
        {
            if (_insumoID == 0)
            {
                MessageBox.Show("Seleccione un insumo de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logInsumos.Instancia.InhabilitarInsumo(_insumoID);
            if (result.Success)
                MessageBox.Show("Insumo inhabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosInsumo.Enabled = false;
            listarInsumos();
        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvInsumos.Rows[e.RowIndex];
            _insumoID = Convert.ToInt32(filaActual.Cells[0].Value);
            txtNombreInsumo.Text = filaActual.Cells[1].Value.ToString();
            txtCantidadInsumo.Text = filaActual.Cells[2].Value.ToString();
            chbEstadoInsumo.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosInsumo.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatosInsumo.Enabled = true;
            btnAgregarInsumo.Enabled = true;
            limpiarVariables();
            btnModificarInsumo.Enabled = false;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            gbDatosInsumo.Enabled = true;
            btnModificarInsumo.Enabled = true;
            btnAgregarInsumo.Enabled = false;
        }

    }
}
