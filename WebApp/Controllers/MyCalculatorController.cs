using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WbLib;
namespace WebApp.Controllers
{
    public class MyCalculatorController : Controller
    {
        // GET: MyCalculator
        public ActionResult FindSquare(int no)
        {
            Calulator c = new Calulator();
            int res = c.Square(no);
            return Content($"Square of {no} is {res}");

        }
        public ActionResult FindCube(int no)
        {
            Calulator c = new Calulator();
            int res = c.Cube(no);
            return Content($"Cube of {no} is {res}");

        }

    }
}