using System;
using System.Collections.Generic;
using System.Text;

namespace eLearning.Domain
{
    public class Grade : BaseClass
    {
        public int Value { get; set; }
        public virtual StudentSubject StudentSubject { get; set; }
    }
}
