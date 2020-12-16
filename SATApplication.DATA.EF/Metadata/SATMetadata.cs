using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATApplication.DATA.EF.Metadata
{
    public class SATMetadata
    {
        //Course Metadata (Misspelled because I'm dumb)
        #region Cours
        //Foreign Key
        //public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public byte CreditHours { get; set; }
        public string Curriculum { get; set; }
        public string Notes { get; set; }
        public bool isActive { get; set; }
        #endregion

        //Enrollment Metadata
        #region Enrollment
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ScheduledClassId { get; set; }
        public System.DateTime EnrollmentDate { get; set; }
        #endregion

        //Scheduled Class Metadata
        #region ScheduledClass
        //Foreign Key 
        //public int ScheduledClassId { get; set; }
        public int CourseId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string InstructorName { get; set; }
        public string Location { get; set; }
        public int SCSID { get; set; }
        #endregion

        //Scheduled Class Status Metadata
        #region ScheduledClassStatus
        //Foreign Key
        //public int SCSID { get; set; }
        public string SCSName { get; set; }
        #endregion

        //Student Metadata
        #region Student
        //Foreign Key
        //public int StudentId { get; set; }
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
        #endregion

        //Student Status Metadata
        #region StudentStatus
        //Foreign Key
        //public int SSID { get; set; }
        public string SSName { get; set; }
        public string SSDescription { get; set; }
        #endregion

    }//end class
}//end namespace
