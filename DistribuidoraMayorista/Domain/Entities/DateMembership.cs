using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DateMembership
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MembershipId { get; set; }
        public decimal MembershipPrice { get; set; }
        public required string MembershipTitle { get; set; }
        public required string MembershipDescription { get; set; }
    }
}
