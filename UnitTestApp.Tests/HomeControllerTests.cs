using Microsoft.AspNetCore.Mvc;
using TVStore.Controllers;
using TVStore.Models;
using Moq;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexReturnsAViewResultWithAListOfTVs()
        {
            // Arrange
            var mock = new Mock<IRepository>();
            mock.Setup(repo => repo.GetAll()).Returns(GetTestTVs());
            var controller = new HomeController(mock.Object);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<TV>>(viewResult.Model);
            Assert.Equal(GetTestTVs().Count, model.Count());
        }
        private List<TV> GetTestTVs()
        {
            var TVs = new List<TV>
            {
                new TV { Id=1, Name="LG x520", Company="LG", Price=900},
                new TV { Id=2, Name="Samsung v13.0u", Company="Samsung", Price=300},
                new TV { Id=3, Name="Sony amoled.v.7g", Company="Sony", Price=400},
                new TV { Id=1, Name="LG x520", Company="LG", Price=900},
            };
            return TVs;
        }
    }
}