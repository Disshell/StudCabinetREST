using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class Application
    {
        public int ApplicationId { get; set; }
        public int ApplicationMainInfoId { get; set; }
        public int FacultyId { get; set; }
        public int DirectionId { get; set; }
        public int? SpecializationId { get; set; }

        public Direction Direction { get; set; }
        public Faculty Faculty { get; set; }
        public Specialization Specialization { get; set; }
        public ApplicationMainInfo ApplicationMainInfo { get; set; }
    }
}
