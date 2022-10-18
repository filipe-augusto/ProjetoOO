using System;
using ProjetoOO.ContentContext;

namespace ProjetoOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            var course = new Course();
            course.Level = EcontentLevel.Avancado;

            System.Console.WriteLine(course.Level);
            // System.Console.ReadLine();
        }
    }
}
