using System.Collections.Generic;
using GunterNet.Models.Users;

namespace GunterNet.ViewModels.Account
{
    public class UserViewModel
    {
        public User User { get; set; }
        public List<User> Friends { get; internal set; }

        public UserViewModel(User user)
        {
            User = user;
        }

    }
}
