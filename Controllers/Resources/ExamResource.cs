namespace StudCabinetREST.Controllers.Resources
{
    public class ExamResource
    {
        public int IdExams { get; set; }
        public int ObjectId { get; set; }

        public int? Point { get; set; }

        public ObjectResource Object { get; set; }

    }
}