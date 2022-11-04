using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundC
{
    public class Customer
    {
        public int Id;
        public string? Name;
        public List<Order> Orders;

        public Customer() // Parameterless default constructor
        {
            Orders = new List<Order>();
        }
        public Customer(int id) // overload constructor 1 param
            : this()  // <- We call the param-less constructor(1). by this approach we can overload multiply lists without repeating code!
        {
            this.Id = id;
        }
        public Customer(int id, string? name) // overload constructor 2 params
            : this(id) // <--- this() Method
        {
            //this.Id = id;   // We don't need this anymore, we can use it from the 2nd constructor by this() method!
            this.Name = name;
        }
    }
}
