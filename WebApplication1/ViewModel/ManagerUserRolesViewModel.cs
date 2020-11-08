using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModel
{
    public class ManagerUserRolesViewModel
    {
        public string RoleId { get; set; }
        public string Role { get; set; }

        //Lista de checkbox de roles (para tildarlos)
        public bool IsSelected { get; set; }
    }
}
