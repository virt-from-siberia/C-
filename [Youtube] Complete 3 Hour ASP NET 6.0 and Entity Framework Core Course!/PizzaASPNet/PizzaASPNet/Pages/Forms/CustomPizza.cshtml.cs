using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaASPNet.Model;

namespace PizzaASPNet.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzaModel Pizza { get; set; }

        public float Pizzaprice { get; set; }
        
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            Pizzaprice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) Pizzaprice += 1;
            if (Pizza.Cheese) Pizzaprice += 1;
            if (Pizza.Mashroom) Pizzaprice += 1;
            if (Pizza.Tuna) Pizzaprice += 1;
            if (Pizza.Pinapple) Pizzaprice += 10;
            if (Pizza.Ham) Pizzaprice += 1;
            if (Pizza.Peperoni) Pizzaprice += 1;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, Pizzaprice});
        }
    }
}