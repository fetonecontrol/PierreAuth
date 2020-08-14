using System.Collections.Generic;

namespace PierreAuth.Models
{
  public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<FlavorTreat>();
        }

        public int TreatId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<FlavorTreat> Flavors { get; set; }
    }
}