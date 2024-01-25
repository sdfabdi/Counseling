using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTOs;

namespace Domain.DTOs
{
    public class TestReadDTO
    {
        public int TestID { get; set; }
        public string Question { get; set; }
        public int Number { get; set;}
        public int CategoryID { get; set; }
        public virtual IEnumerable<AnswerReadDTO> Answers { get; set; }
        public virtual CategoryReadDTO Category { get; set; }
    }
}
