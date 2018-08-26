using CalcoulationServesDemo.Serveses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalcoulationServesDemo.Controllers
{
    public class OperationController : Controller
    {
        // GET: Operation
        public ActionResult Index(int ? fnum ,int ? secnum,string op)
        {

            int FNum = fnum != null ? fnum.Value : 0;
            int SecNum = secnum != null ? secnum.Value : 0;
            Operation operation = new Operation();
            int result = 0;
            if (op != null) {

                if (op == "Add") {

                    result=operation.Add(FNum, SecNum);
                }
                if (op == "Divide")
                {
                    result = operation.Divide(FNum, SecNum);
                }
                if (op == "Multiply")
                {
                    result = operation.Multiply(FNum, SecNum);
                }
                if (op == "Subtract")
                {
                    result = operation.Subtract(FNum, SecNum);
                }

            }
            ViewData["result"] = result;
            return View(result);
        }
    }
}