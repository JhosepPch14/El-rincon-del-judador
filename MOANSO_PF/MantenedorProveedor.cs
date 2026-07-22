using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class MantenedorProveedor : Form
    {
        private int _proveedorID = 0;

        public MantenedorProveedor()
        {
            InitializeComponent();
            gbProveedor.Enabled = false;
            listarProveedor();
        }

        public void listarProveedor()
        {
            dgvProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
        }

        public void limpiarVariables()
        {
            txtNombreProveedor.Text = "";
            txtRucProveedor.Text = "";
            txtCorreoProveedor.Text = "";
            dtpFRegistro.Value = DateTime.Now;
            chbEstadoProveedor.Checked = true;
            _proveedorID = 0;
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            entProveedor p = new entProveedor
            {
                NombreProveedor = txtNombreProveedor.Text.Trim(),
                RUC = txtRucProveedor.Text.Trim(),
                EmailProveedor = txtCorreoProveedor.Text.Trim(),
                FechaRProveedor = dtpFRegistro.Value,
                EstadoProveedor = chbEstadoProveedor.Checked
            };

            var result = logProveedor.Instancia.InsertarProveedor(p);
            if (result.Success)
                MessageBox.Show("Proveedor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbProveedor.Enabled = false;
            listarProveedor();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (_proveedorID == 0)
            {
                MessageBox.Show("Seleccione un proveedor de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entProveedor p = new entProveedor
            {
                IdProveedor = _proveedorID,
                NombreProveedor = txtNombreProveedor.Text.Trim(),
                RUC = txtRucProveedor.Text.Trim(),
                EmailProveedor = txtCorreoProveedor.Text.Trim(),
                FechaRProveedor = dtpFRegistro.Value,
                EstadoProveedor = chbEstadoProveedor.Checked
            };

            var result = logProveedor.Instancia.EditarProveedor(p);
            if (result.Success)
                MessageBox.Show("Proveedor modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbProveedor.Enabled = false;
            listarProveedor();
        }

        private void btnInhabilitarProveedor_Click(object sender, EventArgs e)
        {
            if (_proveedorID == 0)
            {
                MessageBox.Show("Seleccione un proveedor de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logProveedor.Instancia.DeshabilitarProveedor(_proveedorID);
            if (result.Success)
                MessageBox.Show("Proveedor deshabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbProveedor.Enabled = false;
            listarProveedor();
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvProveedor.Rows[e.RowIndex];
            _proveedorID = Convert.ToInt32(filaActual.Cells[0].Value);
            txtNombreProveedor.Text = filaActual.Cells[1].Value.ToString();
            txtRucProveedor.Text = filaActual.Cells[2].Value.ToString();
            txtCorreoProveedor.Text = filaActual.Cells[3].Value.ToString();
            dtpFRegistro.Value = Convert.ToDateTime(filaActual.Cells[4].Value);
            chbEstadoProveedor.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbProveedor.Enabled = true;
            btnAgregarProveedor.Enabled = true;
            limpiarVariables();
            btnModificarProveedor.Enabled = false;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            gbProveedor.Enabled = true;
            btnModificarProveedor.Enabled = true;
            btnAgregarProveedor.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
