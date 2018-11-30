using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public partial class Specialization
    {
        public Specialization()
        {
            Application = new HashSet<Application>();
        }

        public int IdSpecialization { get; set; }
        public string Name { get; set; }

        public ICollection<Application> Application { get; set; }
    }
}
