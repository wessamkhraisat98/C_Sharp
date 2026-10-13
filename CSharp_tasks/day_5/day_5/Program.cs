using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    internal class Person
    {
        private string _internalCode; // Private field, not accessible outside the class
        public string Name  { get; set; }
        public int Age { get; set; }

        protected string SchoolName { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }


    internal class Student : Person
    {
        public int Grade  { get; set; }

        public int StudentId { get; set; }


        public void DisplaySchoolName()
        {
            Console.WriteLine($"SchoolName: {SchoolName}");
        }
    }


    internal class Teacher : Person
    {
        public string Subject { get; set; }

        public void DisplayTeacherInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Subject: {Subject}");
        }
    }

    internal sealed class SchoolReport
    {
        public SchoolReport(string reportTitle)
        {
            ReportTitle = reportTitle;
        }

        public string ReportTitle { get; set; }

        public void DisplayReportTitle()
        {
            Console.WriteLine($"Generating report: {ReportTitle}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student
            {
                Name = "Wessam",
                Age = 28,
                Grade = 10,
                StudentId = 12345
            };
            student.DisplayInfo();
            student.DisplaySchoolName();
            // student._internalCode = "ABC123"; // This line will cause a compilation error because _internalCode is private
            // student.SchoolName = "Greenwood High"; // This line will cause a compilation error because SchoolName is protected and cannot be accessed from outside the class hierarchy
            Teacher teacher = new Teacher
            {
                Name = "Mohammad",
                Age = 40,
                Subject = "Mathematics"
            };
            teacher.DisplayTeacherInfo();
            Console.ReadLine();


            SchoolReport report = new SchoolReport("Annual Performance Report");
            report.DisplayReportTitle();


            // the SchoolReport class is sealed, so it cannot be inherited. The following line would cause a compilation error if uncommented:


            Student student2 = new Student
            {
                Name = "mohammad",
                Age = 22,
                Grade = 5,
                StudentId = 12346
            };




        }
    }
}
