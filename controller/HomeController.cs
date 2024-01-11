using dj.model;
using Microsoft.AspNetCore.Mvc;

namespace dj.controller
{
    public class HomeController : Controller
    {
        private readonly GenderData _data;

        public HomeController(GenderData data)
        {
            _data = data;
        }
        public IActionResult Index()
        {
            List<Guid> ids = new List<Guid>();
            ids.Add(_data.LoadData());
            ids.Add(_data.LoadData());
            return View(ids);
        }
    }
}
