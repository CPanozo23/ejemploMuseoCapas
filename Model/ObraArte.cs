using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ObraArte
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Autor { get; set; }
        public String Fecha { get; set; }
        public String Descripcion { get; set; }

        public ObraArte(int id, string nombre, string autor, string fecha, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Autor = autor;
            Fecha = fecha;
            Descripcion = descripcion;
        }
    }
}
