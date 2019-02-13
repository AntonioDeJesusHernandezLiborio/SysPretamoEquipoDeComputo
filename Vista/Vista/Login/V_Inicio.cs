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
using Vista.Menu;

namespace Vista
{
    public partial class V_Inicio : Form
    {
        E_Empleado entidadEmpledo = new E_Empleado();
        C_Login controladorLogin = new C_Login();
        string idEmpleado=null;


        public V_Inicio()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != "" && txtContraseña.Text.Trim() != "")
            {
                DataTable dt;
                entidadEmpledo.Nombre = txtUsuario.Text;
                entidadEmpledo.Clave = txtContraseña.Text;
                dt = controladorLogin.IniciarSesion(entidadEmpledo);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bienvenido");
                    idEmpleado = dt.Rows[0]["emple_intCodigo"].ToString();
                    V_Menu menu = new V_Menu(idEmpleado,this);
                    menu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                    txtUsuario.Focus();
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                }

            }
            else
            {
                MessageBox.Show("Llenar los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
