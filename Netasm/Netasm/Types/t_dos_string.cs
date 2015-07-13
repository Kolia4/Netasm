using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Netasm.Types
{
    public class t_dos_string : BaseType
    {
        private readonly string message;

        public t_dos_string(string message)
        {
            this.message = message + "$";
        }
    }
}
