using MYARCH.DATA.UnitofWork;
using MYARCH.DTO.EEntity;
using MYARCH.SERVICES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MYARCH.WEB.Controllers
{
    public class ManagerController : AdminController
    {

        private readonly IUserService _userService;
        private readonly IUnitofWork _uow;
        public ManagerController(IUnitofWork uow, IUserService userService) : base(uow)
        {
            _uow = uow;
            _userService = userService;
        }

        public ActionResult Index()
        {
            _userService.Update(new EUserDTO
            {
                Id = 1,
                FullName = "Recai RecRec",
                Image = null,
                Job = "Sayarbilgi Mühendisliği",
                UserName = "Admin"
            });

            _uow.SaveChanges();
            
            return View();
        }

    }
}