using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public ICollection<Test> Tests { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
