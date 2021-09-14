using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.CreationalDesignPatterns.Singleton
{
    public sealed class Singleton
    {
        private static int _counter = 0;
        private static Singleton _instance;
        private static readonly object Instancelock = new object();
        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                    lock (Instancelock)
                    {
                        _instance ??= new Singleton();
                    }
                return _instance;
            }
        }

        private Singleton()
        {
            _counter++;
            Console.WriteLine("Counter Value " + _counter);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
