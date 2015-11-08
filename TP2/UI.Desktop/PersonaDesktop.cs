using System;
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
    public partial class PersonaDesktop : AplicationForm
    {
        public PersonaDesktop()
        {
            InitializeComponent();

            PlanLogic PL = new PlanLogic();
            this.cbIDPlan.DataSource = PL.GetAll();
            this.cbIDPlan.DisplayMember = "descripcion";
            this.cbIDPlan.ValueMember = "id_plan";
        }
        private Persona _PersonaActual;

        public Persona PersonaActual
        
            {
            get { return _PersonaActual; }

            set { _PersonaActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtID.Text = this.PersonaActual.ID.ToString();        
            this.txtApellido.Text = this.PersonaActual.Apellido;           
            this.txtNombre.Text = this.PersonaActual.Nombre;           
            this.txtDireccion.Text = this.PersonaActual.Direccion;      
            this.txtEmail.Text = this.PersonaActual.Email;            
            this.txtLegajo.Text = this.PersonaActual.Legajo.ToString();
            this.mtbTelefono.Text = this.PersonaActual.Telefono;
            this.txtTipoPersona.Text = this.PersonaActual.TiposPersona.ToString();
            this.cbIDPlan.Text = this.PersonaActual.IDPlan.ToString();
            this.mtbFechaNacimiento.Text = this.PersonaActual.FechaNacimiento.ToString();

            switch (Modo)
                {

                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.PersonaActual.State = BusinessEntity.States.New;
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.PersonaActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {
                        this.btnAceptar.Text = "Eliminar";
                        this.PersonaActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";
                        this.PersonaActual.State = BusinessEntity.States.Unmodified;
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
                    Persona per = new Persona();
                    PersonaActual = per;

                    this.PersonaActual.Nombre = this.txtNombre.Text;
                    this.PersonaActual.Apellido = this.txtApellido.Text;
                    this.PersonaActual.Legajo = Convert.ToInt32(txtLegajo.Text);
                    this.PersonaActual.IDPlan = Convert.ToInt32(this.cbIDPlan.SelectedValue);
                    this.PersonaActual.Direccion = this.txtDireccion.Text;
                    this.PersonaActual.Telefono = this.mtbTelefono.Text;
                    this.PersonaActual.Email = this.txtEmail.Text;
                    this.PersonaActual.TiposPersona = Convert.ToInt32(this.txtTipoPersona.Text);
                    this.PersonaActual.FechaNacimiento = Convert.ToDateTime(this.mtbFechaNacimiento.Text);

                }
                    
                    /* PARA LLAMAR AL FORM DE ALTA USUARIO

                DialogResult DR = (MessageBox.Show("¿Desea crear una cuenta de usuario?", "Cancelar", MessageBoxButtons.YesNo));
                if (DR == DialogResult.Yes) 
                {
                    UsuarioDesktop UD = new UsuarioDesktop(AplicationForm.ModoForm.Alta);
                    UD.Text = "Alta usuario";
                    UD.ShowDialog();
                }
                else this.Close();

                }
           */
                else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                    this.PersonaActual.ID = Convert.ToInt32(this.txtID.Text);
                    this.PersonaActual.Direccion = this.txtDireccion.Text;
                    this.PersonaActual.Nombre = this.txtNombre.Text;
                    this.PersonaActual.Apellido = this.txtApellido.Text;
                    this.PersonaActual.Legajo = Convert.ToInt32(txtLegajo.Text);
                    this.PersonaActual.IDPlan = Convert.ToInt32(this.cbIDPlan.SelectedValue);
                    this.PersonaActual.Telefono = this.mtbTelefono.Text;
                    this.PersonaActual.Email = this.txtEmail.Text;
                    this.PersonaActual.TiposPersona = Convert.ToInt32(this.txtTipoPersona.Text);
                    this.PersonaActual.FechaNacimiento = Convert.ToDateTime(this.mtbFechaNacimiento.Text);
                }
            }

        public override void GuardarCambios() 
            {
            MapearADatos();
            PersonasLogic PL = new PersonasLogic();
            PL.Save(PersonaActual);
            }

         public override bool Validar()
         {
             string mensaje = "";
             bool ok = true;

              foreach(Control c in this.Controls)
              {
                  if ((c is TextBox || c is ComboBox) && (c.Tag.ToString() != "ID") && (!Util.Util.IsComplete(c.Text))) mensaje += " - " + c.Tag.ToString() + "\n";
              }

            if (!(mtbFechaNacimiento.MaskFull || mtbTelefono.MaskFull))
            {
              mensaje = "Fecha de nacimiento y/o telefono estan vacios.\n" + mensaje;
              ok=false;
            }

          /*
          if (!Util.Util.IsDate(this.mtbFechaNacimiento.Text)) 
          {
            mensaje += "La fecha de nacimiento ingresada no es valida.\n";

              ok = false;
          }
          */

          //Para validar los digitos ingresados correspondan a una fecha 

          mtbFechaNacimiento.ValidatingType = typeof(System.DateTime);
          mtbFechaNacimiento.TypeValidationCompleted += new TypeValidationEventHandler(mtbFechaNacimiento_TypeValidationCompleted);
          mtbFechaNacimiento.KeyDown += new KeyEventHandler(mtbFechaNacimiento_KeyDown);

          if (!string.IsNullOrEmpty(mensaje))
          {
              mensaje = "Por favor complete los siguientes campos:\n" + mensaje;
              ok = false;
          }
          
          if ((!string.IsNullOrWhiteSpace(this.txtEmail.Text)) && (!Util.Util.IsValidEmail(this.txtEmail.Text)))
          {
              mensaje += "El email ingresado no es válido.\n";
              ok = false;
          }
          
          if (!string.IsNullOrEmpty(mensaje)) Notificar(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
          return ok;
      }
       
        public new  void Notificar(string titulo,string mensaje,MessageBoxButtons botones,MessageBoxIcon icono)
            {
            MessageBox.Show(titulo,mensaje, botones, icono);
            }

        public new void Notificar( string mensaje, MessageBoxButtons botones, MessageBoxIcon icono )
            {
            this.Notificar(this.Text, mensaje, botones, icono);
            }

        public PersonaDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public PersonaDesktop(int ID, ModoForm modo): this()
            {
            this.Modo = modo;
            PersonasLogic PL = new PersonasLogic();
            PersonaActual = PL.GetOne(ID);
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
            DialogResult DR = (MessageBox.Show("Seguro que desea cancelar el proceso?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (DR == DialogResult.Yes) this.Close();      
        }

        private void PersonaDesktop_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mARTI_tp2_netDataSet.planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter1.Fill(this.mARTI_tp2_netDataSet.planes);
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter.Fill(this.tp2_netDataSet.planes);
        }

        private void mtbFechaNacimiento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                ttFechaNacimiento.ToolTipTitle = "Dato invalido";
                ttFechaNacimiento.Show("Ingrese la fecha en formato un formato valido (DD/MM/AAAA)", mtbFechaNacimiento);
            }

        }
        private void mtbFechaNacimiento_KeyDown(object sender, KeyEventArgs e)
        {
            ttFechaNacimiento.Hide(mtbFechaNacimiento);
        }
    }
}
