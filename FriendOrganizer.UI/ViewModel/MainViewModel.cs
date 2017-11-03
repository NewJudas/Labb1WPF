using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel:ViewModelBase
    {

        public MainViewModel(INavigationViewModel navigationViewModel, IFriendDetailViewModel friendDetalViewModel)
        {
            NavigationViewModel = navigationViewModel;
            FriendDetailViewModel = friendDetalViewModel;
        }
        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }
        public INavigationViewModel NavigationViewModel { get; }
        public IFriendDetailViewModel FriendDetailViewModel { get; }
    }
}
