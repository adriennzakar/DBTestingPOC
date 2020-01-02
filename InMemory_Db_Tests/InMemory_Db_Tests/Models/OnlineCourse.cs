using System;
using System.Collections.Generic;

namespace InMemory_Db_Tests.Models
{
    public partial class OnlineCourse
    {
        public int CourseId { get; set; }
        public string Url { get; set; }

        public virtual Course Course { get; set; }
    }
}
