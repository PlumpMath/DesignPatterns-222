using System;
using System.Collections.Generic;

namespace RepositoryPattern
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ProjectTypeId { get; set; }
        public virtual ProjectType ProjectType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
