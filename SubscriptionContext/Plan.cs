using System;
using ProjetoOO.SharedContext;

namespace ProjetoOO.Subscription{
    public class Plan : Base{
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}