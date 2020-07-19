using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Evaluación.Clases
{
	class ProfesoresPorContrato
	{
		private string datospersonales;

		public string Datospersonales
		{
			get { return datospersonales; }
			set { datospersonales = value; }
		}

		private int horasdetrabajo;

		public int Horasdetrabajo
		{
			get { return horasdetrabajo; }
			set { horasdetrabajo = value; }
		}

		private int precioxhora;

		public int Precioxhora
		{
			get { return precioxhora; }
			set { precioxhora = value; }
		}

	}
}
