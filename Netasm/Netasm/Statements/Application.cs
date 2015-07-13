using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Netasm.Statements
{
    public class Application
    {
        public readonly string name;
        public readonly List<Field> fields = new List<Field>();
        public readonly List<Method> methods = new List<Method>();

        public Application(string name)
        {
            this.name = name;
        }
    }
}
