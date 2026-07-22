using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class TipoBebida : Form
    {
        private int _tipoBebidaID = 0;

        public TipoBebida()
        {
            InitializeComponent();
            gbDatosTBebida.Enabled = false;
            listarTBebida();
        }

        public void listarTBebida()
        {
            dgvTipoBebidas.DataSource = logTipoBebida.Instancia.ListarTBebida();
        }

        public void limpiarVariables()
        {
            txtNombreTBebida.Text = "";
            chbEstadoTBebida.Checked = true;
            _tipoBebidaID = 0;
        }

        private void btnAgregarTBebida_Click(object sender, EventArgs e)
        {
            entTipoBebida tb = new entTipoBebida
            {
                NombreTipo = txtNombreTBebida.Text.Trim(),
                Estado = chbEstadoTBebida.Checked
            };

            var result = logTipoBebida.Instancia.InsertarTBebida(tb);
            if (result.Success)
                MessageBox.Show("Tipo de bebida registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosTBebida.Enabled = false;
            listarTBebida();
        }

        private void btnModificarTBebida_Click(object sender, EventArgs e)
        {
            if (_tipoBebidaID == 0)
            {
                MessageBox.Show("Seleccione un tipo de bebida de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entTipoBebida tb = new entTipoBebida
            {
                IdTipoBebida = _tipoBebidaID,
                NombreTipo = txtNombreTBebida.Text.Trim(),
                Estado = chbEstadoTBebida.Checked
            };

            var result = logTipoBebida.Instancia.ModificarTBebida(tb);
            if (result.Success)
                MessageBox.Show("Tipo de bebida modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosTBebida.Enabled = false;
            listarTBebida();
        }

        private void btnInhabilitarTBebida_Click(object sender, EventArgs e)
        {
            if (_tipoBebidaID == 0)
            {
                MessageBox.Show("Seleccione un tipo de bebida de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logTipoBebida.Instancia.InhabilitarTBebida(_tipoBebidaID);
            if (result.Success)
                MessageBox.Show("Tipo de bebida inhabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosTBebida.Enabled = false;
            listarTBebida();
        }

        private void dgvTipoBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvTipoBebidas.Rows[e.RowIndex];
            _tipoBebidaID = Convert.ToInt32(filaActual.Cells[0].Value);
            txtNombreTBebida.Text = filaActual.Cells[1].Value.ToString();
            chbEstadoTBebida.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }

        private void btnNuevoTBebida_Click(object sender, EventArgs e)
        {
            gbDatosTBebida.Enabled = true;
            btnAgregarTBebida.Enabled = true;
            limpiarVariables();
            btnModificarTBebida.Enabled = false;
        }

        private void btnDatosTBebida_Click(object sender, EventArgs e)
        {
            gbDatosTBebida.Enabled = true;
            btnModificarTBebida.Enabled = true;
            btnAgregarTBebida.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
