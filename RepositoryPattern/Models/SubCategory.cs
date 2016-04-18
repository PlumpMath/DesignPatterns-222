using System;

namespace RepositoryPattern
{
    public class SubCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Name { get; set; }
        public int SeverityId { get; set; }
        public virtual Severity Severity { get; set; }
    }
}