using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class Application
    {
        public int IdApplication { get; set; }
        public int IdApplicationMainInfo { get; set; }
        public int IdFaculty { get; set; }
        public int IdDirection { get; set; }
        public int? IdSpecialization { get; set; }

        public Direction IdDirectionNavigation { get; set; }
        public Faculty IdFacultyNavigation { get; set; }
        public Specialization IdSpecializationNavigation { get; set; }
        public ApplicationMainInfo IdApplicationMainInfoNavigation { get; set; }
    }
}
