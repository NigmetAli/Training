using MYARCH.CORE;
using MYARCH.DTO.EEntity;

namespace MYARCH.SERVICES.Interfaces
{
    public interface IUserService
    {
        void Update(EUserDTO user);
        void GetUserByUserNameAndPassword(string userNamer, string password);
    }
}
