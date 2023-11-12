using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Controller
{
    public class ControllerGaleria
    {
        private static List<Galeria> listadoGalerias = new List<Galeria>();

        public static void InicializarGalerias()
        {
            //Listado con 1 Galería(con 1 exposición)
            List<Exposicion> listadoExposicionesGaleria = new List<Exposicion>();
            listadoExposicionesGaleria.Add(ControllerExposicion.ObtenerExposiciones()[0]);
            Galeria galeria = new Galeria(1, "Mi Galería", listadoExposicionesGaleria);
            listadoGalerias.Add(galeria);
        }

        public static List<Galeria> ObtenerGalerias()
        {
            return listadoGalerias;
        }
    }
}
