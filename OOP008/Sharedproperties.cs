using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP008
{
    internal class SharedProperties : GetPlayer
    {
        public string Division { get; set; }
        public string DivisionId { get; set; }

        public string Country { get; set; }
        public string CountryId { get; set; }

    }
}
