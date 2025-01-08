using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterExam2025.Models
{
    // Enum collection for event types
    public enum EventType
    {
        Music,
        Comedy,
        Theatre
    }

    //Class event with properties
    public class Event : IComparable<Event>
    {
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public EventType TypeOfEvent { get; set; }

        // Compare method for sorting events by date
        public int CompareTo(Event? other)
        {
            if(this.EventDate > other.EventDate)
            {
                return 1;
            }
            else if (this.EventDate < other.EventDate)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{Name} - {TypeOfEvent}";
        }
    }
}
