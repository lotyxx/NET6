using System;
using PlayGround.Model;
using PlayGround.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Graph;
using Bogus;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2013.Word;
using DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments;

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro PersonDetailWindow.xaml
    /// </summary>
    public partial class PersonDetailWindow : Window
    {
        public PersonDetailWindow(Person person)
        {
            InitializeComponent();
            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtDateOfBirth.Text = person.DateOfBirth.ToString();
            txtAdress.Text = person.Address.ToString();
        }
    }
}
