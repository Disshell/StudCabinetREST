using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public class ApplicationMainInfo
    {
        public string authId; 
        public ApplicationMainInfo()
        {
            Applications = new HashSet<Application>();
            Educations = new HashSet<Education>();
            Exams = new HashSet<Exam>();
            Privileges = new HashSet<Privilege>();
            Rewards = new HashSet<Reward>();
        }

        public int ApplicationMainInfoId { get; set; }
        public int PassportId { get; set; }
        public string Citizenship { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string MiddleName { get; set; }
        public string DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Birthplace { get; set; }
        public string Phone { get; set; }
        public string PhoneHome { get; set; }
        public string Email { get; set; }
        public string AddressPasport { get; set; }
        public string AddressFact { get; set; }
        public bool NeedOfHostel { get; set; }
        public string Language { get; set; }
        public string Status {get; set;}
        public DateTime? DateOfApplication { get; set; }

        public Passport Passport { get; set; }
        public Military Military {get; set;}
        public ICollection<Application> Applications { get; set; }
        public ICollection<Education> Educations { get; set; }
        public ICollection<Exam> Exams { get; set; }
        public ICollection<Privilege> Privileges { get; set; }
        public ICollection<Reward> Rewards { get; set; }
    }
}
