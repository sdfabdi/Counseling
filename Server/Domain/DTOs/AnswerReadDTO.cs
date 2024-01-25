using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class AnswerReadDTO
    {
        public int AnswerID { get; set; }
        public string Title { get; set; }
        public int? Score { get; set; }
        public bool IsPhoto { get; set; }
        public int? CategoryID { get; set; }
        public string Value { get; set; }
        public virtual CategoryReadDTO Category { get; set; }
    }
}
