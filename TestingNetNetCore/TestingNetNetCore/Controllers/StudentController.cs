using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestingNetNetCore.Models;

namespace TestingNetNetCore.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()

        {
            List<StudentModel> students = new List<StudentModel>();
            SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sagar\\Source\\Repos\\TestingNetNetCore\\ClassLibrary1\\student.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from student", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                StudentModel studentModel = new StudentModel();
                studentModel.StudentId = Convert.ToInt32(sqlDataReader["StudentId"].ToString());
                studentModel.StudentName = sqlDataReader["StudentName"].ToString();
                studentModel.Address = sqlDataReader["Address"].ToString();
                studentModel.ContactNumber = sqlDataReader["ContactNumber"].ToString();
                studentModel.Guardian = sqlDataReader["Guardian"].ToString();
                studentModel.Semester = sqlDataReader["Semester"].ToString();
                students.Add(studentModel);

            }

            return View(students);
        }
        public IActionResult Create()
        {
            StudentModel student = new StudentModel();
            return View(student);
        }

        [HttpPost]
        public IActionResult Create(StudentModel student)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sagar\\Source\\Repos\\TestingNetNetCore\\ClassLibrary1\\student.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into student (StudentName,Address,ContactNumber,Guardian,Semester)values('" + student.StudentName + "','" + student.Address + "','" + student.ContactNumber + "','" + student.Guardian + "','" + student.Semester + "')", sqlConnection);
            
            
            int result=sqlCommand.ExecuteNonQuery();
            return RedirectToAction("Index");
        }
    }
}
