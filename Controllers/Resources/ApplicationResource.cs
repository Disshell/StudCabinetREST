namespace StudCabinetREST.Controllers.Resources
{
    public class ApplicationResource
    {
        public int IdApplication { get; set; }
        public int IdFaculty { get; set; }
        public int IdDirection { get; set; }
        public int IdSpecialization { get; set; }

        public DirectionResource IdDirectionNavigation { get; set; }
        public FacultyResources IdFacultyNavigation { get; set; }
        public SpecializationResource IdSpecializationNavigation { get; set; }

    }
}