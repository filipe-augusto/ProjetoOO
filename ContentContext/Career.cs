using System;
using System.Collections.Generic;
namespace ProjetoOO.ContentContext
{
    public class Carrer : Content
    {
        public Carrer(string title, string url)
        :base(title, url)
        {
            Items = new List<CarrerItem>();
        }
        public IList<CarrerItem> Items { get; set; }

        // public int TotalCourses
        // {
        //     get
        //     {
        //         return Items.Count();
        //     }
        // }
        //expression body
        public int TotalCourses => Items.Count;
    }
}


