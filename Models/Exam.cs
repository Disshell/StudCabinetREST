using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        public int ApplicationMainInfoId { get; set; }
        public int ObjectId { get; set; }

        public int? Point { get; set; }

        public ApplicationMainInfo ApplicationMainInfo { get; set; }
        public Object Object { get; set; }
    }
}
