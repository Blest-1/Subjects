using System;
namespace W2
{
    public class Subject
    {
            public string[] Subjects;

            public void Term1()
        {
            for (int i = 0; i < Subjects.Length; i++)
            {
                Console.WriteLine(Subjects[i]);
            }
      
        }
    }
}
