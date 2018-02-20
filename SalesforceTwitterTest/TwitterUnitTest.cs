using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesforceTwitterApp.Controllers;
using System.Web.Mvc;

namespace SalesforceTwitterTest
{
    [TestClass]
    public class TwitterUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //add unit test

            //Arrange

            HomeController controller = new HomeController();

            //Actual

            ActionResult result = controller.Index();

            //ActionResult result = controller.TwitterCallback() as ViewResult;

            string screennameExpected = "salesforce";

            //Assert

            Assert.IsInstanceOfType(result,typeof(RedirectToRouteResult));
            RedirectToRouteResult routeResult = result as RedirectToRouteResult;
            Assert.AreEqual(routeResult.RouteName[0].ToString(), screennameExpected);
                       
        }
    }
}
