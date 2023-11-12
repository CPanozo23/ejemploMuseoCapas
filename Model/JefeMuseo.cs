using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class JefeMuseo: Empleado
    {
        public JefeMuseo(int id, string usuario, string nombre, string apellido, string password)
        {
            Id = id;
            Usuario = usuario;
            Nombre = nombre;
            Apellido = apellido;
            Password = password;
        }
    }
}
