using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class Passport
    {
        public Passport()
        {
            ApplicationMainInfo = new HashSet<ApplicationMainInfo>();
        }

        public int IdPassport { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
        public DateTime? DateOfIssue { get; set; }

        public ICollection<ApplicationMainInfo> ApplicationMainInfo { get; set; }
    }
}
