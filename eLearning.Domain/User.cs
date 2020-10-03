using System;
using System.Collections.Generic;
using System.Text;

namespace eLearning.Domain
{
    public class User : BaseClass
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }  // depends if user is admin = 1, professor = 2, student = 3
        public virtual IList<Professor> Professors { get; set; }
        public virtual IList<Student> Students { get; set; }
    }
}
