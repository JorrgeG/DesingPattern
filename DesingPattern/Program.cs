using System;

namespace DesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = Singleton.Log.Instance;
            log.Save("a");
        }
    }
}
