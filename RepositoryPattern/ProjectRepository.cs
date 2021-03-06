﻿using System;
using System.Collections.Generic;

namespace RepositoryPattern
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly string _connectionString;
        public ProjectRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Project AddProject(Project project)
        {
            project.Id = 1;
            project.Name = "Testing Project";
            return project;
        }

        public Project GetProjectById(int Id)
        {
            //Connect DB And Add the Project
            return new Project { Id = 1, Name = "CV", ProjectType = new ProjectType { Id = 5, Name = "CTB" } };
        }

        public List<Project> GetProjects()
        {
            //Connect DB And Return Projects
            List<Project> projects = new List<Project>();
            projects.Add(new Project { Id = 1, Name = "CV1", ProjectType = new ProjectType { Id = 5, Name = "CTB" } });
            projects.Add(new Project { Id = 2, Name = "CV2", ProjectType = new ProjectType { Id = 6, Name = "CTB" } });
            projects.Add(new Project { Id = 3, Name = "CV3", ProjectType = new ProjectType { Id = 7, Name = "CTB" } });

            return projects;
        }
    }
}
