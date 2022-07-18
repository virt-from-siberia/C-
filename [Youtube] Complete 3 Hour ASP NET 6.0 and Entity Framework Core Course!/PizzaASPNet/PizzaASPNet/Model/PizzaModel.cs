namespace PizzaASPNet.Model
{
    public class PizzaModel
    {
            public string ImageTitle { get; set; }

            public string PizzaName { get; set; }
            public float BasePrice { get; set; } = 2;
            
            public bool Mashroom { get; set; }
            public bool TomatoSauce { get; set; }
            
            public bool Tuna { get; set; }
            
            public bool Pinapple { get; set; }
            
            public bool Ham { get; set; }
            
            public bool Cheese { get; set; }
            
            public bool Peperoni { get; set; }
            
            public float FinalPrice { get; set; }
            
            
    }
}