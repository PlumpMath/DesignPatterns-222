using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattern;
using System.Collections.Generic;

namespace EnterprisePatternsTest
{
    [TestClass]
    public class RepositoryPatternTest
    {

        [TestMethod]
        public void TestRepositoryInstance()
        {
            IProjectRepository repo = new ProjectRepository("connect");
            var project = repo.GetProjects();
            Assert.IsNotNull(project);
            Assert.IsInstanceOfType(project, typeof(List<Project>));
            Assert.AreEqual(project.Count, 3);
        }


        [TestMethod]
        public void ShouldReturnGetProjectByIdAs1()
        {
            IProjectRepository repo = new ProjectRepository("connect");
            var project = repo.GetProjectById(5);
            Assert.IsNotNull(project);
            Assert.IsInstanceOfType(project, typeof(Project));
        }

        [TestMethod]
        public void ShouldReturnProjectsListBy()
        {
            IProjectRepository repo = new ProjectRepository("connect");
            var project = repo.GetProjects();
            Assert.IsNotNull(project);
            Assert.IsInstanceOfType(project, typeof(List<Project>));
            Assert.AreEqual(project.Count, 3);
        }

        [TestMethod]
        public void ShouldAddProject()
        {
            IProjectRepository repo = new ProjectRepository("connect");
            var project = repo.AddProject(new Project());
            Assert.AreEqual(project.Id, 1);
            Assert.AreEqual(project.Name, "Testing Project");
        }
    }
}
