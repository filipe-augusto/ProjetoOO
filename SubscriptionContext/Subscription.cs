using System;
using ProjetoOO.SharedContext;

namespace ProjetoOO.Subscription{
    public class Subscription : Base{
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;
    }
}