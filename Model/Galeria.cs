using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Galeria
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public List<Exposicion> ListadoExposiciones { get; set; }
        public Galeria(int id, string nombre, List<Exposicion> listadoExposiciones)
        {
            Id = id;
            Nombre = nombre;
            ListadoExposiciones = listadoExposiciones;
        }
    }
}
