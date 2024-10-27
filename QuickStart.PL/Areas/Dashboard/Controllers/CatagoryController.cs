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
    public class CatagoryController : Controller
    {

		private readonly ApplicationDbContext context;
		private readonly IMapper mappper;


		public CatagoryController(ApplicationDbContext context,IMapper mappper)
		{
			this.context = context;
            this.mappper = mappper;
		}
        [HttpGet]
		public IActionResult Index()
        {
            var services = context.Catagories.ToList();
            var mApping= mappper.Map<IEnumerable<vmCatagory>>(services);
			return View(mApping);
        }
        [HttpGet]
        public IActionResult Create ()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
		public IActionResult Create(CatagoryFormVm vm)
		{
			if (!ModelState.IsValid)
			{
				return View(vm);
			}
			var portfolio = mappper.Map<Catagory>(vm);
			context.Catagories.Add(portfolio);
			context.SaveChanges();
			return RedirectToAction("Index");
		}


		[HttpGet]
        public IActionResult Details (int id)
        {
			return View(mappper.Map<CatagoryDetailsvm>(context.Catagories.Find(id)));
		}
        public IActionResult Edit(int id)
        {
            var service = context.Catagories.Find(id);
            if (service == null)
            {
                return NotFound();
            }

            var vm = mappper.Map<CatagoryDetailsvm>(service);
            return View(vm);
        }

        // تعديل الخدمة
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CatagoryDetailsvm vm)
        {
            var service = context.Catagories.Find(vm.Id);
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
			var con = context.Catagories.Find(id);
			if (con is null) return RedirectToAction("Index");
            context.Catagories.Remove(con);
            context.SaveChanges();
			return Ok(new {message= "ServiseDeleted" });
		}
	}
}
