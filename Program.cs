using System;
using ProjetoOO.ContentContext;

namespace ProjetoOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo Oop", "orientacao-obj"));
            articles.Add(new Article("Artigo sobre c#", "csharp"));
            articles.Add(new Article("Artigo sobre .net", ".net"));

            /*          foreach (var article in articles)
                     {
                         System.Console.WriteLine(article.Id);
                         System.Console.WriteLine(article.Title);
                         System.Console.WriteLine(article.Url);
                     } */
            var courses = new List<Course>();
            var cursoOpp = new Course("OPP", "fundamentos-opp");
            var cursoCsharp = new Course("C#", "fundamentos-csharp");
            var cursoAspnet = new Course("asp.net", "fundamentos-aspnet");
            courses.Add(cursoOpp);
            courses.Add(cursoCsharp);
            courses.Add(cursoAspnet);
            Console.Clear();

            /*     if (cursoAspnet.IsValid)
                {
                } */

            var carrers = new List<Carrer>();
            var carrer = new Carrer("especialista .net", "especialiasta-dotnet");
            var carrerItem = new CarrerItem(1, "aprenda OPP", "", null);
            var carrerItem2 = new CarrerItem(2, "comece por aqui", "", cursoCsharp);
            var carrerItem3 = new CarrerItem(3, "asp net", "", cursoAspnet);
            carrers.Add(carrer);
            carrer.Items.Add(carrerItem);
            carrer.Items.Add(carrerItem2);
            carrer.Items.Add(carrerItem3);
            foreach (var ca in carrers)
            {
                Console.WriteLine(ca.Title);
                foreach (var item in ca.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} {item.Title}");
                    System.Console.WriteLine(item.Course?.Title);
                    System.Console.WriteLine(item.Course?.Level);
                    foreach (var notification in item.Notifications)
                    {
                        System.Console.WriteLine($"{notification.Property}-{notification.Message}");
                    }
                }
            }


            //OLD
            // var course = new Course();
            // course.Level = EcontentLevel.Advanced;
            // //course.Itens
            // var carrer = new Carrer();
            // carrer.Items.Add(new CarrerItem());
            // System.Console.WriteLine(carrer.TotalCourses);

            // System.Console.WriteLine(course.Level);
            // System.Console.ReadLine();
        }
    }
}
