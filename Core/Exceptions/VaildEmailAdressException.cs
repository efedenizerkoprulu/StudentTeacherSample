using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    public class VaildEmailAdressException:Exception
    {
        public VaildEmailAdressException(string message):base(message)
        {

        }
    }
}
