using System;
using System.Collections.Generic;
using System.Text;

namespace TestUwp.Models
{
    public class Assignature
    {
        public long AssignatureID { get; set; }

        public string AssignatureName { get; set; }

        public string Status { get; set; }

        public ICollection<Students> Students { get; set; }

        public override string ToString()
        {
            return $"{AssignatureName} {Status}";
        }

        public string ShortDescription => $"Assignature ID: {AssignatureID}";
    }
}
