using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class MantenedorMesero : Form
    {
        private int _meseroID = 0;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnDatos;

        public MantenedorMesero()
        {
            InitializeComponent();
            gbDatosMesero.Enabled = false;
            listarMesero();
            InicializarBotonesExtras();
        }

        private void InicializarBotonesExtras()
        {
            btnNuevo = new System.Windows.Forms.Button();
            btnNuevo.Location = new System.Drawing.Point(530, 395);
            btnNuevo.Size = new System.Drawing.Size(82, 27);
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += (s, e) =>
            {
                gbDatosMesero.Enabled = true;
                btnAgregarMesero.Enabled = true;
                limpiarVariables();
                btnModificarMesero.Enabled = false;
            };
            Controls.Add(btnNuevo);

            btnDatos = new System.Windows.Forms.Button();
            btnDatos.Location = new System.Drawing.Point(640, 395);
            btnDatos.Size = new System.Drawing.Size(100, 27);
            btnDatos.Text = "Editar Datos";
            btnDatos.UseVisualStyleBackColor = true;
            btnDatos.Click += (s, e) =>
            {
                gbDatosMesero.Enabled = true;
                btnModificarMesero.Enabled = true;
                btnAgregarMesero.Enabled = false;
            };
            Controls.Add(btnDatos);
        }

        public void listarMesero()
        {
            dgvMesero.DataSource = logMesero.Instancia.ListarMesero();
        }

        public void limpiarVariables()
        {
            txtNombreMesero.Text = "";
            txtDNIMesero.Text = "";
            txtTelefono.Text = "";
            dtpFechaIngreso.Value = DateTime.Now;
            chbEstadoMesero.Checked = true;
            _meseroID = 0;
        }

        private void btnAgregarMesero_Click(object sender, EventArgs e)
        {
            entMesero m = new entMesero
            {
                NombreMesero = txtNombreMesero.Text.Trim(),
                DNIMesero = txtDNIMesero.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                FechaIngreso = dtpFechaIngreso.Value,
                EstadoMesero = chbEstadoMesero.Checked
            };

            var result = logMesero.Instancia.agregarMesero(m);
            if (result.Success)
                MessageBox.Show("Mesero registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosMesero.Enabled = false;
            listarMesero();
        }

        private void btnModificarMesero_Click(object sender, EventArgs e)
        {
            if (_meseroID == 0)
            {
                MessageBox.Show("Seleccione un mesero de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entMesero m = new entMesero
            {
                IdMesero = _meseroID,
                NombreMesero = txtNombreMesero.Text.Trim(),
                DNIMesero = txtDNIMesero.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                FechaIngreso = dtpFechaIngreso.Value,
                EstadoMesero = chbEstadoMesero.Checked
            };

            var result = logMesero.Instancia.modificarMesero(m);
            if (result.Success)
                MessageBox.Show("Mesero modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosMesero.Enabled = false;
            listarMesero();
        }

        private void btnInhabilitarMesero_Click(object sender, EventArgs e)
        {
            if (_meseroID == 0)
            {
                MessageBox.Show("Seleccione un mesero de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logMesero.Instancia.inhabilitarMesero(_meseroID);
            if (result.Success)
                MessageBox.Show("Mesero inhabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            gbDatosMesero.Enabled = false;
            listarMesero();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbDatosMesero.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvMesero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvMesero.Rows[e.RowIndex];
            _meseroID = Convert.ToInt32(filaActual.Cells[0].Value);
            txtNombreMesero.Text = filaActual.Cells[1].Value.ToString();
            txtDNIMesero.Text = filaActual.Cells[2].Value.ToString();
            txtTelefono.Text = filaActual.Cells[3].Value.ToString();
            dtpFechaIngreso.Value = Convert.ToDateTime(filaActual.Cells[4].Value);
            chbEstadoMesero.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);
        }

    }
}
