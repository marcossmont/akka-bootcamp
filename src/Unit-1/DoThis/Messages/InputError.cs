using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTail.Messages
{
    public class InputError : IInputValidation
    {
        public InputError(string reason)
        {
            Reason = reason;
        }

        public string Reason { get; }
    }
}
