using System;
using System.Collections.Generic;
using System.Text;

namespace eLearning.Domain
{
    public class Section : BaseClass
    {
        public Section()
        {
            Students = new List<Student>();
        }

        public string Name { get; set; }
        public virtual School School { get; set; }
        public virtual IList<Student> Students { get; set; }
    }
}
