using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonRetail.Infrastructure.Exceptions
{
    public class CoreExceptions : Exception
    {
        internal CoreExceptions(string businessMessage) :base(businessMessage)
        {

        }

        internal CoreExceptions(string message,Exception innerException) : base(message,innerException)
        {

        }

    }
}
