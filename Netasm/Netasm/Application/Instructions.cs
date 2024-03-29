﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Netasm.i8086;
using Netasm.Statements;
using Netasm.Statements.Commands;

namespace Netasm
{
    public abstract partial class Application
    {
        public void Mov(params Operand[] operands)
        {
            currentMethod.commands.Add(new Instruction(Mnemonics.Mov, operands));
        }
    }
}
