using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaASPNet.Model;

namespace PizzaASPNet.Pages
{
    public class Pizza : PageModel
    {

        public List<PizzaModel> fakePizzaDB = new List<PizzaModel>()
        {
            new PizzaModel(){
                ImageTitle = "Margerita",
                PizzaName = "Margerita",
                BasePrice = 2 ,
                TomatoSauce = true, 
                Cheese = true,
                FinalPrice = 4
            },
            new PizzaModel(){
                ImageTitle = "Carbonara",
                PizzaName = "Carbonara",
                BasePrice = 2 ,
                TomatoSauce = true, 
                Peperoni = true,
                Cheese = true,
                FinalPrice = 4
            },
            new PizzaModel(){
                ImageTitle = "Bolognese",
                PizzaName = "Bolognese",
                BasePrice = 3 ,
                TomatoSauce = true,
                Cheese = true,
                Mashroom = true,
                FinalPrice = 5
            },
            new PizzaModel(){
            ImageTitle = "Mushroom",
            PizzaName = "Mushroom",
            BasePrice = 3 ,
            TomatoSauce = true,
            Cheese = true,
            Mashroom = true,
            FinalPrice = 5
            },
            new PizzaModel(){
                ImageTitle = "SeaFood",
                PizzaName = "SeaFood",
                BasePrice = 3 ,
                TomatoSauce = true,
                Cheese = true,
                Mashroom = true,
                FinalPrice = 5
            }
        };
        
        public void OnGet()
        {
            
        }
    }
}