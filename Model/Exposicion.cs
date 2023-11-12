using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Exposicion
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String FechaInicio { get; set; }
        public String FechaTermino { get; set; }
        public List<ObraArte> ListadoObras { get; set; }

        public Exposicion(int id, string nombre, string fechaInicio, string fechaTermino, List<ObraArte> listadoObras)
        {
            Id = id;
            Nombre = nombre;
            FechaInicio = fechaInicio;
            FechaTermino = fechaTermino;
            ListadoObras = listadoObras;
        }
    }
}
