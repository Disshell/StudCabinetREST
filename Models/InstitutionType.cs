using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class InstitutionType
    {
        public InstitutionType()
        {
            Education = new HashSet<Education>();
        }

        public int InstitutionTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Education> Education { get; set; }
    }
}
