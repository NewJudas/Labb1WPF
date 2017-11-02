using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public interface IFriendDetailsViewModel
    {
        Task LoadAsync(int friendId);
    }
}