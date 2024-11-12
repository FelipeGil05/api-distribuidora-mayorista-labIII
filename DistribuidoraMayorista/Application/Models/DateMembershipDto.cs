using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class DateMembershipDto
    {
        public int MembershipId { get; set; }
        public decimal MembershipPrice { get; set; }
        public required string MembershipTitle { get; set; }
        public required string MembershipDescription { get; set; }
    }
}
