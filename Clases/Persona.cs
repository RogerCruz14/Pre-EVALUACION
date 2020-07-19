using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Evaluación.Clases
{
    class Persona
    {
        private String nombre;
        public String Nombre
        {
            get { return nombre;  }
            set { nombre = value; }
        }

        private String apellido;

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private String numero;

        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private String identificasion;
        public String Identificasion
        {
            get { return identificasion; }
            set { identificasion = value; }
        }

        private String estadocivil;
        public String Estadocivil
        {
            get { return estadocivil; }
            set { estadocivil = value; }
        }
    }
}
