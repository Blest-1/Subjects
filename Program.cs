using System;

namespace W2
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student();
            var student2 = new Student();
            student1.Name = "Matthew Vaquera";
            student1.Major = "Information Technology";
            student1.AddSubjects("Graphic Desighn", "Intro to C#", "OOP", "Spreadsheets");
            student1.PrintStudentInfo();


            student2.Name = "John";
            student2.Major = "Economy";
            student2.AddSubjects("Inro to economy");
            student2.PrintStudentInfo();
        }
    }
}
