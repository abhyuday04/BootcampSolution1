using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampClassLibrary1
{
    public class Boxer25K:PeristaliticPump
    {
        protected override void InternalStart()
        {
            //Send an "S" command over a COM port
        }
        protected override void InternalStop()
        {
            //Send an "H" command over a COM port
        }

    }
}
