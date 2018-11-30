using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            Application = new HashSet<Application>();
        }

        public int IdFaculty { get; set; }
        public string Name { get; set; }

        public ICollection<Application> Application { get; set; }
    }
}
