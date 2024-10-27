using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QuickStart.DAL.Data;
using QuickStart.DAL.Data.Models;
using QuickStart.PL.Areas.Dashboard.ViewModels;
using QuickStart.PL.helpers;

namespace QuickStart.PL.Areas.Dashboard.Controllers
{		
    [Area("Dashboard")]
    public class PortfoliosController : Controller
    {

		private readonly ApplicationDbContext context;
		private readonly IMapper mappper;


		public PortfoliosController(ApplicationDbContext context,IMapper mappper)
		{
			this.context = context;
            this.mappper = mappper;
		}
        [HttpGet]
		public IActionResult Index()
        {
            var services = context.Portfolios.ToList();
            var mApping= mappper.Map<IEnumerable<vmPortfolio>>(services);
			return View(mApping);
        }
        [HttpGet]
        public IActionResult Create ()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
		public IActionResult Create(PortfolioFormVm vm)
		{
			if (!ModelState.IsValid)
			{
				return View(vm);
			}
			var portfolio = mappper.Map<Portfolio>(vm);
			context.Portfolios.Add(portfolio);
			context.SaveChanges();
			return RedirectToAction("Index");
		}


		[HttpGet]
        public IActionResult Details (int id)
        {
			return View(mappper.Map<PortfolioeDetailsvm>(context.Services.Find(id)));
		}
        public IActionResult Edit(int id)
        {
            var service = context.Portfolios.Find(id);
            if (service == null)
            {
                return NotFound();
            }

            var vm = mappper.Map<PortfolioeDetailsvm>(service);
            return View(vm);
        }

        // تعديل الخدمة
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ServiceDetailsvm vm)
        {
            var service = context.Services.Find(vm.Id);
                if (service == null)
                {
                    return NotFound();
                }
               
            if (!ModelState.IsValid) 
                return View(vm);
                mappper.Map(vm, service);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


        public IActionResult Delete(int id)
		{
			var con = context.Portfolios.Find(id);
			if (con is null) return RedirectToAction("Index");
            context.Portfolios.Remove(con);
            context.SaveChanges();
			return Ok(new {message= "ServiseDeleted" });
		}
	}
}
