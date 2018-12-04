using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class Specialization
    {
        public Specialization()
        {
            Application = new HashSet<Application>();
        }

        public int SpecializationId { get; set; }
        public string Name { get; set; }

        public ICollection<Application> Application { get; set; }
    }
}
