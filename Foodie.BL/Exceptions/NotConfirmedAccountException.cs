using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodie.BL.Exceptions
{
    public class NotConfirmedAccountException : Exception
    {
        public NotConfirmedAccountException()
        {
        }

        public NotConfirmedAccountException(string message)
            : base(message)
        {
        }

        public NotConfirmedAccountException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
