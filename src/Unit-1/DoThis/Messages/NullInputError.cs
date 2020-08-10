using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTail.Messages
{
    public class NullInputError : InputError
    {
        public NullInputError(string reason) : base(reason)
        {
        }
    }
}
