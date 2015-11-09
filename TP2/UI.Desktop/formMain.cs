using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            Login appLogin = new Login();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.ShowDialog();
        }

        private void comisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comisiones c = new Comisiones();
            c.ShowDialog();
        }

        private void alumnoInscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnosInscripciones ai = new AlumnosInscripciones();
            ai.ShowDialog();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursos c = new Cursos();
            c.ShowDialog();
        }

        private void docenteCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocentesCursos dc = new DocentesCursos();
            dc.ShowDialog();
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades esp = new Especialidades();
            esp.ShowDialog();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias m = new Materias();
            m.ShowDialog();
        }

        private void modulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos m = new Modulos();
            m.ShowDialog();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personas p = new Personas();
            p.ShowDialog();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes p = new Planes();
            p.ShowDialog();
        }
    }
}
