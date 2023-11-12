using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Controller
{
    public class ControllerJefeMuseo
    {

        private static List<JefeMuseo> listadoJefes= new List<JefeMuseo>();

        public static void InicializarJefes() {
            listadoJefes.Add(new JefeMuseo(1, "jperez", "Juan", "Pérez", "12345"));
            listadoJefes.Add(new JefeMuseo(2, "adiaz", "Andrea", "Díaz", "54321"));
        }

        public static List<JefeMuseo> ObtenerJefesMuseo()
        {
            return listadoJefes;
        }
    }
}
