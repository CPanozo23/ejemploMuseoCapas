using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Controller
{
    public class ControllerGuia
    {
        //Lista privada
        private static List<Guia> listadoGuias = new List<Guia>();

        //Inicializador
        public static void InicializarGuias()
        {
            listadoGuias.Add(new Guia(1, "mgonzales", "Marcela", "Gonzalez", "12345"));
            listadoGuias.Add(new Guia(2, "opereira", "Octavio", "Pereira", "54321"));
        }

        //Obtener listado
        public static List<Guia> ObtenerGuias()
        {
            return listadoGuias;
        }
    }
}
