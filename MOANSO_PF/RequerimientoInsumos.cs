using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MOANSO_PF
{
    public partial class RequerimientoInsumos : Form
    {
        private readonly List<entDetalleReq> listaDetalles = new List<entDetalleReq>();
        private int _requerimientoID = 0;
        private int _detalleSeleccionado = -1;

        public RequerimientoInsumos()
        {
            InitializeComponent();
            listarReqInsumos();
            llenarDatosCB();
        }

        public void listarReqInsumos()
        {
            dgvReqInsum.DataSource = logReqInsumos.Instancia.ListarReqInsumos();
        }

        public void listarDetalleReq(int requerimientoID)
        {
            dgvDetalleReq.DataSource = logDetalleReq.Instancia.ListarDetallesReq(requerimientoID);
        }

        public void llenarDatosCB()
        {
            cbInsumos.DataSource = logInsumos.Instancia.ListarInsumos();
            cbInsumos.DisplayMember = "NombreInsumo";
            cbInsumos.ValueMember = "IdInsumo";

            cbEnAlmacen.DataSource = logEnAlmacen.Instancia.ListarEnAlmacen();
            cbEnAlmacen.DisplayMember = "Nombre";
            cbEnAlmacen.ValueMember = "IDEnAlmacen";
        }

        private void limpiarVariables()
        {
            txtCantidad.Text = "";
            _detalleSeleccionado = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            entReqInsumos ri = new entReqInsumos
            {
                FechaRegistro = dtpFRegistro.Value,
                Estado = chbEstadoReq.Checked,
                IDEncargado = Convert.ToInt32(cbEnAlmacen.SelectedValue)
            };

            var result = logReqInsumos.Instancia.registrarReq(ri);
            if (result.Success)
            {
                _requerimientoID = result.Data;
                MessageBox.Show("Requerimiento registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            listarReqInsumos();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (_requerimientoID == 0)
            {
                MessageBox.Show("Seleccione un requerimiento de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = logReqInsumos.Instancia.anularReq(_requerimientoID);
            if (result.Success)
                MessageBox.Show("Requerimiento anulado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            limpiarVariables();
            listarReqInsumos();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCantidad.Text.Trim(), out decimal cantidad))
            {
                MessageBox.Show("Cantidad debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int insumoID = Convert.ToInt32(cbInsumos.SelectedValue);
            string nombreInsumo = cbInsumos.Text;

            listaDetalles.Add(new entDetalleReq
            {
                IDInsumo = insumoID,
                NombreInsumo = nombreInsumo,
                Cantidad = cantidad
            });

            dgvDetalleReq.DataSource = null;
            dgvDetalleReq.DataSource = listaDetalles;
        }

        private void btnRDetalle_Click(object sender, EventArgs e)
        {
            if (_requerimientoID == 0)
            {
                MessageBox.Show("Primero registre el requerimiento antes de guardar los detalles.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (logDetalleReq.Instancia.registrarDetalleReq(listaDetalles, _requerimientoID))
            {
                MessageBox.Show("Detalles registrados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listarDetalleReq(_requerimientoID);
                listarReqInsumos();
                listaDetalles.Clear();
            }
            else
            {
                MessageBox.Show("No se pudieron registrar los detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReqInsum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow filaActual = dgvReqInsum.Rows[e.RowIndex];
            _requerimientoID = Convert.ToInt32(filaActual.Cells[0].Value);
            chbEstadoReq.Checked = Convert.ToBoolean(filaActual.Cells[1].Value);
            dtpFRegistro.Value = Convert.ToDateTime(filaActual.Cells[2].Value);

            dgvDetalleReq.DataSource = logDetalleReq.Instancia.ListarDetallesReq(_requerimientoID);
        }

        private void dgvDetalleReq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvDetalleReq.Rows[e.RowIndex];
            cbInsumos.Text = fila.Cells["NombreInsumo"].Value.ToString();
            txtCantidad.Text = fila.Cells["Cantidad"].Value.ToString();
            _detalleSeleccionado = e.RowIndex;
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            if (_detalleSeleccionado >= 0 && _detalleSeleccionado < listaDetalles.Count)
            {
                var confirmar = MessageBox.Show("¿Desea eliminar este insumo?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    listaDetalles.RemoveAt(_detalleSeleccionado);
                    dgvDetalleReq.DataSource = null;
                    dgvDetalleReq.DataSource = listaDetalles;
                    _detalleSeleccionado = -1;
                    dgvDetalleReq.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un insumo antes de eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
