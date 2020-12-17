using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SATApplication.DATA.EF;
using SATApplication.Models;

namespace SATApplication.Controllers
{
    public class EnrollmentController : Controller
    {
        SATEntities db = new SATEntities();
        // GET: Enrollment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enrollments()
        {
            List<EnrollmentsViewModel> students = db.Enrollments
              .Select(e => new EnrollmentsViewModel()
              {
                  EnrollmentId = e.EnrollmentId,
                  StudentId = e.StudentId,
                  ScheduledClassId = e.ScheduledClassId,
                  //scheduled class view model
                  ScheduledClasses = new ScheduledClassesViewModel()
                  {
                      ScheduledClassId = e.ScheduledClassId,
                      CourseId = e.ScheduledClass.CourseId,
                      //courses class view model
                      Courses = new CoursesViewModel()
                      {
                          CourseId = e.ScheduledClass.CourseId,
                          CourseName = e.ScheduledClass.Cours.CourseName,
                          CourseDescription = e.ScheduledClass.Cours.CourseDescription,
                          CreditHours = e.ScheduledClass.Cours.CreditHours,
                          Curriculum = e.ScheduledClass.Cours.Curriculum,
                          Notes = e.ScheduledClass.Cours.Notes,
                          isActive = e.ScheduledClass.Cours.isActive
                      },
                      StartDate = e.ScheduledClass.StartDate,
                      EndDate = e.ScheduledClass.EndDate,
                      InstructorName = e.ScheduledClass.InstructorName,
                      Location = e.ScheduledClass.Location,
                      SCSID = e.ScheduledClass.SCSID,
                      // scheduled class statuses view model
                      ScheduledClassStatuses = new ScheduledClassStatusesViewModel()
                      {
                          SCSID = e.ScheduledClass.ScheduledClassStatus.SCSID,
                          SCSName = e.ScheduledClass.ScheduledClassStatus.SCSName
                      }
                  },
                  EnrollmentDate = e.EnrollmentDate
              }).ToList<EnrollmentsViewModel>();
            return View();
        }
    }
}