using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QuickStart.DAL.Data;
using QuickStart.DAL.Data.Models;
using QuickStart.PL.Areas.Dashboard.ViewModels;
using QuickStart.PL.helpers;

namespace QuickStart.PL.Areas.Dashboard.Controllers
{		
    [Area("Dashboard")]
    public class ProductController : Controller
    {

		private readonly ApplicationDbContext context;
		private readonly IMapper mappper;
		public ProductController(ApplicationDbContext context,IMapper mappper)
		{
			this.context = context;
            this.mappper = mappper;
		}
        [HttpGet]
		public IActionResult Index()
        {
            var services = context.Products.ToList();
            var mApping= mappper.Map<IEnumerable<vmProduct>>(services);
			return View(mApping);
        }
        [HttpGet]
        public IActionResult Create ()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
		public IActionResult Create(ProductFormVm vm)
		{
			if (!ModelState.IsValid)
			{
				return View(vm);
			}

			if (vm.Image != null)  
			{
				vm.ImageName = FileSettings.UplodeFile(vm.Image, "images");
			}

			var services = mappper.Map<Product>(vm);
			context.Products.Add(services);
			context.SaveChanges();
			return RedirectToAction("Index");
		}


		[HttpGet]
        public IActionResult Details (int id)
        {
			return View(mappper.Map<ProductDetailsvm>(context.Products.Find(id)));
		}
        public IActionResult Edit(int id)
        {
            var service = context.Products.Find(id);
            if (service == null)
            {
                return NotFound();
            }

            var vm = mappper.Map<ProductDetailsvm>(service);
            return View(vm);
        }

        // تعديل الخدمة
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductDetailsvm vm)
        {
            var service = context.Products.Find(vm.Id);
                if (service == null)
                {
                    return NotFound();
                }
                if(vm.image==null)
                {
                ModelState.Remove("image");
                }
                else
                {
                FileSettings.Delete(vm.ImageName, "images");
                vm.ImageName = FileSettings.UplodeFile(vm.image, "images");

                }
            if (!ModelState.IsValid) return View(vm);
                // تحديث البيانات
                mappper.Map(vm, service);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


        public IActionResult Delete(int id)
		{
			var con = context.Products.Find(id);

			if (con is null) return RedirectToAction("Index");
			FileSettings.Delete(con.imageName, "images");
            context.Products.Remove(con);
            context.SaveChanges();
			return Ok(new {message= "ServiseDeleted" });
		}
	}
}
