using System;
using System.Collections.Generic;
using System.Text;

namespace TestUwp.Models
{
    public class Professor
    {
        public string ProfessorID { get; set; }

        public string ProfessorName { get; set; }

        public string ProfessorLastName { get; set; }

        public string City { get; set; }

        public ICollection<Assignature> Assignatures { get; set; }
    }
}
