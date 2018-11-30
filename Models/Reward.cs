using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public partial class Reward
    {
        public int IdAward { get; set; }
        public int IdStudentInfo { get; set; }
        public string Name { get; set; }

        public ApplicationMainInfo IdStudentInfoNavigation { get; set; }
    }
}
