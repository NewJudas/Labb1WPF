using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel:ViewModelBase
    {

        public MainViewModel(INavigationViewModel navigationViewModel, IFriendDetailsViewModel friendDetalsViewModel)
        {
            NavigationViewModel = navigationViewModel;
            FriendDetailsViewModel = friendDetalsViewModel;
        }
        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }
        public INavigationViewModel NavigationViewModel { get; }
        public IFriendDetailsViewModel FriendDetailsViewModel { get; }
    }
}
