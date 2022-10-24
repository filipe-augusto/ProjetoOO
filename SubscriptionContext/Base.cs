using System;
using System.Collections.Generic;
using ProjetoOO.NotificationContext;
namespace ProjetoOO.SharedContext
{

    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

    }
}