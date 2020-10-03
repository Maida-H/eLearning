using System;
using System.Collections.Generic;
using System.Text;

namespace eLearning.Domain
{
    public class StudentSubject : BaseClass
    {
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual IList<Grade> Grades { get; set; }
        public int FinalGrade { get; set; }
    }
}
