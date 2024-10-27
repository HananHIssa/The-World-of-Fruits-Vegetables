using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QuickStart.DAL.Data;
using QuickStart.DAL.Data.Migrations;
using QuickStart.DAL.Data.Models;
using QuickStart.PL.Areas.Dashboard.ViewModels;
using QuickStart.PL.helpers;
using QuickStart.DAL.Data.Models;

namespace QuickStart.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ItemsController : Controller
    {

        private readonly ApplicationDbContext context;
        private readonly IMapper mappper;


        public ItemsController(ApplicationDbContext context, IMapper mappper)
        {
            this.context = context;
            this.mappper = mappper;
        }
        [HttpGet]
        public IActionResult Index()
        {
                var services = context.Items.Include(i => i.Portfolio).ToList();
                                      
                var mApping = mappper.Map<IEnumerable<vmItem>>(services);

                foreach (var item in mApping)
                {
                    item.PortfolioName = services.FirstOrDefault(s => s.Id == item.Id)?.Portfolio?.Name;
                }

                return View(mApping);

        }
        [HttpGet]
        public IActionResult Create()
        {
				var vm = new ItemsFormVm
				{
					portfolios = mappper.Map<IEnumerable<PortfolioFormVm>>(context.Portfolios.ToList())
				};

				return View(vm);

		}
		[HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ItemsFormVm vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            if (vm.Image != null)
            {
                vm.ImageName = FileSettings.UplodeFile(vm.Image, "images");
            }

            var services = mappper.Map<Item>(vm);
            context.Items.Add(services);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


		[HttpGet]
        public IActionResult Details (int id)
        {
			return View(mappper.Map<ItemDetailsvm>(context.Items.Find(id)));
		}
        public IActionResult Edit(int id)
        {
            var service = context.Items.Find(id);
            if (service == null)
            {
                return NotFound();
            }

            var vm = mappper.Map<ItemDetailsvm>(service);
            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ItemDetailsvm vm)
        {
            var service = context.Items.Find(vm.Id);
            if (service == null)
            {
                return NotFound();
            }

            if (vm.image == null)
            {
                ModelState.Remove("image");
            }
            else
            {
                FileSettings.Delete(vm.ImageName, "images");
                vm.ImageName = FileSettings.UplodeFile(vm.image, "images");
            }

            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            mappper.Map(vm, service);
            context.SaveChanges();
            return RedirectToAction("Index");
        }




        public IActionResult Delete(int id)
        {
            var con = context.Items.Find(id);

            if (con is null) return RedirectToAction("Index");
            FileSettings.Delete(con.ImageName, "images");
            context.Items.Remove(con);
            context.SaveChanges();
            return Ok(new { message = "ItemDeleted" });
        }
    }
}
