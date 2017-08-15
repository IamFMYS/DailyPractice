using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FMY.DailyPractice.MVCTest.Controllers.TestActionResult
{
    public class TestResultController : Controller
    {
        // GET: TestResult
        public ActionResult Index()
        {
            string serverPath = Server.MapPath("~");
            return View();
        }

        public ContentResult ContentResult()
        {
            return Content("ContentResult");
        }

        //public FileResult FileResult()
        //{
        //    string serverPath = Server.MapPath("~");
        //    return File()
        //}

        public ActionResult RedirectResult()
        {
            return Redirect("http://www.baidu.com");
        }
        public ActionResult RedirectToRoute()
        {
            return RedirectToRoute(new { Controller = "TestResult", Action = "RedirectResult" });
        }

        public FilePathResult TestFilePathResult()
        {
            string path = @"E:\test.txt";            
            return File(path, "text/plain", "t1.txt");
        }
        public FileContentResult TestFileContentResult()
        {
            string path = @"E:\excell.xlsx";
            byte[] bytes = new byte[10 * 1024];
            using (System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open))
            {
                fs.Read(bytes, 0, bytes.Length);
            }
            //return File(bytes, "text/plain", "excell111.xlsx");
            return File(bytes, "application/x-xls", "excell1234.xlsx"); 
            //return File(path, "text/plain", "t1.txt");
        }

        public FileStreamResult TestFileStreamResult()
        {
            System.Net.WebClient client = new System.Net.WebClient();
            System.IO.Stream stream= client.OpenRead("http://www.taobao.com");
            return File(stream, "text/html");
            //return File(stream, "application/octet-stream");
        }
    }
}