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
    public partial class PrincipalAlumno : Form
    {
        private string rut;

        public PrincipalAlumno(string rut)
        {
            InitializeComponent();
            this.rut = rut;
            Modelo.ConexionBD conexion = new Modelo.ConexionBD();
            string nombreAlumno = conexion.SeleccionarNombreAlumno(rut);
            nombreUsuario.Text = nombreAlumno;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void nombreUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tipoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void nombreUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureDiagnostico.Visible = false;
            pictureDiagnosticoP.Visible = true;

            pictureModulo.Visible = true;
            pictureModuloP.Visible = false;
            pictureProgreso.Visible = true;
            pictureProgresoP.Visible = false;
            pictureHistorial.Visible = true;
            pictureHistorialP.Visible = false;
            pictureGenerarReporte.Visible = true;
            pictureGenerarReporteP.Visible = false;

            Modelo.ConexionBD conexion = new Modelo.ConexionBD();
            if (conexion.diagnosticoRealizado(rut))
            {
                MessageBox.Show("Ya haz realizado la Evaluación de Diagnóstico. Ahora debes realizar el módulo que corresponda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else
            {

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureModulo.Visible = false;
            pictureModuloP.Visible = true;

            pictureDiagnostico.Visible = true;
            pictureDiagnosticoP.Visible = false;
            pictureProgreso.Visible = true;
            pictureProgresoP.Visible = false;
            pictureHistorial.Visible = true;
            pictureHistorialP.Visible = false;
            pictureGenerarReporte.Visible = true;
            pictureGenerarReporteP.Visible = false;

            Modelo.ConexionBD conexion = new Modelo.ConexionBD();
            if (!conexion.diagnosticoRealizado(rut))
            {
                MessageBox.Show("Debes realizar la Evaluación de Diagnóstico para continuar con los módulos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                pictureModulo.Visible = true;
                pictureModuloP.Visible = false;
            }
            else
            {

            }
        }

        private void pictureProgreso_Click(object sender, EventArgs e)
        {
            pictureProgreso.Visible = false;
            pictureProgresoP.Visible = true;

            pictureDiagnostico.Visible = true;
            pictureDiagnosticoP.Visible = false;
            pictureModulo.Visible = true;
            pictureModuloP.Visible = false;
            pictureHistorial.Visible = true;
            pictureHistorialP.Visible = false;
            pictureGenerarReporte.Visible = true;
            pictureGenerarReporteP.Visible = false;
        }

        private void pictureHistorial_Click(object sender, EventArgs e)
        {
            pictureHistorial.Visible = false;
            pictureHistorialP.Visible = true;

            pictureDiagnostico.Visible = true;
            pictureDiagnosticoP.Visible = false;
            pictureModulo.Visible = true;
            pictureModuloP.Visible = false;
            pictureProgreso.Visible = true;
            pictureProgresoP.Visible = false;
            pictureGenerarReporte.Visible = true;
            pictureGenerarReporteP.Visible = false;
        }

        private void pictureGenerarReporte_Click(object sender, EventArgs e)
        {
            pictureGenerarReporte.Visible = false;
            pictureGenerarReporteP.Visible = true;

            pictureDiagnostico.Visible = true;
            pictureDiagnosticoP.Visible = false;
            pictureModulo.Visible = true;
            pictureModuloP.Visible = false;
            pictureProgreso.Visible = true;
            pictureProgresoP.Visible = false;
            pictureHistorial.Visible = true;
            pictureHistorialP.Visible = false;
        }

        private void panelPerfilAlumno_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
