using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class EventXuser
    {
        public int EventId { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }

        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
    }
}
