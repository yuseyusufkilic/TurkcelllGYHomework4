using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Models
{
     public class Footballer
    {
        public int FootballerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Team Team { get; set; }
        public int TeamId { get; set; }
        

        public List<FootballerSponsor> FootballerSponsors{ get; set; }

    }
}
