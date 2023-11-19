using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using registrationapp.Models;
using System.Data;
using System.Data.SqlClient;

namespace registrationapp.Controllers
{
    public class UserController : Controller
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter Reader;
        // GET: User
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Message = TempData["Message"];
            return View();
        }
        [HttpPost]
        public ActionResult verify(Users usermodel)
        {
            conn.ConnectionString = "Data Source=DESKTOP-R9IOJR3;Initial Catalog=registrationdb;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework";
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText="select *from registrationtbl"
        }

    }
}