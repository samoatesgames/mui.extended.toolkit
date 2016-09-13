using System.ComponentModel;
using System.Runtime.CompilerServices;

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
            var user = new UserViewModel()
            {
                FirstName = "Sam",
                LastName = "Oates",
                Sex = Sex.Male,
                Role = Role.Programmer,
                Level = Level.Senior,
                Salary = 100000
            };

            DataContext = new PropertyGridViewModel()
            {
                User = user
            };
        }
    }

    public sealed class PropertyGridViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private bool m_showTitle = false;
        private bool m_showSortOptions = true;
        private bool m_showSearchBox = true;
        private bool m_showSummary = true;

        public UserViewModel User
        {
            get;
            set;
        }

        public bool ShowTitle
        {
            get { return m_showTitle; }
            set
            {
                if (m_showTitle != value)
                {
                    m_showTitle = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool ShowSortOptions
        {
            get { return m_showSortOptions; }
            set
            {
                if (m_showSortOptions != value)
                {
                    m_showSortOptions = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool ShowSearchBox
        {
            get { return m_showSearchBox; }
            set
            {
                if (m_showSearchBox != value)
                {
                    m_showSearchBox = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool ShowSummary
        {
            get { return m_showSummary; }
            set
            {
                if (m_showSummary != value)
                {
                    m_showSummary = value;
                    OnPropertyChanged();
                }
            }
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
        [Description("The salary of the user per year, in USD ($).")]
        public int Salary { get; set; }

        [Category("Job")]
        [Description("The required number of hours worked per week.")]
        public float HoursPerWeek { get; set; }

        [Category("Job")]
        [Description("The hourly pay of the user per year, in USD ($).")]
        public float HourlyPay { get; set; }
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