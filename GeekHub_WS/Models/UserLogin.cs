using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekHub_WS.Models
{
    public class UserLogin
    {
        public string Name { get; set; }
        public string LastName{ get; set; }
        public string Email{ get; set; }
        public int RoleId{ get; set; }
        public int UsuarioId { get; set; }
    }
}