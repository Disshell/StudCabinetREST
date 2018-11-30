using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public partial class Exam
    {
        public int IdExams { get; set; }
        public int IdStudentInfo { get; set; }
        public int ObjectId { get; set; }
        public string Examcol { get; set; }
        public int? Point { get; set; }

        public ApplicationMainInfo IdStudentInfoNavigation { get; set; }
        public Object Object { get; set; }
    }
}
