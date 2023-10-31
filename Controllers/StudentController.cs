using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConventionalRouting.Models;

namespace ConventionalRouting.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetAllStudent()
        {
            var students = Students();
            return View(students);
        }
        public ActionResult GetStudentId(int id)
        {
            var student = Students().FirstOrDefault(x => x.Id == id);
            return View(student);
        }
        public ActionResult GetStudentAddress(int id)
        {
            var student = Students().Where(y => y.Id == id).Select(x => x.Address).FirstOrDefault();
            return View(student);
        }
        private List<Student> Students()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id=1,
                    Name="Student1",
                    Class="class 1",
                    Address=new Address()
                    {
                        HomeNumber="student 1",
                        Address1="student 1 address",
                        City="student 1 city"


                    }


                },
                new Student()
                {
                    Id=2,
                    Name="Student2",
                    Class="class 2",
                    Address=new Address()
                    {
                        HomeNumber="student 2",
                        Address1="student 2 address",
                        City="student 2 city"


                    }


                },
                new Student()
                {
                    Id=3,
                    Name="Student3",
                    Class="class 3",
                    Address=new Address()
                    {
                        HomeNumber="student 3",
                        Address1="student 3 address",
                        City="student 3 city"


                    }


                },
                new Student()
                {
                    Id=4,
                    Name="Student4",
                    Class="class 4",
                    Address=new Address()
                    {
                        HomeNumber="student 4",
                        Address1="student 4 address",
                        City="student 4 city"


                    }


                },
                new Student()
                {
                    Id=5,
                    Name="Student5",
                    Class="class 5",
                    Address=new Address()
                    {
                        HomeNumber="student 5",
                        Address1="student 5 address",
                        City="student 5 city"


                    }


                },
                new Student()
                {
                    Id=6,
                    Name="Student6",
                    Class="class 6",
                    Address=new Address()
                    {
                        HomeNumber="student 6",
                        Address1="student 6 address",
                        City="student 6 city"


                    }


                },

            };
        }


    }
}