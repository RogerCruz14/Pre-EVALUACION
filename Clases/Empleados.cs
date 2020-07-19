using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Evaluación.Clases
{
    class Empleados
    {
        private String añodeincorporacion;

        public String Añodeincorporacion
        {
            get { return añodeincorporacion; }
            set { añodeincorporacion = value; }
        }

        private String facultad;

        public String Facultad
        {
            get { return facultad; }
            set { facultad = value; }
        }

        private String numerodespacho;

        public String Numerodespacho
        {
            get { return numerodespacho; }
            set { numerodespacho = value; }
        }
    }
}
