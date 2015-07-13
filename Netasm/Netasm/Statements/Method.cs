using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Netasm.Statements
{
    public class Method
    {
        public readonly string name;
        public readonly List<Command> commands = new List<Command>();

        public Method(string name)
        {
            this.name = name;
        }
    }
}
