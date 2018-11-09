using MYARCH.CORE;
using MYARCH.DATA.GenericRepository;
using MYARCH.DATA.UnitofWork;
using MYARCH.DTO.EEntity;
using MYARCH.SERVICES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYARCH.SERVICES.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _userRepository;
        public readonly IUnitofWork _uow;

        public UserService(UnitofWork uow)
        {
            _uow = uow;
            _userRepository = _uow.GetRepository<User>();
        }
        public void GetUserByUserNameAndPassword(string userName, string password)
        {
            var control = _userRepository.GetAll().Where(p => p.UserName == userName && p.Password == password).SingleOrDefault();
        }

        public void Update(EUserDTO user)
        {
            var entity = _userRepository.Find(user.Id);

            AutoMapper.Mapper.Initialize(cfg => cfg.CreateMissingTypeMaps = true);
            AutoMapper.Mapper.Map(user, entity);
            _userRepository.Update(entity);
        }
    }
}
