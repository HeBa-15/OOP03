using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Casting_Operators_Overloading
{
    // Model : is a class that represents a data in a Table
    class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid SecurityStmp { get; set; }

    }
}
