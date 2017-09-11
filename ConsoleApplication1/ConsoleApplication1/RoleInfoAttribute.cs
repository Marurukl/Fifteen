using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class RoleInfoAttribute : System.Attribute
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public RoleInfoAttribute()
        { }

        public RoleInfoAttribute(string name)
        {
            Name = name;
        }
    }
    
}
