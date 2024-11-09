using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses
{
    public class LoginResponses
    {
        public string Token { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
    }

}
