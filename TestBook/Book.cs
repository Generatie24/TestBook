using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBook
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString() // override ToString() om de naam van het boek te tonen in de listbox
        {
            return $"{ID} {Name}";
        }
    }
}
