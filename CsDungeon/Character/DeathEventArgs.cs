using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDungeon
{
    class DeathEventArgs : EventArgs
    {
        public string DeathCause { get; set; }
        public MESSAGE_TYPE MessageImportantType { get; set; }
    }
}
