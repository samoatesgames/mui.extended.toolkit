using System.ComponentModel;

namespace ModernUI.Xceed.Toolkit.Example.Pages
{
    /// <summary>
    /// Interaction logic for PropertyGrid.xaml
    /// </summary>
    public partial class PropertyGrid
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
        [Description("The first name of the user.")]
        public string FirstName { get; set; }

        [Category("User")]
        [Description("The last name of the user.")]
        public string LastName { get; set; }

        [Category("User")]
        [Description("The sex of the user (optional).")]
        public Sex Sex { get; set; }

        [Category("Job")]
        [Description("The users current role within the company.")]
        public Role Role { get; set; }

        [Category("Job")]
        [Description("The level at which the user opperates.")]
        public Level Level { get; set; }

        [Category("Job")]
        [Description("The salary of the user, in USD ($).")]
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