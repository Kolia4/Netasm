using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Netasm.Statements.Operands
{
    public abstract class Register : Operand { }

    public abstract class Register8 : Register { }

    public abstract class Register16 : Register { }

    public class AX : Register16 { }
}
