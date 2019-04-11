using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class Passport
    {

        public int PassportId { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
        public string DateOfIssue { get; set; }
        public int ApplicationMainInfoId {get; set;}

        public ApplicationMainInfo ApplicationMainInfo { get; set; }
    }
}
