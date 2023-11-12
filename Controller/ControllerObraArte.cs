using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Controller
{
    public class ControllerObraArte
    {
        private static List<ObraArte> listadoObras = new List<ObraArte>();
        public static void InicializarObras() { 
            listadoObras.Add(new ObraArte(1, "La Mona Lisa", "Leonardo da Vinci", "1503 - 1506", "Retrato enigmático de una mujer"));
            listadoObras.Add(new ObraArte(2, "La noche estrellada", "Vincent van Gogh", "1889", "Cielo nocturno turbulento sobre un pueblo"));
            listadoObras.Add(new ObraArte(3, "La persistencia de la memoria", "Salvador Dalí", "1931", "Relojes derretidos en un paisaje desértico"));
            listadoObras.Add(new ObraArte(4, "La creación de Adán", "Miguel Ángel", "1512", "Representación de Dios dando vida a Adán"));
    
        }

        public static List<ObraArte> ObtenerObras()
        {
            return listadoObras;
        }
    }
}
