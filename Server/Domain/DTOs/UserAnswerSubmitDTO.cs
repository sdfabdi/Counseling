using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class UserAnswerSubmitDTO
    {
        public int UserAnswerID { get; set;}
        public string UserAnswerTitle { get; set; }
        public int QuestionNumber { get; set;}
        public int CategoryID { get; set; }


    }
}
