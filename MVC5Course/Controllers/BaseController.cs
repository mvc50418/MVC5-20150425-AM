using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class BaseController : Controller
    {
        //加一層 baseController  可以把共用的物件放在這裏
        // CONTROLLER 更輕
       protected ClientRepository repo = RepositoryHelper.GetClientRepository();
       protected OccupationRepository repoOccupation = RepositoryHelper.GetOccupationRepository();
    }
}