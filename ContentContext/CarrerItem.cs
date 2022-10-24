using System;
using System.Collections.Generic;
using ProjetoOO.SharedContext;

namespace ProjetoOO.ContentContext
{
    public class CarrerItem : Base
    {

        public CarrerItem(int order, string title, string description, Course course)
        {
            if (course == null)
                AddNotification(new NotificationContext.Notification("Course", "Curso invalido."));
            // throw new System.Exception("O curso não pode ser nulo");

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}