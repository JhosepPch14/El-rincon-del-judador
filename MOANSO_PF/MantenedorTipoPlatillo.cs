using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class MantenedorTipoPlatillo : Form
    {
        private int _tipoPlatilloID = 0;

        public MantenedorTipoPlatillo()
        {
            InitializeComponent();
            gbDatosTPlatillo.Enabled = false;
            listarTPlatillo();
        }

        public void listarTPlatillo()
        {
            dgvTPlatillo.DataSource = logTPlatillo.Instancia.ListarTPlatillo();
        }

        public void limpiarVariables()
        {
            txtNombreTPlatillo.Text = "";
            chbEstadoTPlatillo.Checked = true;
            _tipoPlatilloID = 0;
        }

        private void btnAgregarTPlatillo_Click(object sender, EventArgs e)
        {
            entTPlatillo tp = new entTPlatillo
            {
                NombreTipo = txtNombreTPlatillo.Text.Trim(),
                EstadoTPlatillo = chbEstadoTPlatillo.Checked
            };

            var result = logTPlatillo.Instancia.agregarTPlatillo(tp);
            if (result.Success)
                MessageBox.Show("Tipo de platillo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosTPlatillo.Enabled = false;
            listarTPlatillo();
        }

        private void btnModificarTPlatillo_Click(object sender, EventArgs e)
        {
            if (_tipoPlatilloID == 0)
            {
                MessageBox.Show("Seleccione un tipo de platillo de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entTPlatillo tp = new entTPlatillo
            {
                IdTipoPlatillo = _tipoPlatilloID,
                NombreTipo = txtNombreTPlatillo.Text.Trim(),
                EstadoTPlatillo = chbEstadoTPlatillo.Checked
            };

            var result = logTPlatillo.Instancia.modificarTPlatillo(tp);
            if (result.Success)
                MessageBox.Show("Tipo de platillo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosTPlatillo.Enabled = false;
            listarTPlatillo();
        }

        private void btnInhabilitarTPlatillo_Click(object sender, EventArgs e)
        {
            if (_tipoPlatilloID == 0)
            {
                MessageBox.Show("Seleccione un tipo de platillo de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logTPlatillo.Instancia.inhabilitarTPlatillo(_tipoPlatilloID);
            if (result.Success)
                MessageBox.Show("Tipo de platillo inhabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosTPlatillo.Enabled = false;
            listarTPlatillo();
        }

        private void dgvTPlatillo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvTPlatillo.Rows[e.RowIndex];
            _tipoPlatilloID = Convert.ToInt32(filaActual.Cells[0].Value);
            txtNombreTPlatillo.Text = filaActual.Cells[1].Value.ToString();
            chbEstadoTPlatillo.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void btnNuevoTipo_Click(object sender, EventArgs e)
        {
            gbDatosTPlatillo.Enabled = true;
            btnAgregarTPlatillo.Enabled = true;
            limpiarVariables();
            btnModificarTPlatillo.Enabled = false;
        }

        private void btnDatosTipo_Click(object sender, EventArgs e)
        {
            gbDatosTPlatillo.Enabled = true;
            btnModificarTPlatillo.Enabled = true;
            btnAgregarTPlatillo.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
