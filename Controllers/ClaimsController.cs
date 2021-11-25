using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace Nume_Pren_Lab2.Controllers
{
    [Authorize]
    public class ClaimsController : Controller
    {
        public ViewResult Index() => View(User?.Claims);
    }
}