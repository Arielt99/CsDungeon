using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    class WorkInProgressException : Exception
    {
        public String OriginClassProp { get; set; }
        public String OriginFunctionProp { get; set; }
    }
}
