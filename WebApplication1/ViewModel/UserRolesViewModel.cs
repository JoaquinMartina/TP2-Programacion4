using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModel
{
    public class UserRolesViewModel
    {
        public string UserId { get; set; }
        public string User { get; set; }
        public string Email { get; set; }

        //Lista de posibles roles que puede tener el Usuario
        public List<string> Roles { get; set; }
    }
}
