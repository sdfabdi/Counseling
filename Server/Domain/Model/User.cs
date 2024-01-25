using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public int UserAge { get; set; }
        
        public string UserGender { get; set; }
    }
}