using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public int Roll_No { get; set; }

        public string Name { get;set; }

    }

    public class StudentCRUD
    {
        private List<Student> studentslist;
        public StudentCRUD()
        {
            studentslist = new List<Student>()
            {
                new Student() {Roll_No=1,Name="Shubham"},
                new Student() {Roll_No=2,Name="Sandesh"},
                new Student() {Roll_No=3,Name="nikhil"}

            };
        }

        //Display List
        public List<Student> GetStudent()
        {
            return studentslist;
        }
        //Get StudentList
        public Student GetStudentByID(int Roll_no)
        {
            Student student = new Student();
            foreach (Student s in studentslist)
            {
                if (s.Roll_No == Roll_no)
                {
                    student = s;
                    break;
                }
            }
            return student;
        }
        // add 
        public void AddStudent(Student S1)
        {
            studentslist.Add(S1);
        }
        //update 
        public void UpdateStudent(Student S1)
        {
            foreach (Student S in studentslist)
            {
               if(S.Roll_No == S1.Roll_No)
                {
                    S.Roll_No = S1.Roll_No;
                    S.Name = S1.Name;
                    break;
                }
            }
        }
        //Delete

        public void DeleteStudent(int Roll_no)
        {
            foreach (Student S2 in studentslist)

            {
                if(S2.Roll_No==Roll_no)
                {
                    studentslist.Remove(S2);
                    break;
                }

            }
        }

    }

}
