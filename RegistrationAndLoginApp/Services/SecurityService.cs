using RegistrationAndLoginApp.Models;

namespace RegistrationAndLoginApp.Services
{
    // to authenticate users
    public class SecurityService
    {
        List<UserModel> knownUsers = new List<UserModel>();

        public SecurityService()
        {
            knownUsers.Add(new UserModel { Id = 0, UserName = "Shafiq", Password = "111" });
            knownUsers.Add(new UserModel { Id = 0, UserName = "Izwan", Password = "222" });
            knownUsers.Add(new UserModel { Id = 0, UserName = "Azyan", Password = "333" });
        }

        public bool isValid(UserModel user)
        {
            // return true if found in the list
            return knownUsers.Any (x => x.UserName == user.UserName && x.Password == user.Password);   
        }
    }
}
