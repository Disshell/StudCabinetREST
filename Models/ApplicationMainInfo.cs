using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public partial class ApplicationMainInfo
    {
        public ApplicationMainInfo()
        {
            Application = new HashSet<Application>();
            Education = new HashSet<Education>();
            Exam = new HashSet<Exam>();
            Privileges = new HashSet<Privileges>();
            Reward = new HashSet<Reward>();
        }

        public int IdStudentInfo { get; set; }
        public int IdPassport { get; set; }
        public int StatusIdStatus { get; set; }
        public string Citizenship { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string StudentInfocol { get; set; }
        public string MiddleName { get; set; }
        public string DateOfBirth { get; set; }
        public string StudentInfocol1 { get; set; }
        public byte? Gender { get; set; }
        public string Birthplace { get; set; }
        public string Phone { get; set; }
        public string PhoneHome { get; set; }
        public string Email { get; set; }
        public string AddressPasport { get; set; }
        public string AddressFact { get; set; }
        public byte? NeedOfHostel { get; set; }
        public string Language { get; set; }
        public DateTime? DateOfApplication { get; set; }

        public Passport IdPassportNavigation { get; set; }
        public Status StatusIdStatusNavigation { get; set; }
        public ICollection<Application> Application { get; set; }
        public ICollection<Education> Education { get; set; }
        public ICollection<Exam> Exam { get; set; }
        public ICollection<Privileges> Privileges { get; set; }
        public ICollection<Reward> Reward { get; set; }
    }
}
