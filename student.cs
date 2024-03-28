using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduate;

        public student( string name, string surname, string group, int point, bool isGraduate)
        {
            Name = name;
            Surname = surname;  
            Group = group;  
            Point = point; 
            IsGraduate = isGraduate;   
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name; {Name}  \nSurname; {Surname}   \nGropu; {Group}   \npoint; {Point}   \nIsGraduate; {IsGraduate}");                       );
        }

        public void CheckGraduation()
        {
            Console.WriteLine ($"Graduation Status: {(IsGraduate ? "Bu telebe mezun olub" : "Mezun olmayib")}");
        }
        public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("yoxdur");
            }
            else if (Point >= 65 && Point < 85)
            {
                Console.WriteLine("adi");
            }
            else if (Point >= 80 && Point < 90) ;
            {
                Console.WriteLine("Seref");
            }
            else 
            {
                Console.WriteLine("Yuksek seref");
            }
        }
    }
}
