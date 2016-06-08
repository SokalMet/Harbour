using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harbour
{
    class ErrorCounter
    {
        public delegate void Error();

        public event Error onError;

        public void Count()
        {            
                onError();
        } 
    }
}
