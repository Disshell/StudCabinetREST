using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public partial class Direction
    {
        public Direction()
        {
            Application = new HashSet<Application>();
        }

        public int IdDirection { get; set; }
        public string Name { get; set; }

        public ICollection<Application> Application { get; set; }
    }
}
