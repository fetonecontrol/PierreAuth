using System.Collections.Generic;

namespace PierreAuth.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<FlavorTreat>();
        }

        public int FlavorId { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser User { get; set; } //new line

        public ICollection<FlavorTreat> Treats { get;}
    }
}