using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesingPattermsAsp.Models.ViewModels;
using DesingPattermsAsp.Strategy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesingPattermsAsp.Controllers
{
    public class BeerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<BeerViewModel> beers = from d in _unitOfWork.Beers.Get()
                                               select new BeerViewModel
                                               {
                                                   Id = d.BeerId,
                                                   Name = d.Name,
                                                   Style = d.Style
                                               };
            return View("Index", beers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            GetBrandsData();
            return View();
        }

        [HttpPost]
        public IActionResult Add(FormViewModel formView)
        {
            if (!ModelState.IsValid)
            {
                GetBrandsData();
                return View("Add", formView);
            }

            var context = formView.BrandId == null 
                ? new BeerContext(new BeerWithBrandStrategy()) 
                : new BeerContext(new BeerStrategy());

            context.Add(formView, _unitOfWork);
            return RedirectToAction("Index");
        }

        #region HELPERS
        private void GetBrandsData()
        {
            var brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
        }
        #endregion
    }
}
