using MYARCH.CORE;

namespace MYARCH.SERVICES.Interfaces
{
    public interface IUserService
    {
        void Update(User user);
        void GetUserByUserNameAndPassword(string userNamer, string password);
    }
}
