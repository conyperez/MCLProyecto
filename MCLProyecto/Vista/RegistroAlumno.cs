using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCLProyecto
{
    public partial class RegistroAlumno : Form
    {
        public RegistroAlumno()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Modelo.ConexionBD conexion = new Modelo.ConexionBD();
            bool existeRut = conexion.existeRutAlumno(textRutA.Text);
            conexion.cerrarBD();

            if (textNombreA.Text.Equals("") || textClaveA.Text.Equals("") || textClaveRepetirA.Text.Equals("") || textRutA.Text.Equals("")
                || textPaternoA.Text.Equals("") || textMaternoA.Text.Equals("") || cbCursoA.Text.Equals("") || cbLetraCurso.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (existeRut)
            {
                MessageBox.Show("Alumno ya registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Login form = new Login();
                Hide();
                form.ShowDialog();
                Close();
            }
            else if (!validarRut(textRutA.Text))
            {
                MessageBox.Show("Ingrese correctamente el Rut.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (textClaveA.Text.Length > 4 || (textClaveA.Text != textClaveRepetirA.Text))
            {
                MessageBox.Show("Ingrese correctamente la clave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else 
            {
                string curso = null;
                if (cbCursoA.Text.Equals("Quinto"))
                {
                    curso = "5";
                }
                else
                {
                    curso = "6";
                }
                curso += cbLetraCurso.Text;

                conexion = new Modelo.ConexionBD();
                conexion.InsertarDatosAlumno(textNombreA.Text, textPaternoA.Text, textMaternoA.Text, curso, textRutA.Text, textClaveA.Text, Convert.ToInt32(cbAño.Text));

                MessageBox.Show("Se ha registrado exitosamente.", "Registro Completo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Login form = new Login();
                Hide();
                form.ShowDialog();
                Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAño_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static bool validarRut(string rut)
        {
            rut = rut.Replace(".", "").ToUpper();
            Regex expresion = new Regex("^([0-9]+-[0-9K])$");
            string dv = rut.Substring(rut.Length - 1, 1);
            if (!expresion.IsMatch(rut))
            {
                return false;
            }
            char[] charCorte = { '-' };
            string[] rutTemp = rut.Split(charCorte);
            if (dv != Digito(int.Parse(rutTemp[0])))
            {
                return false;
            }
            return true;
        }

        public static string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
                return "0";
            else if (suma == 10)
                return "K";
            else
                return suma.ToString();
        }
    }
}
