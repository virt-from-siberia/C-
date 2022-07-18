using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaASPNet.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class Checkout : PageModel
    {
        public string PizzaName { get; set; }

        public float PizzaPrice { get; set; }

        public string ImageTitle { get; set; }
        
        public string About { get; set; }
        
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
                PizzaName = "Custom";

            if (string.IsNullOrWhiteSpace(ImageTitle))
                ImageTitle = "Create";
            
            if (string.IsNullOrWhiteSpace(ImageTitle))
                ImageTitle = "About";
        }
    }
}