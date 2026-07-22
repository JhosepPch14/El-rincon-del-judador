using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class MantenedorIngredientes : Form
    {
        private int _ingredienteID = 0;

        public MantenedorIngredientes()
        {
            InitializeComponent();
            gbDatosIngredientes.Enabled = false;
            listarIngredientes();
        }

        public void listarIngredientes()
        {
            dgvIngredientes.DataSource = logInsumos.Instancia.ListarInsumos();
        }

        public void limpiarVariables()
        {
            txtNombreIngrediente.Text = "";
            txtCantidadIngrediente.Text = "";
            chbEstadoIngrediente.Checked = true;
            _ingredienteID = 0;
        }

        private void btnAgregarIngrediente_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCantidadIngrediente.Text.Trim(), out decimal cantidad))
            {
                MessageBox.Show("Cantidad debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entInsumos ins = new entInsumos
            {
                NombreInsumo = txtNombreIngrediente.Text.Trim(),
                Cantidad = cantidad,
                EstadoInsumos = chbEstadoIngrediente.Checked
            };

            var result = logInsumos.Instancia.InsertarInsumo(ins);
            if (result.Success)
                MessageBox.Show("Ingrediente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosIngredientes.Enabled = false;
            listarIngredientes();
        }

        private void btnModificarIngrediente_Click(object sender, EventArgs e)
        {
            if (_ingredienteID == 0)
            {
                MessageBox.Show("Seleccione un ingrediente de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCantidadIngrediente.Text.Trim(), out decimal cantidad))
            {
                MessageBox.Show("Cantidad debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entInsumos ins = new entInsumos
            {
                IdInsumo = _ingredienteID,
                NombreInsumo = txtNombreIngrediente.Text.Trim(),
                Cantidad = cantidad,
                EstadoInsumos = chbEstadoIngrediente.Checked
            };

            var result = logInsumos.Instancia.ModificarInsumo(ins);
            if (result.Success)
                MessageBox.Show("Ingrediente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosIngredientes.Enabled = false;
            listarIngredientes();
        }

        private void btnInhabilitarIngrediente_Click(object sender, EventArgs e)
        {
            if (_ingredienteID == 0)
            {
                MessageBox.Show("Seleccione un ingrediente de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logInsumos.Instancia.InhabilitarInsumo(_ingredienteID);
            if (result.Success)
                MessageBox.Show("Ingrediente inhabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosIngredientes.Enabled = false;
            listarIngredientes();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosIngredientes.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvIngredientes.Rows[e.RowIndex];
            _ingredienteID = Convert.ToInt32(filaActual.Cells[0].Value);
            txtNombreIngrediente.Text = filaActual.Cells[1].Value.ToString();
            txtCantidadIngrediente.Text = filaActual.Cells[2].Value.ToString();
            chbEstadoIngrediente.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatosIngredientes.Enabled = true;
            btnAgregarIngrediente.Enabled = true;
            limpiarVariables();
            btnModificarIngrediente.Enabled = false;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            gbDatosIngredientes.Enabled = true;
            btnModificarIngrediente.Enabled = true;
            btnAgregarIngrediente.Enabled = false;
        }
    }
}
