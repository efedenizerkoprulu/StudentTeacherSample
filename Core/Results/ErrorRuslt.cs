using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    public class ErrorRuslt:Result
    {
        public ErrorRuslt(string message):base(false,message)
        {

        }
        public ErrorRuslt():base(false)
        {

        }
    }
}
