using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Models
{
    public class Team
    {
        
        public int TeamId { get; set; }

        
        public string Name { get; set; }
        public List<Footballer> Footballer { get; set; }






    }
}
