using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class Exam
    {
        public int IdExams { get; set; }
        public int IdApplicationMainInfo { get; set; }
        public int ObjectId { get; set; }

        public int? Point { get; set; }

        public ApplicationMainInfo IdApplicationMainInfoNavigation { get; set; }
        public Object Object { get; set; }
    }
}
