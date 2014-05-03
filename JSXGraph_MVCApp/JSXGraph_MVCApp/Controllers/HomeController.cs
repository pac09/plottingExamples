using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSXGraph_MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            string[] t = new string[0];
            Random rnd = new Random();

            for (int i = 0; i < 70; i++)
            {
                Int32[] x = new Int32[0];
                x[i] = i;

                Int32[] y = new Int32[0];
                y[i] = rnd.Next(0, 20);

                t[i] = x[i] + "," + y[i] + ";";
                //$t = "";
                //for ($i=0;$i<70;$i++) {
                //    $x = $i;
                //    $y = mt_rand(0,20);
                //    $t .= $x.','.$y.';';
                //}
                //echo $t;

            }

            ViewData["t"] = t;
            //<% var myArray = (string[])ViewData["passedArray"]; %>
            return View();
        }


        //[HttpPost]
        //public ActionResult Contact() 
        //{
        //}
    }
}