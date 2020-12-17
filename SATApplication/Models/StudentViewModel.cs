using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SATApplication.Models
{
    public class StudentViewModel
    {        
        public int StudentId { get; set; }        
        public string FirstName { get; set; }        
        public string LastName { get; set; }       
        public string Major { get; set; }
        public string Address { get; set; }        
        public string City { get; set; }
        public string State { get; set; }        
        public string ZipCode { get; set; }                
        public string Phone { get; set; }        
        public string Email { get; set; }        
        public string PhotoUrl { get; set; }
        public Nullable<int> SSID { get; set; }
        public StudentStatusesViewModel StudentStatuses { get; set; }        
    }

    public class StudentStatusesViewModel
    {        
        public Nullable<int> SSID { get; set; }        
        public string SSName { get; set; }        
        public string SSDescription { get; set; }
    }

    public class EnrollmentsViewModel
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ScheduledClassId { get; set; }        
        public System.DateTime EnrollmentDate { get; set; }
        public ScheduledClassesViewModel ScheduledClasses { get; set; }
    }

    public class ScheduledClassesViewModel
    {         
        public int ScheduledClassId { get; set; }
        public int CourseId { get; set; }        
        public System.DateTime StartDate { get; set; }        
        public System.DateTime EndDate { get; set; }        
        public string InstructorName { get; set; }       
        public string Location { get; set; }
        public int SCSID { get; set; }
        public ScheduledClassStatusesViewModel ScheduledClassStatuses { get; set; }
        public CoursesViewModel Courses { get; set; }
    }

    public class ScheduledClassStatusesViewModel
    {        
        public int SCSID { get; set; }        
        public string SCSName { get; set; }
    }

    public class CoursesViewModel
    {        
        public int CourseId { get; set; }       
        public string CourseName { get; set; }       
        public string CourseDescription { get; set; }        
        public byte CreditHours { get; set; }        
        public string Curriculum { get; set; }        
        public string Notes { get; set; }
        public bool isActive { get; set; }
    }
}