using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingNetNetCore.Models
{
    public class NistMemory

    {
        static List<PersonalDetail> people = new List<PersonalDetail>();
        public NistMemory()
        {

        }
        public static List<PersonalDetail> GetPeople()
        {
            if (people.Count == 0)
            {
                people.Add(new PersonalDetail()
                {
                    FirstName = "Sagar",
                    Address = "Banepa",
                    Occupation = "Student",
                    Age = 21,
                    Email = "saagardhoju414@gmail.com",
                    PersonalDetailId = 1
                });
                people.Add(new PersonalDetail()
                {
                    FirstName = "sangarsa",
                    Address = "panauti",
                    Occupation = "student",
                    Age = 21,
                    Email = "ringingcake99@gmail.com",
                    PersonalDetailId = 2
                });

            }

            return people;
        }

    }
}