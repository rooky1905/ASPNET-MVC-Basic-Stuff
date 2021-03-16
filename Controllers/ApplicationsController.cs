using ASPNET_MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC.Controllers
{
    public class ApplicationsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ApplicationsController(ApplicationDbContext db)
        {
            _db = db;

        }
    }
}