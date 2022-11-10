using BusineesLayer.Concrete;
using BusineesLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new PortfolioRepository());
        public IActionResult Index()
        {
            ViewBag.value1 = "Portfolio List";
            ViewBag.value2 = "Portfolio";
            var values = portfolioManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.value1 = "Adding Portfolio";
            ViewBag.value2 = "Portfolio";
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(EntityLayer.Concrete.Portfolio portfolio)
        {
            //validations
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(portfolio);
            if (results.IsValid)
            {
                portfolioManager.Add(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeletePortfolio(int id)
        {
            var value = portfolioManager.GetById(id);
            portfolioManager.Delete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            ViewBag.value1 = "Updating Portfolio";
            ViewBag.value2 = "Portfolio";
            var value = portfolioManager.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(EntityLayer.Concrete.Portfolio portfolio)
        {
            //validations
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(portfolio);
            if (results.IsValid)
            {
                portfolioManager.Update(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
