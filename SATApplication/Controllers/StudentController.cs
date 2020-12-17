using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SATApplication.Models;
using SATApplication.DATA.EF;

namespace SATApplication.Controllers
{
    public class StudentController : Controller
    {
        //Create a Database Keyword
        SATEntities db = new SATEntities();

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Student()
        {
            //Link to SQL Database with StudentViewModel
            List<StudentViewModel> students = db.Students
                .Select(e => new StudentViewModel()
                {
                    StudentId = e.StudentId,
                    SSID = e.SSID,
                    StudentStatuses = new StudentStatusesViewModel()
                    {
                        SSID = e.SSID,
                        SSName = e.StudentStatus.SSName,
                        SSDescription = e.StudentStatus.SSDescription
                    },
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Major = e.Major,
                    Address = e.Address,
                    City = e.City,
                    State = e.State,
                    ZipCode = e.ZipCode,
                    Phone = e.Phone,
                    Email = e.Email,
                    PhotoUrl = e.PhotoUrl


                }).ToList<StudentViewModel>();

            return View();
        }
    }
}