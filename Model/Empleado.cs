using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Empleado
    {
        public int Id { get; set; }
        public String Usuario { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Password { get; set; }
    }
}
