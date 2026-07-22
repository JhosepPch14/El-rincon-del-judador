using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class MantenedorEncargardoAlmacen : Form
    {
        private int _encargadoID = 0;

        public MantenedorEncargardoAlmacen()
        {
            InitializeComponent();
            gbDatos.Enabled = false;
            listarEnAlmacen();
        }

        public void listarEnAlmacen()
        {
            dgvEnAlmacen.DataSource = logEnAlmacen.Instancia.ListarEnAlmacen();
        }

        public void limpiarVariables()
        {
            txtDNIEnAlmacen.Text = "";
            txtNombreEnAlmacen.Text = "";
            txtNumeroEnAlmacen.Text = "";
            dtpFechaRegistro.Value = DateTime.Now;
            chbEstadoEnAlmacen.Checked = true;
            _encargadoID = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entEnAlmacen ea = new entEnAlmacen
            {
                Nombre = txtNombreEnAlmacen.Text.Trim(),
                DNI = txtDNIEnAlmacen.Text.Trim(),
                Numero = txtNumeroEnAlmacen.Text.Trim(),
                FechaIngreso = dtpFechaRegistro.Value,
                Estado = chbEstadoEnAlmacen.Checked
            };

            var result = logEnAlmacen.Instancia.agregarEnAlmacen(ea);
            if (result.Success)
                MessageBox.Show("Encargado registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatos.Enabled = false;
            listarEnAlmacen();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_encargadoID == 0)
            {
                MessageBox.Show("Seleccione un encargado de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entEnAlmacen ea = new entEnAlmacen
            {
                IDEnAlmacen = _encargadoID,
                Nombre = txtNombreEnAlmacen.Text.Trim(),
                DNI = txtDNIEnAlmacen.Text.Trim(),
                Numero = txtNumeroEnAlmacen.Text.Trim(),
                FechaIngreso = dtpFechaRegistro.Value,
                Estado = chbEstadoEnAlmacen.Checked
            };

            var result = logEnAlmacen.Instancia.modificarEnAlmacen(ea);
            if (result.Success)
                MessageBox.Show("Encargado modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatos.Enabled = false;
            listarEnAlmacen();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (_encargadoID == 0)
            {
                MessageBox.Show("Seleccione un encargado de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logEnAlmacen.Instancia.inhabilitarEnAlmacen(_encargadoID);
            if (result.Success)
                MessageBox.Show("Encargado inhabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatos.Enabled = false;
            listarEnAlmacen();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregar.Enabled = true;
            limpiarVariables();
            btnModificar.Enabled = false;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnModificar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void dgvEnAlmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvEnAlmacen.Rows[e.RowIndex];
            _encargadoID = Convert.ToInt32(filaActual.Cells[0].Value);
            txtNombreEnAlmacen.Text = filaActual.Cells[1].Value.ToString();
            txtDNIEnAlmacen.Text = filaActual.Cells[2].Value.ToString();
            txtNumeroEnAlmacen.Text = filaActual.Cells[3].Value.ToString();
            dtpFechaRegistro.Value = Convert.ToDateTime(filaActual.Cells[4].Value);
            chbEstadoEnAlmacen.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
