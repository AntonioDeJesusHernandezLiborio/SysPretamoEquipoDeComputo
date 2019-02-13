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
using Entidad;

namespace Vista.Categoria
{
    public partial class V_Categoria : Form
    {
        C_Categoria controladorCategoria = new C_Categoria();
        E_Categoria entidadCategoria = new E_Categoria();


        string idEmpleado;
        public V_Categoria(string idEmpleado)
        {
            InitializeComponent();
            LlenaGrid();
            dgwDatosCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDatosCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwDatosCategoria.MultiSelect = false;
            dgwDatosCategoria.RowHeadersVisible = false;
            this.idEmpleado = idEmpleado;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }
        private void LlenaGrid()
        {
            dgwDatosCategoria.DataSource = controladorCategoria.ConsultarCategoria();
            dgwDatosCategoria.Refresh();
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

        private void dgwDatosCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int intFila = int.Parse(dgwDatosCategoria.CurrentRow.Index.ToString());
            txtCodigo.Text = dgwDatosCategoria.Rows[intFila].Cells[0].Value.ToString();
            txtDescripcion.Text = dgwDatosCategoria.Rows[intFila].Cells[1].Value.ToString();
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnCancelar.Visible = true;
            BtnAgregar.Visible = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            entidadCategoria.Nombre = txtDescripcion.Text;
            entidadCategoria.Id_creacion = int.Parse(idEmpleado);
            if (controladorCategoria.insertaCategoria(entidadCategoria))
            {
                MessageBox.Show("Guardado Correctamente", "Realizado con exito");
                LlenaGrid();
                LimpiarCajas();

            }
            else
            {
                MessageBox.Show("Ocurrio un error al guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            entidadCategoria.Codigo =int.Parse(txtCodigo.Text);
            entidadCategoria.Nombre = txtDescripcion.Text;
            entidadCategoria.Id_modificacion = int.Parse(idEmpleado);
            if (controladorCategoria.ActualizarCategoria(entidadCategoria))
            {
                MessageBox.Show("Actualizo Correctamente", "Realizado con exito");
                LlenaGrid();
                LimpiarCajas();

            }
            else
            {
                MessageBox.Show("Ocurrio un error al actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            entidadCategoria.Codigo = int.Parse(txtCodigo.Text);
            entidadCategoria.Id_eliminacion = int.Parse(idEmpleado);
            if (controladorCategoria.EliminarCategoria(entidadCategoria))
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
}
