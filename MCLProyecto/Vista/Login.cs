using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCLProyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                textClave.UseSystemPasswordChar = true;
            else
                textClave.UseSystemPasswordChar = false;
        }

        private void textClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(textClave.Text.Equals("") || textRut.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el Rut y clave para acceder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else
            {
                Modelo.ConexionBD conexion = new Modelo.ConexionBD();
                bool existeAlumno = conexion.ComprobarRegistroAlumno(textRut.Text, textClave.Text);
                conexion.cerrarBD();
                conexion = new Modelo.ConexionBD();
                bool existeProfesor = conexion.ComprobarRegistroProfesor(textRut.Text, textClave.Text);
                conexion.cerrarBD();
                if (existeAlumno)
                {
                    PrincipalAlumno form = new PrincipalAlumno(textRut.Text);
                    Hide();
                    form.ShowDialog();
                    Close();
                }
                else if (existeProfesor)
                {
                    PrincipalProfesor form = new PrincipalProfesor(textRut.Text);
                    Hide();
                    form.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuario no existe, o ingresó mal el RUT o la clave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SeleccionarTipoUsuario form = new SeleccionarTipoUsuario();
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
