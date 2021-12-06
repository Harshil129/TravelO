using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelO.Controllers;
using TravelO.Data;
using TravelO.Models;

namespace TravelOTest
{
    [TestClass]
    public class PlacesControllerTests
    {
        private ApplicationDbContext _context;
        PlacesController controller;
        List<Place> places = new List<Place>();

        [TestInitialize]
        public void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _context = new ApplicationDbContext(options);

            var province = new Province
            {
                ProvinceID = 500,
                Name = "My Dummy Province"
            };
            _context.Provinces.Add(province);

            places.Add(new Place
            {
                PlaceID = 741,
                Name = "The Best place for summer holiday",
                Description = "Barrie is in Simcoe County",
                ProvinceID = 500,
                Province = province
            });

            places.Add(new Place
            {
                PlaceID = 546,
                Name = "The Best place for Winter holiday",
                Description = "Toronto is in Ontario",
                ProvinceID = 500,
                Province = province
            });

            places.Add(new Place
            {
                PlaceID = 241,
                Name = "The Best place for fall holiday",
                Description = "Saskatoon is in sasketchwan",
                ProvinceID = 500,
                Province = province
            });

            foreach (var place in places)
            {
                _context.Places.Add(place);
            }
            _context.SaveChanges();

            controller = new PlacesController(_context);
        }

        #region Index

        [TestMethod]
        public void IndexLoadsIndexView()
        {
            // arrange - now done in TestInitialize instead            

            // act
            var result = (ViewResult)controller.Index().Result;

            // assert
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void IndexLoadsPlaces()
        {
            // act
            var result = (ViewResult)controller.Index().Result;
            List<Place> model = (List<Place>)result.Model;

            // assert
            CollectionAssert.AreEqual(places.OrderBy(p => p.Name).ToList(), model);
        }

        #endregion

        #region Details

        [TestMethod]
        public void DetailsNullIdLoads404()
        {
            // act
            var result = (ViewResult)controller.Details(null).Result;

            // assert
            Assert.AreEqual("404", result.ViewName);
        }

        [TestMethod]
        public void DetailsInvalidIdLoads404()
        {
            // act
            var result = (ViewResult)controller.Details(1001).Result;

            // assert
            Assert.AreEqual("404", result.ViewName);
        }

        [TestMethod]
        public void DetailsValidIdLoadsPlace()
        {
            // act
            var result = (ViewResult)controller.Details(741).Result;

            // assert
            Assert.AreEqual(places[1], result.Model);
        }

        [TestMethod]
        public void DetailsValidIdLoadsView()
        {
            // act
            var result = (ViewResult)controller.Details(741).Result;

            // assert
            Assert.AreEqual("Details", result.ViewName);
        }

        #endregion
    }
}
