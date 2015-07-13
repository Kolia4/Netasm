using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Netasm.i8086;

namespace Netasm.Statements.Commands
{
    public class Instruction : Command
    {
        private readonly Mnemonics mnemonic;
        private readonly Operand[] operands;

        public Instruction(Mnemonics mnemonic, Operand[] operands)
        {
            this.mnemonic = mnemonic;
            this.operands = operands;
        }
    }
}
