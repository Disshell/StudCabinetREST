using System;
namespace StudCabinetREST.Controllers.Resources
{
    public class PassportResource
    {
        public int PassportId { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
        public DateTime? DateOfIssue { get; set; }
    }
}
