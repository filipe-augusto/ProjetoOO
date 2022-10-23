using System;
using System.Collections.Generic;
namespace ProjetoOO.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url)
        : base(title, url)
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; } // 2802
        public IList<Module> Modules { get; set; }
        public double DurationInMinutes { get; set; }
        public EcontentLevel Level { get; set; }

    }
}