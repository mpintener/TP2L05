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
    public partial class UsuarioDesktop : AplicationForm
        {
        public UsuarioDesktop()
            {
            InitializeComponent();
            }

        private Usuario _UsuarioActual;

        public Usuario UsuarioActual
        
            {
            get { return _UsuarioActual; }

            set { _UsuarioActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.mtbIDPersona.Text = this.UsuarioActual.IDPersona.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;                      
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.chkCambiarClave.Checked = this.UsuarioActual.CambiarClave;
            this.txtNombreUsuario.Text = this.UsuarioActual.NombreUsuario;

            switch (Modo)
                {

                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.UsuarioActual.State = BusinessEntity.States.New;
                        
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.UsuarioActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {
                        this.btnAceptar.Text = "Eliminar";
                        this.UsuarioActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";
                        this.UsuarioActual.State = BusinessEntity.States.Unmodified;
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
                Usuario usu = new Usuario();                
                UsuarioActual = usu;
                 
                this.UsuarioActual.NombreUsuario = this.txtNombreUsuario.Text;
                this.UsuarioActual.IDPersona = Convert.ToInt32(this.mtbIDPersona.Text);
                this.UsuarioActual.Clave = this.txtClave.Text;
                this.UsuarioActual.CambiarClave = this.chkCambiarClave.Checked;
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;                 
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                this.UsuarioActual.ID = Convert.ToInt32(this.txtID.Text);
                this.UsuarioActual.IDPersona = Convert.ToInt32(this.mtbIDPersona.Text);
                this.UsuarioActual.NombreUsuario = this.txtNombreUsuario.Text;
                this.UsuarioActual.Clave = this.txtClave.Text;
                this.UsuarioActual.CambiarClave = this.chkCambiarClave.Checked;
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;  
                }
            }

        public override void GuardarCambios() 
            {
            MapearADatos();
            UsuarioLogic UL = new UsuarioLogic();
            UL.Save(UsuarioActual);
            }


        public override bool Validar()
        {
            string mensaje = "";
            bool ok = true;

            if (Modo == ModoForm.Alta || Modo == ModoForm.Baja)
            {

                foreach (Control c in this.Controls)
                {
                    if ((c is TextBox || c is ComboBox) && (c.Tag.ToString() != "ID" && c.Tag.ToString() != "NuevaClave" && c.Tag.ToString() != "ConfirmarNuevaClave") && (!Util.Util.IsComplete(c.Text))) mensaje += " - " + c.Tag.ToString() + "\n";
                }
            }
            else if (Modo == ModoForm.Modificacion && this.chkCambiarClave.Checked)
            {
                foreach (Control c in this.Controls)
                {
                    if ((c is TextBox || c is ComboBox) && (c.Tag.ToString() != "ID") && (!Util.Util.IsComplete(c.Text))) mensaje += " - " + c.Tag.ToString() + "\n";
                }

                this.txtNuevaClave.ReadOnly = false;
                this.txtConfirmarNuevaClave.ReadOnly = false;

                if (!(this.txtNuevaClave.Text.Equals(this.txtConfirmarNuevaClave.Text) || (this.txtNuevaClave.Text.Length < 8)))
                {
                    this.txtClave.Text = this.txtNuevaClave.Text;
                }
            }

            if (!(this.txtClave.Text.Equals(this.txtConfirmarClave.Text)) || (this.txtClave.Text.Length < 8))
            {
                mensaje += "La contraseña ingresada no coincide o posee menos de ocho caracteres.\n";
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

        private void btnAceptar_Click( object sender, EventArgs e )
            {
            if (Validar() == true)
                {
                GuardarCambios();
                this.Close();
                }
            }

        //Agregandole new a los metodos void damos por sabido que el miembro que modificamos oculta el miembro que se hereda de la clase base.
        
        public new  void Notificar(string titulo,string mensaje,MessageBoxButtons botones,MessageBoxIcon icono)
            {
            MessageBox.Show(titulo,mensaje, botones, icono);
            }

        public new void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono )
            {
            this.Notificar(this.Text, mensaje, botones, icono);
            }

        public UsuarioDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public UsuarioDesktop(int ID, ModoForm modo):this()
            {
            this.Modo = modo;
            UsuarioLogic UL = new UsuarioLogic();
            UsuarioActual = UL.GetOne(ID);
            MapearDeDatos();
            }

        private void btnCancelar_Click( object sender, EventArgs e )
            {
            DialogResult DR = (MessageBox.Show("Seguro que desea cancelar el proceso?","Cancelar", MessageBoxButtons.YesNo));
            if (DR == DialogResult.Yes) this.Close();      
            }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Siempre se deben ingresar 5 numeros, de lo contrario tira error. Buscar como hacer que se complete con ceros
            int id = int.Parse(this.mtbIDPersona.Text);
            UsuarioLogic UL = new UsuarioLogic();
            UsuarioActual = UL.GetOne(id);
            if (UsuarioActual == null)
            {
                DialogResult DR = (MessageBox.Show("El id no existe", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Error));
            }        
        }
    }
}
