using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace ReturnOrderPortal.Models
{
    public class Component
    {
        public string Name { get; set; }

        public string ContactNumber { get; set; }

        public long CreditCardNumber { get; set; }

        public string ComponentType { get; set; }

        public string ComponentName { get; set; }

        public int Quantity { get; set; }
        public bool IsPriorityRequest { get; set; }
    }
}
