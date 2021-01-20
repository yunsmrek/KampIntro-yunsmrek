using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product//entities=varlık
                 // bu tip classlarda sadece özellik olur
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }//referans anahtarlarını 2. sıraya yazarız.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        // CRUD create read uptade read


    }
}
