using System;
using System.Collections.Generic;

namespace StudCabinetREST.Models
{
    public partial class Object
    {
        public Object()
        {
            Exam = new HashSet<Exam>();
        }

        public int ObjectId { get; set; }
        public string Name { get; set; }

        public ICollection<Exam> Exam { get; set; }
    }
}
