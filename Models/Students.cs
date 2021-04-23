using System;
using System.Collections.Generic;
using System.Text;

namespace TestUwp.Models
{
    public class Students
    {
        public long StudentsID { get; set; }

        public string StudentsName { get; set; }

        public string StudentsCity { get; set; }

        public string ShortDescription => $"Student ID: {StudentsID} - {StudentsName}";
    }
}
