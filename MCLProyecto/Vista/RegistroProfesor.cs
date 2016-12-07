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
    public partial class RegistroProfesor : Form
    {
        public RegistroProfesor()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Modelo.ConexionBD conexion = new Modelo.ConexionBD();
            bool existeRut = conexion.existeRutProfesor(textRutP.Text);
            conexion.cerrarBD();

            // FALTA VERIFICAR QUE LAS FILAS DE LA TABLA ESTEN COMPLETAS

            if (textNombreP.Text.Equals("") || textClaveP.Text.Equals("") || textClaveRepetir.Text.Equals("") || textRutP.Text.Equals("")
            || textPaternoP.Text.Equals("") || textMaternoP.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (existeRut)
            {
                MessageBox.Show("Profesor ya registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Login form = new Login();
                Hide();
                form.ShowDialog();
                Close();
            }
            else if (!validarRut(textRutP.Text))
            {
                MessageBox.Show("Ingrese correctamente el Rut.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (textClaveP.Text.Length > 4 || (textClaveP.Text != textClaveRepetir.Text))
            {
                MessageBox.Show("Ingrese correctamente la clave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                conexion = new Modelo.ConexionBD();
                conexion.InsertarDatosProfesor(textNombreP.Text, textPaternoP.Text, textMaternoP.Text, textRutP.Text, textClaveP.Text);
                conexion.cerrarBD();

                for (int i = 0; i < tablaCursos.Rows.Count - 1; i++)
                {
                    string nivel = tablaCursos.Rows[i].Cells[0].Value.ToString();
                    string letra = tablaCursos.Rows[i].Cells[1].Value.ToString();
                    string año = tablaCursos.Rows[i].Cells[2].Value.ToString();
                    int fecha = Convert.ToInt32(año);

                    string curso = null;
                    if (nivel.Equals("Quinto"))
                    {
                        curso = "5";
                    }
                    else
                    {
                        curso = "6";
                    }
                    curso += letra;

                    conexion = new Modelo.ConexionBD();
                    conexion.InsertarCursoProfesor(fecha, textRutP.Text, curso);
                    conexion.cerrarBD();
                }
  
                MessageBox.Show("Se ha registrado exitosamente.", "Registro Completo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Login form = new Login();
                Hide();
                form.ShowDialog();
                Close();
            }
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
