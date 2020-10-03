using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eLearning.Domain
{
    public class Student : BaseClass
    {
        public Student()
        {
            Subjects = new List<StudentSubject>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        /// Employee's full name - not mapped - calculated
        public string FullName { get { return FirstName + " " + LastName; } }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public string AboutMe { get; set; }
        public virtual Section Section { get; set; }
        public virtual IList<StudentSubject> Subjects { get; set; }
    }
}
