using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    // test the program
    public class StudentTest
    {
        static void Main()
        {
            // create new students
            var firstStudent = new Student("Grozio", 38);
            var secondStudent = new Student("Grozdanka", 33);
  
            // subscribe for the PropertyCnaged event
            firstStudent.PropertyChanged += (sender, eventArgs) =>
                Console.WriteLine("Property  cnaged: {0} (from {1} to {2})", 
                eventArgs.Property, eventArgs.OldValue, eventArgs.NewValue);

            secondStudent.PropertyChanged += (sender, eventArgs) =>
                Console.WriteLine("Property  cnaged: {0} (from {1} to {2})",
                eventArgs.Property, eventArgs.OldValue, eventArgs.NewValue);

            // change the first student's name and the second student's age  several times to trigger the event
            firstStudent.Name = ("Pesho Manekena");
            firstStudent.Age = 25;
            secondStudent.Name = ("Mara Obshtata");
            secondStudent.Age = 20;

            // set the properties with the same values to check that an event is not triggered
            firstStudent.Name = ("Pesho Manekena");
            firstStudent.Age = 25;
            secondStudent.Name = ("Mara Obshtata");
            secondStudent.Age = 20;            
        }
    }
}
