using Xunit;
using Moq;
using SprintFlow.Domain.Entities;
using SprintFlow.Domain.Interfaces;
using SprintFlow.Application.Services;
using System.Collections.Generic;

namespace SprintFlow.Tests.Services
{
    public class ProjectServiceTests
    {
        [Fact]
        public void CreateProject_Should_Add_Project_To_Repository()
        {
            // Arrange
            var mockRepo = new Mock<IProjectRepository>();
            var service = new ProjectService(mockRepo.Object);

            var project = new Project { Name = "Demo", Description = "Unit test project" };

            // Act
            service.CreateProject(project);

            // Assert
            mockRepo.Verify(r => r.Add(It.Is<Project>(p => p == project)), Times.Once);
        }

        [Fact]
        public void GetProjects_Should_Return_Projects_From_Repository()
        {
            // Arrange
            var expected = new List<Project> {
                new Project { Name = "One", Description= "This is one" },
                new Project { Name = "Two", Description= "This is two" }
            };

            var mockRepo = new Mock<IProjectRepository>();
            mockRepo.Setup(r => r.GetAll()).Returns(expected);

            var service = new ProjectService(mockRepo.Object);

            // Act
            var result = service.GetProjects();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
