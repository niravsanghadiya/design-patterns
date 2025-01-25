using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public sealed class DbConnection
    {
        // Static instance
        private static DbConnection connectionInstance;

        private static readonly object lockObject = new object();

        // Private Consctructor
        private DbConnection() { }

        // Static method to return instance
        public static DbConnection GetInstance()
        {
            if(connectionInstance == null)
            {
                lock (lockObject)
                {
                    if (connectionInstance == null)
                    {
                        connectionInstance = new DbConnection();
                    }
                }              
            }
           
            return connectionInstance;
        }

        public void Display()
        {
            Console.WriteLine($"This is a Singleton class");
        }
    }
}
