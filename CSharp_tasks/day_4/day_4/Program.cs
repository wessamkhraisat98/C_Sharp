using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ahmad", 20, 85);
            Student student2 = new Student("Sara", 21, 92);
            Student student3 = new Student("Omar", 19, 78);

            Console.WriteLine("===== Student Information =====");
            Console.WriteLine();

            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();
        }
    }
}
