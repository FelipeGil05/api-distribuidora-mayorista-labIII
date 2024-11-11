using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DateMembership
    {
        [Key]
        public decimal MembershipPrice { get; set; }
        public required string MembershipTitle { get; set; }
        public required string MembershipDescription { get; set; }
    }
}
