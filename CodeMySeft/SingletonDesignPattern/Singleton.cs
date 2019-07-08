using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Singleton
    {
        static int instanceCounter = 0;
        // static variable instance
        private static Singleton instance = null;
        // static object lock object
        private static readonly object lockObject = new object();

        private Singleton()
        {
            instanceCounter++;
            Console.WriteLine("Instance created: " + instanceCounter);
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("Message " + message);
        }

        /// <summary>
        /// Create property Instance only read to access class Singleton
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock(lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
