using System;
using System.Collections.Generic;
using System.Globalization;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet.Models
{
    internal class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth {get ; set ;}
        public string  Gender { get; set; }
    }
}
