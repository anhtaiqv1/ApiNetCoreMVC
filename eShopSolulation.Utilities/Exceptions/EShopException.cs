using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolulation.Utilities.Exceptions
{
    public class EShopException:Exception
    {
        public EShopException() 
        { 
        }
        public EShopException(string message)
            : base(message)
        {

        }
        public EShopException(string message, Exception innerException) : base(message, innerException)
        {

        }
       
    }
}
