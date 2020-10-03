using System;
using System.Collections.Generic;
using System.Text;

namespace eLearning.Domain
{
    public class School : BaseClass
    {
        public School()
        {
            Sections = new List<Section>();
        }
        public string Name { get; set; }
        public virtual IList<Section> Sections { get; set; }
    }
}
