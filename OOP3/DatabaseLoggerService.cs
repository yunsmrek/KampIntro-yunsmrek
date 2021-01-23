using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService//interface içinde sadece imza metotlar olur 
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }
    
}
