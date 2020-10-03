using System;
using System.Collections.Generic;
using System.Text;

namespace eLearning.Domain
{
    public class Notification : BaseClass
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateOfPublication { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
