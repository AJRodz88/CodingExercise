using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLibrary
{
    public class ReturnAboveBelow
    {
        public ReturnAboveBelow()
        {
            above = 0;
            below = 0;
        }

        private int above;
        public int Above { get { return above; } set { above = value; } }

        private int below;
        public int Below { get { return below; } set { below = value; } }
    }
}
