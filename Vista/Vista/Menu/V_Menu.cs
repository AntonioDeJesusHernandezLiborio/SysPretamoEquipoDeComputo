using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Roles;
using Vista.Categoria;

namespace Vista.Menu
{
    public partial class V_Menu : Form
    {
        V_Roles roles;
        V_Categoria categoria;
        V_Inicio inicio;

        string idEmpleado;
        public V_Menu()
        {
            InitializeComponent();
        }
        public V_Menu(string idEmpleado,V_Inicio inicio)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
            this.inicio = inicio;
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            if (roles == null)
            {
                roles = new V_Roles();
                roles.FormClosed += new FormClosedEventHandler(cerrar_ventana_roles);
                roles.Show();
            }
            else roles.Activate();
        }

        private void cerrar_ventana_roles(object sender, FormClosedEventArgs e)
        {
            roles = null;
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            if (categoria == null)
            {
                categoria = new V_Categoria(idEmpleado);
                categoria.FormClosed += new FormClosedEventHandler(cerrar_ventana_categoria);
                categoria.Show();
            }
            else categoria.Activate();
        }

        private void cerrar_ventana_categoria(object sender, FormClosedEventArgs e)
        {
            categoria=null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio.Show();
            inicio.txtUsuario.Clear();
            inicio.txtContraseña.Clear();
            inicio.txtUsuario.Focus();
            this.Close();
        }
    }
}
