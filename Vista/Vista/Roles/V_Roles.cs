using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Entidad.Rol;

namespace Vista.Roles
{
    public partial class V_Roles : Form
    {
        C_Rol controladorRoles = new C_Rol();
        E_Rol entidadRoles = new E_Rol();
        public V_Roles()
        {
            InitializeComponent();
            dgwDatosRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDatosRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwDatosRoles.MultiSelect = false;
            dgwDatosRoles.RowHeadersVisible = false;
            LlenaGrid();
        }



        private void LlenaGrid()
        {
            dgwDatosRoles.DataSource = controladorRoles.ConsultarRoles();
            dgwDatosRoles.Refresh();
        }

        private void dgwDatosRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int intFila = int.Parse(dgwDatosRoles.CurrentRow.Index.ToString());
            txtCodigo.Text = dgwDatosRoles.Rows[intFila].Cells[0].Value.ToString();
            txtDescripcion.Text = dgwDatosRoles.Rows[intFila].Cells[1].Value.ToString();
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnCancelar.Visible = true;
            BtnAgregar.Visible = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar descripcion del rol.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                entidadRoles.Descripcion = txtDescripcion.Text;
                if (controladorRoles.InsertarRol(entidadRoles))
                {
                    MessageBox.Show("Guardado Correctamente","Realizado con exito");
                    LlenaGrid();
                    LimpiarCajas();

                }
                else
                {
                    MessageBox.Show("Ocurrio un error al guardar.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim() == "" || txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Favor de seleccionar descripcion del rol en la tabla \n dando click a la descripcion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                entidadRoles.Codigo = int.Parse(txtCodigo.Text);
                if (controladorRoles.EliminarRol(entidadRoles))
                {
                    MessageBox.Show("Eliminado Correctamente", "Realizado con exito");
                    LlenaGrid();
                    LimpiarCajas();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim() == "" || txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Favor de seleccionar descripcion del rol en la tabla \n dando click a la descripcion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                entidadRoles.Codigo = int.Parse(txtCodigo.Text);
                entidadRoles.Descripcion = txtDescripcion.Text;
                if (controladorRoles.ActualizarRol(entidadRoles))
                {
                    MessageBox.Show("Actualizado Correctamente", "Realizado con exito");
                    LlenaGrid();
                    LimpiarCajas();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LimpiarCajas()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtDescripcion.Focus();
            BtnAgregar.Visible = true;
            BtnCancelar.Visible = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;

        }
    }
}
