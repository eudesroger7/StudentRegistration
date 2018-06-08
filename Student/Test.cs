using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Test
    {
        public static void Main(string[] args)
        {
            StudentController controller = new StudentController();

            print("\nEnter student matriculation");
            Student eudes = new Student(long.Parse(Console.ReadLine()));
            print("Enter name");
            eudes.setName("Eudes");
            print("Enter teacher name");
            eudes.setTeacher("Raoni");
            print("\n" + controller.create(eudes));

            print("\nEnter student matriculation");
            Student gabriel = new Student(long.Parse(Console.ReadLine()));
            print("Enter name");
            gabriel.setName("Gabriel");
            print("Enter teacher name");
            gabriel.setTeacher("Eudes");
            print("\n" + controller.create(gabriel));

            print("\n" + controller.show());
            print("\nStudent found");
            print("\n" + controller.search(123123));
            print("\n" + controller.delete(gabriel));
            print("\n" + controller.show());



        }

        public static void print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
