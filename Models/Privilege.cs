using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class Privilege
    {
        public int PrivilegeId { get; set; }
        public int ApplicationMainInfoId { get; set; }
        public string Name { get; set; }

        public ApplicationMainInfo ApplicationMainInfo { get; set; }
    }
}
