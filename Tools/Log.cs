using System;
using System.IO;

namespace Tools
{
    //sealed: no se va a poder heredar
    public sealed class Log 
    {
        private static Log _instance = null;
        private string _path;
        //Para poder evitar que se cree una instancia null cuando trabajanos con hilos, usamos lo siguiente
        private static object _protect = new object();

        public static Log GetInstance(string path)
        {
            //la palabra reservada lock(), va a evitar que otro hilo trabaje en el fujo mientras el hilo actual este en el.
            //va a dejar el siguiente hilo en espera, mientras termina el hilo actual.
            lock (_protect)
            {
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }
            return _instance;
        }

        private Log(string path) 
        {
            _path = path;
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
