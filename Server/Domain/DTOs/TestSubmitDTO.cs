using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class TestSubmitDTO
    {
        public int TestID { get; set; }
        public string Question { get; set; }
        public int Number { get; set;}
        public int CategoryID { get; set; }
    }
}
