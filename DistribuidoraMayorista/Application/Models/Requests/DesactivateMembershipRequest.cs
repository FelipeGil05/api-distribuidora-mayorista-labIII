﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class DesactivateMembershipRequest
    {
        public int UserId { get; set; }
        public DateTime EndDate { get; set; }
    }
}
