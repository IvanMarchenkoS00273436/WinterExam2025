using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WinterExam2025.Models;

// Link for github repository: https://github.com/IvanMarchenkoS00273436/WinterExam2025
namespace WinterExam2025
{
    public partial class MainWindow : Window
    {
        // Creating two events objects
        Event event1 = new Event()
        {
            Name = "Oasis Croke Park",
            EventDate = new DateTime(2025, 06, 20),
            TypeOfEvent = EventType.Music
        };

        Event event2 = new Event()
        {
            Name = "Electric Picnic",
            EventDate = new DateTime(2025, 08, 20),
            TypeOfEvent = EventType.Music
        };

        //Creating two tickets objects
        Ticket ticket1 = new Ticket()
        {
            Name = "Early Bird",
            Price = 100m,
            AvailableTickets = 100
        };

        Ticket ticket2 = new Ticket()
        {
            Name = "Platinium",
            Price = 150m,
            AvailableTickets = 100
        };

        // Creating two VIP tickets objects
        VIPTicket vipTicket1 = new VIPTicket()
        {
            Name = "Ticket and Hotel Package",
            Price = 150m,
            AdditionalCost = 100m,
            AdditionalExtras = "4* hotel",
            AvailableTickets = 100,
        };

        VIPTicket vipTicket2 = new VIPTicket()
        {
            Name = "Weekend Ticket",
            Price = 200m,
            AdditionalCost = 100m,
            AdditionalExtras = "with camping",
            AvailableTickets = 100,
        };

        public MainWindow()
        {
            InitializeComponent();

            // Adding tickets to events
            event1.Tickets.Add(ticket1);
            event1.Tickets.Add(vipTicket1);

            event2.Tickets.Add(ticket2);
            event2.Tickets.Add(vipTicket2);

            EventsListBox.Items.Add(event1);
            EventsListBox.Items.Add(event2);
        }

        private void EventsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedEvent = (Event)EventsListBox.SelectedItem;
            if (selectedEvent != null) 
            { 
                TicketsListBox.ItemsSource = selectedEvent.Tickets;
            }
        }
    }
}