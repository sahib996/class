using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main()
        {
            Student studentOne = new Student("ibrahim", "Xushmandiyev", "AB106", 100);
            studentOne.GetInfo();
            studentOne.CheckGraduation();
            studentOne.GetDiplomDegree();

            Console.WriteLine();

            Student studentTwo = new Student("Sahib", "Mammadov", "AB106", 0);
            studentTwo.GetInfo();
            studentTwo.CheckGraduation();
            studentTwo.GetDiplomDegree();

            Student studentThree = new student ("Nurlan", "Abbasov ", "AB106", 50);
            studentThree.GetInfo();
            studentThree.CheckGraduation();
            studentThree.GetDiplomDegree();

            Student studentFour = new Student("Rauf", "Dosduyev", "AB106", 35);
            studentFour.GetInfo();
            studentFour.CheckGraduation();
            studentFour.GetDiplomDegree();
        }
    }
}
