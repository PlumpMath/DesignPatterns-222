using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public interface  IProjectRepository
    {
        Project GetProjectById(int Id);
        List<Project> GetProjects();
        void AddProject(Project project);
    }
}
