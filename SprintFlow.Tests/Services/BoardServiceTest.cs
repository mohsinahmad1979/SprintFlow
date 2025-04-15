using Moq;
using SprintFlow.Domain.Entities;
using SprintFlow.Domain.Interfaces;
using SprintFlow.Application.Services;

namespace SprintFlow.Tests.Services
{
    public class BoardServiceTest
    {
        [Fact]
        public void CreateBoard_Should_Add_Project_To_Repository()
        {
            // Arrange
            var mockRepo = new Mock<IBoardRepository>();
            var service = new BoardService(mockRepo.Object);

            var project = new Project { Name = "Demo", Description = "Unit test project" };

            var board = new Board { Name = "Demo", Description = "Unit test project", ProjectId = project.Id };

            // Act
            service.CreateBoard(board);

            // Assert
            mockRepo.Verify(r => r.Add(It.Is<Board>(p => p == board)), Times.Once);
        }


        [Fact]
        public void GetBoards_Should_Return_Boards_From_Repository()
        {

            var project = new Project { Name = "Demo", Description = "Unit test project" };

            var board1 = new Board { Name = "Demo", Description = "Unit test project", ProjectId = project.Id };
            var board2 = new Board { Name = "Demo2", Description = "Unit test projec2t", ProjectId = project.Id };

            var expected = new List<Board>
            {
                board1,
                board2
            };
            var mockRepo = new Mock<IBoardRepository>();
            mockRepo.Setup(r => r.GetAll()).Returns(expected);
            var service = new BoardService(mockRepo.Object);

            var result = service.GetBoards();
            Assert.Equal(expected, result);

        }

    }
}