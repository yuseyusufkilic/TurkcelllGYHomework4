using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Models
{
    public class Sponsor
    {
        public int SponsorId { get; set; }
        public string Name { get; set; }
        public List<FootballerSponsor> FootballerSponsors { get; set; }
    }
}
