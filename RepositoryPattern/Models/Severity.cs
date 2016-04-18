using System;

namespace RepositoryPattern
{
    public class Severity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ColorCode { get; set; }
        public int Weight { get; set; }
    }
}