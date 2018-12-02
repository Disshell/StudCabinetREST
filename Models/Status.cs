using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class Status
    {
        public Status()
        {
            ApplicationMainInfo = new HashSet<ApplicationMainInfo>();
        }

        public int IdStatus { get; set; }
        public string Name { get; set; }

        public ICollection<ApplicationMainInfo> ApplicationMainInfo { get; set; }
    }
}
