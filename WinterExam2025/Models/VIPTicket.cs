using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterExam2025.Models
{
    // Class for VIP ticket with additional properties
    public class VIPTicket : Ticket
    {
        public string AdditionalExtras { get; set; }
        public decimal AdditionalCost { get; set; }
    }
}
