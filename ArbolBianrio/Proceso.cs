using System;
using System.Collections.Generic;

namespace tpfinal
{

	[Serializable]
	public class Proceso
	{
		public string nombre { get; set; } // String of symbols
       
		public int prioridad { get; set; }

        public int tiempo { get; set; }

        
        public Proceso(string nombre, int tiempo, int prioridad)
		{
			this.prioridad = prioridad;
			this.nombre = nombre;
			this.tiempo = tiempo;
        }



		public override string ToString()
		{
			if (nombre != null)
			{

				return nombre + " Tiempo: " + tiempo+" Prioridad: " + prioridad; ;

			}
			else
			{

				return "";
			}
		}

	}
}