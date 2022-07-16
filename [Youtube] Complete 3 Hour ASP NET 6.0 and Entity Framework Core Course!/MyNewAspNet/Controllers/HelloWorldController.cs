using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyNewAspNet.Models;

namespace MyNewAspNet.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET
        // public IActionResult Index()

        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            // DogViewModel doggo = new DogViewModel() {Name = "Sif", Age = 2};
            return View(dogs);
        }

        public string Hello() 
        {
            return "Who is there ?";
        }

        public IActionResult createDog(DogViewModel dogViewModel)
        {
            Console.WriteLine($"dogViewModel, {dogViewModel}");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }
    }
}