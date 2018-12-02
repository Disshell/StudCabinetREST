using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class Privilege
    {
        public int IdPrivilege { get; set; }
        public int IdApplicationMainInfo { get; set; }
        public string Name { get; set; }

        public ApplicationMainInfo IdApplicationMainInfoNavigation { get; set; }
    }
}
