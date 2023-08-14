using System.Collections.ObjectModel;

namespace TestSwipeView
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<UserDTO> AvailableUsers { get; set; }

        public MainPage()
        {
            InitializeComponent();

            AvailableUsers = new()
            {
                new()
                {
                    Name = "User one full name"
                },
                new()
                {
                    Name = "User two full name"
                }
            };

            BindingContext = this;
        }
    }

    public class UserDTO
    {
        public string Name { get; set; }
    }
}