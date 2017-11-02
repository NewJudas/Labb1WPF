using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            yield return new Friend { FirstName = "Kenan", LastName = "Alic" };
            yield return new Friend { FirstName = "Bosse", LastName = "Kaffekopp" };
            yield return new Friend { FirstName = "Nils", LastName = "Pyssling" };
            yield return new Friend { FirstName = "Thomas", LastName = "Huber" };
        }
    }
}
