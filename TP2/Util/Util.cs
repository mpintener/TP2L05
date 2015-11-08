using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
   public static class Util
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsComplete(string txt)
        {
            if (txt.Equals(string.Empty) || string.IsNullOrWhiteSpace(txt)) return false;
            return true;
        }
       
       /*
        public static bool IsDate(string fechaentrante)
        {
            bool isDate = true;

            try
            {
                DateTime fecha = DateTime.ParseExact(fechaentrante, "DD-MM-YYYY", null);
            }

            catch (Exception Ex)
            {
                isDate = false;

                Exception ExcepcionManejada = new Exception("El formato para la fecha no es valido\n Ingrese la fecha como DD/MM/AAAA", Ex);
               
                throw ExcepcionManejada;

            }
            return isDate;
        }
       
       */
    }
}
