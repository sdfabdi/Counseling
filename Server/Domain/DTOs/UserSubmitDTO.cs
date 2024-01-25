using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class UserSubmitDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public string UserGender { get; set; }
    }
}