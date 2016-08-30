using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModernUI.Xceed.Toolkit.Example.Pages
{
    /// <summary>
    /// Interaction logic for PropertyGrid.xaml
    /// </summary>
    public partial class PropertyGrid : Page
    {
        public PropertyGrid()
        {
            InitializeComponent();
            DataContext = new UserViewModel()
            {
                FirstName = "Sam",
                LastName = "Oates",
                Sex = Sex.Male,
                Role = Role.Programmer,
                Level = Level.Senior,
                Salary = 100000
            };
        }
    }

    public class UserViewModel
    {
        [Category("User")]
        public string FirstName { get; set; }

        [Category("User")]
        public string LastName { get; set; }

        [Category("User")]
        public Sex Sex { get; set; }

        [Category("Job")]
        public Role Role { get; set; }

        [Category("Job")]
        public Level Level { get; set; }

        [Category("Job")]
        public int Salary { get; set; }
    }

    public enum Sex
    {
        Male,
        Female,
        Other
    }

    public enum Role
    {
        Programmer,
        Artist,
        Designer,
        Producer,
        Other
    }

    public enum Level
    {
        Junior,
        Standard,
        Experienced,
        Senior,
        Lead
    }
}
