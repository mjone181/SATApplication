using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Name of Course: ")]
        [Required(ErrorMessage = "*Name is required")]
        public string CourseName { get; set; }

        [Display(Name = "Course Description: ")]
        [Required(ErrorMessage = "*Description is required")]
        public string CourseDescription { get; set; }

        [Display(Name = "Credit Hours: ")]
        [Required(ErrorMessage = "*Number of Credit Hours is required")]
        public byte CreditHours { get; set; }

        [Display(Name = "Curriculum: ")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Curriculum { get; set; }

        [Display(Name = "Notes: ")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Notes { get; set; }        
        public bool isActive { get; set; }
        #endregion

        //Enrollment Metadata
        #region Enrollment
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ScheduledClassId { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime EnrollmentDate { get; set; }
        #endregion

        //Scheduled Class Metadata
        #region ScheduledClass
        //Foreign Key 
        //public int ScheduledClassId { get; set; }
        public int CourseId { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime EndDate { get; set; }

        [Display(Name = "Name of Instructor: ")]
        [Required(ErrorMessage = "*Please enter Instructor Name")]
        public string InstructorName { get; set; }

        [Display(Name = "Location: ")]
        [Required(ErrorMessage = "*Please enter a Location")]
        public string Location { get; set; }
        public int SCSID { get; set; }
        #endregion

        //Scheduled Class Status Metadata
        #region ScheduledClassStatus
        //Foreign Key
        //public int SCSID { get; set; }
        [Display(Name = "SCS Name: ")]
        [Required(ErrorMessage = "*Please enter an SCS Name")]
        public string SCSName { get; set; }
        #endregion

        //Student Metadata
        #region Student
        //Foreign Key
        //public int StudentId { get; set; }
        [Display(Name = "First Name: ")]
        [Required(ErrorMessage = "*Please enter a First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name: ")]
        [Required(ErrorMessage = "*Please enter a Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Major: ")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Major { get; set; }

        [Display(Name = "Address: ")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Address { get; set; }

        [Display(Name = "City: ")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string City { get; set; }

        [Display(Name = "State: ")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string State { get; set; }

        [Display(Name = "ZipCode: ")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string ZipCode { get; set; }

        [Display(Name = "Phone: ")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Phone { get; set; }

        [Display(Name = "Email: ")]
        [Required(ErrorMessage = "*Please enter a valid email address.")]
        public string Email { get; set; }

        [Display(Name = "Photo URL: ")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string PhotoUrl { get; set; }
        public Nullable<int> SSID { get; set; }
        #endregion

        //Student Status Metadata
        #region StudentStatus
        //Foreign Key
        //public int SSID { get; set; }
        [Display(Name = "SSName: ")]
        [Required(ErrorMessage = "*Please enter an SSName.")]
        public string SSName { get; set; }

        [Display(Name = "SSDescription: ")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string SSDescription { get; set; }
        #endregion

    }//end class
}//end namespace
