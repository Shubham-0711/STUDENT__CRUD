using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            StudentCRUD crud = new StudentCRUD();
            do
            {
                Console.WriteLine("--SELECT OPTIONS --");
                Console.WriteLine("1.Get StudentList :");
                Console.WriteLine("2.Get Student Details :");
                Console.WriteLine("3.Add Student ");
                Console.WriteLine("4.Update Student Details ");
                Console.WriteLine("5.Delete Student Details");
                int Options=Convert.ToInt32(Console.ReadLine());

                switch (Options)
                {
                             //displaylist
                    case 1:
                        List<Student>list = crud.GetStudent();
                        Console.WriteLine("Roll_No\t Name");
                        foreach(Student student in list)
                        {
                            Console.WriteLine($"{student.Roll_No}\t{student.Name}");
                        }
                        break; 
                                //get student details
                        case 2:
                        Console.WriteLine("Enter The Roll No :");
                        int Roll_no=Convert.ToInt32(Console.ReadLine());
                        Student S = crud.GetStudentByID(Roll_no);
                        Console.WriteLine("roll no\tName");
                        Console.WriteLine($"{S.Roll_No}\t{S.Name}");
                        break;
                                //ADD Student 
                        case 3:
                        Student S1=new Student();
                        Console.WriteLine("Enter Roll No :");
                        S1.Roll_No = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name :");
                        S1.Name= (Console.ReadLine());
                        crud.AddStudent(S1);
                        Console.WriteLine("Student Added ");
                        break;
                              //Update 
                        case 4:
                        Student S2 =new Student();
                        Console.WriteLine("Enter Roll No :");
                        S2.Roll_No = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name :");
                        S2.Name = (Console.ReadLine());
                        crud.AddStudent(S2);
                        Console.WriteLine("Detail Updated ");
                        break;

                        //Delete
                        case 5:
                        Console.WriteLine("Enter The Roll No :");
                        int RN = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteStudent(RN); ;
                        Console.WriteLine($"{RN} Student Details Deleted...");
                        break;

                }
                Console.WriteLine("Press 1 for Continue ");
                no=Convert.ToInt32(Console.ReadLine());
            }
            while (no == 1); 
        }
    }
}
