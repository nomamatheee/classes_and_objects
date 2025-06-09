using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student one = new Student("noma", "IT", 23);
            one.DisplayInfo();

            Student two = new Student("thami", "biology", 28);
            two.DisplayInfo();

            Console.ReadLine();
        }
    }
}
