using CoreApp.Web.Controllers;
using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
namespace CoreApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
		var controller = new HomeController();
		 Assert.IsType<ViewResult>(controller.Index());	
        }
    }
}
