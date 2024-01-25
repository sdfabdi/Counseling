using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Model
{
    public class Test
    {
        public int TestID { get; set; }
        public string Question { get; set; }
        public int Number { get; set;}
        public int CategoryID { get; set; }
        public virtual IEnumerable<Answer> Answers { get; set; }
        public virtual Category Category { get; set; }
    }
}
