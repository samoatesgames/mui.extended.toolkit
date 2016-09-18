
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ModernUI.Xceed.Toolkit.Example.Pages
{
    /// <summary>
    /// Interaction logic for CollectionControl.xaml
    /// </summary>
    public partial class CollectionControl
    {
        public CollectionControl()
        {
            InitializeComponent();

            DataContext = new CollectionControlViewModel();
        }

        public class CollectionControlViewModel
        {
            public ObservableCollection<UserViewModel> Users { get; private set; }

            public List<Type> NewItemTypes { get; private set; }

            public CollectionControlViewModel()
            {
                Users = new ObservableCollection<UserViewModel>
                {
                    new UserViewModel() 
                };

                NewItemTypes = new List<Type>
                {
                    typeof(UserViewModel)
                };
            }
        }
    }
}
