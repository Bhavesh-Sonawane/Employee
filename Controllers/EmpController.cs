using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GitExercise.Models;

namespace GitExercise.Controllers
{
    public class EmpController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }
        // GET: Emp
        public ActionResult Display()
        {
            List<Emp> emps = new List<Emp>()
            {
                new Emp{EId=1,EName="Ravi",EDesing="Hr",EDOJ=new DateTime(2012,12,12)},
                new Emp{EId=2,EName="Ramesh",EDesing="Dev",EDOJ=new DateTime(2012,12,12)},
                new Emp{EId=3,EName="Vikas",EDesing="Manager",EDOJ=new DateTime(2012,12,12)},
                new Emp{EId=4,EName="Dinesh",EDesing="Hr",EDOJ=new DateTime(2012,12,12)}
            };
            return View(emps);
        }
       
    }
}