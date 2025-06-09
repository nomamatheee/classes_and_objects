using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ChatExercise
{
     class Student
    {
        //fields
        public string name,course;
        public int age;
        

        //constructor
         public Student(string name,string course,int age)
        {
            this.name = name;
            this.course = course;
            this.age = age;
        }

        //method
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name} ");
            Console.WriteLine($"Course: {course}");
            Console.WriteLine($"Age:{age}");
        }




    }
}
