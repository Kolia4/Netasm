using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Netasm;
using Netasm.i8086;
using Netasm.Statements.Operands;
using Netasm.Types;

namespace Tests.Applications
{
    public class Program : Application
    {
        t_dos_string message = new t_dos_string("Hello World!");

        public override void main()
        {
            Mov(new AX(), new AX());
        }
    }
}
