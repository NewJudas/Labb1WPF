using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;
        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator )
        {
            _contextCreator = contextCreator;
        }
        public async Task<List<Friend>> GetAllAsnyc()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking().ToListAsync();
            }
        }
    }
}
