using System;
using System.Collections.Generic;

namespace StudCabinetREST.Controllers.Resources
{
    public class ApplicationMainInfoResource
    {
        public ApplicationMainInfoResource()
        {
            Applications = new HashSet<ApplicationResource>();
            Educations = new HashSet<EducationResource>();
            Exams = new HashSet<ExamResource>();
            Privileges = new HashSet<PrivilegeResource>();
            Rewards = new HashSet<RewardResource>();
        }

        public string AuthId { get; set; }
        public int ApplicationMainInfoId { get; set; }
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
        public string Status { get; set; }
        public string DateOfApplication { get; set; }

        public PassportResource Passport { get; set; }
        public MilitaryResource Military {get; set;}
        public ICollection<ApplicationResource> Applications { get; set; }
        public ICollection<EducationResource> Educations { get; set; }
        public ICollection<ExamResource> Exams { get; set; }
        public ICollection<PrivilegeResource> Privileges { get; set; }
        public ICollection<RewardResource> Rewards { get; set; }

    }
}
