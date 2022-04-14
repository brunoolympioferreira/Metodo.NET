using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DevFreela.UnitTests.Application.Queries
{
    public class GetAllProjectsCommandHandlerTests
    {
        [Fact]
        public async Task ThreeProjectsExist_Executed_ReturnThreeProjectViewModels()
        {
            // Arrange
            var projects = new List<Project>
            {
                new Project("Nome do Teste 1","Descricao do teste 1",1,2,10000),
                new Project("Nome do Teste 2","Descricao do teste 2",1,2,20000),
                new Project("Nome do Teste 3","Descricao do teste 3",1,2,30000)
            };

            var projectRepositoyMock = new Mock<IProjectRepository>();
            projectRepositoyMock.Setup(pr => pr.GetAllAsync().Result).Returns(projects);

            var getAllProjectsQuery = new GetAllProjectsQuery("");
            var getAllprojectsQueryHandler = new GetAllProjectsQueryHandler(projectRepositoyMock.Object);

            // Act
            var projectViewModelList = await getAllprojectsQueryHandler.Handle(getAllProjectsQuery, new CancellationToken());

            // Assert
            Assert.NotNull(projectViewModelList);
            Assert.NotEmpty(projectViewModelList);
            Assert.Equal(projects.Count, projectViewModelList.Count);

            projectRepositoyMock.Verify(pr => pr.GetAllAsync().Result, Times.Once);

        }
    }
}
