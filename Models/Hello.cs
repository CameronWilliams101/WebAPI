using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Hello
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Hello objAsPart = obj as Hello;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public bool Equals(Hello other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }
    }
}
