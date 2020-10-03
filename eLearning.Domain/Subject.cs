using System;
using System.Collections.Generic;
using System.Text;

namespace eLearning.Domain
{
    public class Subject : BaseClass
    {
        public Subject()
        {
            Students = new List<StudentSubject>();
        }

        public string Name { get; set; }
        public int SectionNumber { get; set; }
        public string Document { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual IList<StudentSubject> Students { get; set; }
        public virtual IList<Notification> Notification { get; set; }
    }
}
