﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class ModuloUsuarioDesktop : AplicationForm
    {
        public ModuloUsuarioDesktop()
        {
            InitializeComponent();

            ModuloUsuarioLogic MUL = new ModuloUsuarioLogic();
            this.cbIDModulo.DataSource = MUL.GetAll();
            this.cbIDModulo.DisplayMember = "id_modulo_usuario";
            this.cbIDModulo.ValueMember = "id_modulo_usuario";
        }

        private ModuloUsuario _MDActual;

        public ModuloUsuario MDActual
        {
            get { return _MDActual; }

            set { _MDActual = value; }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.MDActual.ID.ToString();
            this.cbIDModulo.Text = this.MDActual.IDModulo.ToString();
            this.mtbIDUsuario.Text = this.MDActual.IDUsuario.ToString();

            switch (Modo)
            {

                case ModoForm.Alta:
                    {
                        this.btnAceptar.Text = "Guardar";
                        this.MDActual.State = BusinessEntity.States.New;
                    }
                    break;
                case ModoForm.Modificacion:
                    {
                        this.btnAceptar.Text = "Guardar";
                        this.MDActual.State = BusinessEntity.States.Modified;
                    }
                    break;
                case ModoForm.Baja:
                    {
                        this.btnAceptar.Text = "Eliminar";
                        this.MDActual.State = BusinessEntity.States.Deleted;
                    }
                    break;
                case ModoForm.Consulta:
                    {
                        this.btnAceptar.Text = "Aceptar";
                        this.MDActual.State = BusinessEntity.States.Unmodified;
                    }
                    break;
                default:
                    break;
            }
        }

        public override void MapearADatos()
        {

            if (Modo == AplicationForm.ModoForm.Alta)
            {
                ModuloUsuario modousu = new ModuloUsuario();
                MDActual = modousu;

                this.MDActual.ID = Convert.ToInt32(this.txtID.Text);
                this.MDActual.IDModulo = Convert.ToInt32(this.cbIDModulo.SelectedValue);
                this.MDActual.IDUsuario = Convert.ToInt32(this.mtbIDUsuario.Text);

            }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
            {
                this.MDActual.ID = Convert.ToInt32(this.txtID.Text);
                this.MDActual.IDModulo = Convert.ToInt32(this.cbIDModulo.SelectedValue);
                this.MDActual.IDUsuario = Convert.ToInt32(this.mtbIDUsuario.Text);
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            ModuloUsuarioLogic ml = new ModuloUsuarioLogic();
            ml.Save(MDActual);
        }

        public override bool Validar()
        {
            string mensaje = "";
            bool ok = true;

            foreach (Control c in this.Controls)
            {
                if ((c is TextBox || c is ComboBox) && (c.Tag.ToString() != "ID") && (!Util.Util.IsComplete(c.Text))) mensaje += " - " + c.Tag.ToString() + "\n";
            }

            if (!mtbIDUsuario.MaskFull)
            {
                mensaje = "IDUsuario esta vacio.\n" + mensaje;
                ok = false;
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                mensaje = "Por favor complete los siguientes campos:\n" + mensaje;
                ok = false;
            }

            if (!string.IsNullOrEmpty(mensaje)) Notificar(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return ok;
        }


        //Agregandole new a los metodos void damos por sabido que el miembro que modificamos oculta el miembro que se hereda de la clase base.

        public new void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(titulo,mensaje,botones, icono);
        }

        public new void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        public ModuloUsuarioDesktop(ModoForm modo): this()
        {
            this.Modo = modo;
        }

        public ModuloUsuarioDesktop(int ID, ModoForm modo): this()
        {
            this.Modo = modo;
            ModuloUsuarioLogic ML = new ModuloUsuarioLogic();
            MDActual = ML.GetOne(ID);
            MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult DR = (MessageBox.Show("Seguro que desea cancelar el proceso?", "Cancelar", MessageBoxButtons.YesNo));
            if (DR == DialogResult.Yes) this.Close(); 
        }

        private void ModuloUsuarioDesktop_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.modulos' Puede moverla o quitarla según sea necesario.
            this.modulosTableAdapter.Fill(this.tp2_netDataSet.modulos);

        }

        private void mtbCupo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ttIDUsuario.ToolTipTitle = "Tipo de dato invalido";
            ttIDUsuario.Show("El campo admite solo digitos", mtbIDUsuario);
        }
    }
}