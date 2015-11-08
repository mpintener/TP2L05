using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
    {
    static class Program
        {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Inicio());
            //Application.Run(new Especialidades()); //OK
            Application.Run(new Planes()); //OK
            Application.Run(new Personas()); //OK //cuando se da aceptar, preguntar si queire crearse usuario, y de ahi abrir un formulario de usuarioDesktop
            //Application.Run(new Materias()); //OK
            Application.Run(new Usuarios());           
            //Application.Run(new AlumnosInscripciones());
            //Application.Run(new Modulos());
            //Application.Run(new ModulosUsuarios());
            //Application.Run(new Comisiones());
            //Application.Run(new Cursos());
            //Application.Run(new DocentesCursos());
            }
        }
    }
