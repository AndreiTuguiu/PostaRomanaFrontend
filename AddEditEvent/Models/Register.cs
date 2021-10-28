using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Register
    {
        public int Id { get; set; }
        public string TokenStatus { get; set; }
        public DateTime ValidTo { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }

        public virtual User User { get; set; }
    }
}
