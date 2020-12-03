﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestingNetNetCore.Models
{
    public class PersonalDetail
    {
        public PersonalDetail()
        {
            
        }

        public int PersonalDetailId { get; set; }

        [DisplayName("First Name")]
        [Required]
        [MaxLength(20),MinLength(3)]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        
        public string LastName { get; set; }

        [Required]
        [MaxLength(50), MinLength(5)]
        public string Address { get; set; }

        
        

        [DisplayName("Profession")]
        [Required]
        [MaxLength(50), MinLength(5)]
        public string Occupation { get; set; }

        [Range(16,30)]
        public Nullable<int> Age { get; set; }

        [MinLength(11),MaxLength(50)]
        public string Email{ get; set; }
        public DateTime DOB { get; set; }



    }

    public class DoctorProfile : PersonalDetail
    {

        public DoctorProfile(List<PersonalDetail> persons) : base()
        {
        }
        public string Qualification { get; set; }
        public string HospitalClinic { get; set; }
        public string Speciality { get; set; }

    }
    public class TeacherProfile : PersonalDetail
    {
        public TeacherProfile(List<PersonalDetail> persons) : base()
        {
        }
        public string Qualification { get; set; }
        public string College { get; set; }
        public string AssociatedSubjects { get; set; }
    }
    public class StudentProfile : PersonalDetail
    {
        public StudentProfile(List<PersonalDetail> persons) : base()
        {
        }
        public string Faculty { get; set; }
        public string College_School { get; set; }
        public string Rollno { get; set; }

    }

    

}
