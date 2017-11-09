﻿using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FriendOrganizer.UI.Data.Repositories
{
    public class FriendRepository : GenericRepository<Friend,FriendOrganizerDbContext>, IFriendRepository
    {
        private FriendOrganizerDbContext _context;

        public FriendRepository(FriendOrganizerDbContext context)
            :base(context)
        {            
        }

        public override async Task<Friend> GetByIdAsync(int friendId)
        {
            return await Context.Friends.Include(f =>f.PhoneNumbers).SingleAsync(f => f.Id == friendId);
        }

        public void RemovePhoneNumber(FriendPhoneNumber model)
        {
            Context.FriendPhoneNumbers.Remove(model);
        }
    }
}
