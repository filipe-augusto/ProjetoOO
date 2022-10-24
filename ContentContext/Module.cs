using System;
using System.Collections.Generic;
using ProjetoOO.SharedContext;

namespace ProjetoOO.ContentContext
{

    public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
        public EcontentLevel Level { get; set; }
    }
}