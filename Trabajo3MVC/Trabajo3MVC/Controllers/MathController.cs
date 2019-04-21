using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabajo3MVC.Models;

namespace Trabajo3MVC.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Calculate()
        {
            return View();
        }

       [HttpPost]
       public ActionResult Result(MyMath myMath)
        {
            MyMath theResult = new MyMath();
            theResult.NumberOne = myMath.NumberOne;
            theResult.NumberTwo = myMath.NumberTwo;
            theResult.Multiply = myMath.Multiply;
            if (myMath.Multiply)
                theResult.Result = myMath.NumberOne * myMath.NumberTwo;
            else
                theResult.Result = myMath.NumberOne + myMath.NumberTwo;
            return View("Result", theResult);
        }
    }
}
