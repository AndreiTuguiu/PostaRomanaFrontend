using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Location
    {
        public Location()
        {
            Events = new HashSet<Event>();
        }

        public int Id { get; set; }
        public int? CountryId { get; set; }
        public int? CountyId { get; set; }
        public int? CityId { get; set; }
        public string AddressLine { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
