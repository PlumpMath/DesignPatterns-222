using System;

namespace RepositoryPattern
{
    public class ReviewTask
    {
        public int Id { get; set; }
        public string TfsTaskId { get; set; }
        public double Effort { get; set; }
        public int Changeset { get; set; }
        public int Artifacts { get; set; }
        public int ReviewedArtifacts { get; set; }
        public int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public int? ReviewerId { get; set; }
        public virtual TeamMember Reviewer { get; set; }
        public int? DeveloperId { get; set; }
        public virtual TeamMember Developer { get; set; }
    }
}