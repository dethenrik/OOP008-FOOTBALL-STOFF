using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP008
{
    internal class GetTeam : SharedProperties
    {
        public string TeamName { get; set; }
        public int TeamId { get; set; }
        public string TeamCity { get; set; }
        public string TeamSponsor { get; set; }
    }
}
