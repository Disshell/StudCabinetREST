﻿using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public partial class InstitutionType
    {
        public InstitutionType()
        {
            Education = new HashSet<Education>();
        }

        public int IdNstitutionType { get; set; }
        public string Name { get; set; }

        public ICollection<Education> Education { get; set; }
    }
}