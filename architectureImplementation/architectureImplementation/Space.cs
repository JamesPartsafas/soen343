using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architectureImplementation
{
    // Holds information about a location
    class Space
    {
        private string streetName;
        private int streetNumber;

        public Space(string streetName, int streetNumber)
        {
            this.streetName = streetName;
            this.streetNumber = streetNumber;
        }
    }
}
