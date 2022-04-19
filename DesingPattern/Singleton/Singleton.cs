using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Singleton
{
    public class Singleton
    {
        //readonly: es solo para lectura, solo se puede leer y no editarlo
        //static: pertenece a la clase y no al objeto
        private readonly static Singleton _instance = new Singleton(); //se crea el objeto una ves se compile el proyecto

        //Creamos el acceso al objeto _instance con la siguiente propiedad o atributo
        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

        //creamos un constructor privado para que no se puedan crear objetos de esta clase
        private Singleton() { }
    }
}
