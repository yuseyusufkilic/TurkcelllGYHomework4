using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Models
{
    public class FootballerSponsor

    {
        public int FootballerId { get; set; }
        public Footballer Footballer { get; set; }
        public int SponsorId { get; set; }
        public Sponsor Sponsor { get; set; }
    }
}
