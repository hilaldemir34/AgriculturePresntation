﻿using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View(new ServiceAddViewModel());//sayfa yüklendiğinde serviceaddviewmodel dönecek
        }
        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel model)
        {
            if (ModelState.IsValid)//model geçerliyse
            {
                _serviceService.Insert(new Service()
                {
                    Title = model.Title,
                    Image = model.Image,
                    Description = model.Description


                });
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }


        }
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.GetById(id);
            _serviceService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            var values = _serviceService.GetById(id);

            return View(values);

        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {

            _serviceService.Update(service);
            return RedirectToAction("Index");

        }

    }
}
