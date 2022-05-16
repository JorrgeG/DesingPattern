using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Generator;

namespace DesingPattermsAsp.Controllers
{
    public class GeneratorFileController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private GeneratorConcreteBuilder _generatorConcreteBuilder;
        public GeneratorFileController(IUnitOfWork unitOfWork, GeneratorConcreteBuilder generatorConcreteBuilder = null)
        {
            _unitOfWork = unitOfWork;
            _generatorConcreteBuilder = generatorConcreteBuilder;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int optionFile)
        {
            try
            {
                var beer = _unitOfWork.Beers.Get();
                List<string> content = beer.Select(d => d.Name).ToList();
                string paht = "file" + DateTime.Now.Ticks + new Random().Next(1000) + ".txt";
                var generatorDirector = new GeneratorDirector_(_generatorConcreteBuilder);
                if (optionFile == 1)
                {
                    generatorDirector.CreateSimpleJsonGenerator(content, paht);
                }
                else
                {
                    generatorDirector.CreateSimplePipeGenerator(content, paht);
                }
                var generator = _generatorConcreteBuilder.GetGenerator();
                generator.Save();
                return Json("Archivo generado");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
