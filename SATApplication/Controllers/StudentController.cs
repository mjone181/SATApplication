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
            var students = (from s in db.Students
                            select s).ToList();
            return View(students);
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

        //GET
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "Student");
            //ViewBag.StudentStatusID = new SelectList(db.StudentStatuses, "SSID", "StudentStatuses");            
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId, FirstName, LastName, Major, Address, City, State, ZipCode, Phone, Email, PhotoUrl, SSID")] Student student)
        {
            if (ModelState.IsValid)
            {             
                //Add a new Student to the Database with a view if the Model is valid.
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //Grabbing the newly entered data and displaying it to the screen.
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "StudentId", student.StudentId);
            ViewBag.BookStatusID = new SelectList(db.StudentStatuses, "SSID", "SSName", student.SSID);            
            return View(student);
        }
    }
}