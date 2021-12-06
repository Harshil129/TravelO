using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelO.Controllers;

namespace TravelOTest
{
    [TestClass]
    public class DummiesControllerTest
    {
        [TestMethod]
        public void IndexReturnsSomething()
        {
            var controller = new DummiesController();

            var result = controller.Index();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexLoadsIndexView()
        {
            var controller = new DummiesController();

            var result = (ViewResult)controller.Index();

            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void IndexViewDataShowsMessage()
        {
            // arrange
            var controller = new DummiesController();

            // act
            var result = (ViewResult)controller.Index();

            // assert
            Assert.AreEqual("This is a viewdata message", result.ViewData["Message"]);
        }
    }
}
