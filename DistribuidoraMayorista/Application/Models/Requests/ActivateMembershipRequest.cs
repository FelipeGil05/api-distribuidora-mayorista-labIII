using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class ActivateMembershipRequest
    {
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
    }
}
