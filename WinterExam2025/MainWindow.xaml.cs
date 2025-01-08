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
        public MainWindow()
        {
            InitializeComponent();

            Event event1 = new Event() 
            {
                Name = "Oasis Croke Park",
                EventDate = new DateTime(2025, 06, 20),
                TypeOfEvent = EventType.Music,
            };
        }
    }
}