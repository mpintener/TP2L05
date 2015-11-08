using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;


namespace UI.Desktop
{
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
        }


        public void Listar()
        {
            EspecialidadLogic el = new EspecialidadLogic();
            this.dgvEspecialidades.AutoGenerateColumns = true;
            List<Especialidad> l = el.GetAll();
            this.dgvEspecialidades.DataSource = l;
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            Listar();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult DR = (MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (DR == DialogResult.Yes) this.Close();

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop ed = new EspecialidadDesktop(AplicationForm.ModoForm.Alta);
            ed.Text = "Alta especialidad";
            ed.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count != 0)
            {
                int ID = ((Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                EspecialidadDesktop ed = new EspecialidadDesktop(ID, AplicationForm.ModoForm.Modificacion);
                ed.Text = "Editar especialidad";
                ed.ShowDialog();
                this.Listar();
            }

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count != 0)
            {
                int ID = ((Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                EspecialidadDesktop ed = new EspecialidadDesktop(ID, AplicationForm.ModoForm.Baja);
                ed.Text = "Eliminar especialidad";
                ed.ShowDialog();
                this.Listar();
            }
        }

        private void dgvEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
