using System;

namespace StudCabinetREST.Models
{
    public class Military
    {
        public int MilitaryId { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public int ApplicationMainInfoId{ get; set; }

        public ApplicationMainInfo ApplicationMainInfo { get; set; }

    }
}