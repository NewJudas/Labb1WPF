using System;
using System.Threading.Tasks;
using FriendOrganizer.Model;

namespace FriendOrganizer.DataAccess.API
{
    public interface IAPIClient
    {
        Task<Weather> RunAsync(DateTime dateTime);
    }
}