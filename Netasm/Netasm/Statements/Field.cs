using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Netasm.Statements
{
    public class Field
    {
        public readonly string name;
        public readonly BaseType type;

        public Field(string name, BaseType type)
        {
            this.name = name;
            this.type = type;
        }
    }
}
