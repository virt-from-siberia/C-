using System;

namespace OOP
{
    public class BankTerminal
    {
        
       protected string id;
       public BankTerminal(string id)
       {
           this.id = id;
       }
       public virtual void Connect()
        {
            Console.WriteLine("General Connecting Protocol");
        }
    }

    public class ModelXTerminal: BankTerminal
    {
        public ModelXTerminal(string id): base(id)
        {
        }
        public override void Connect()
        {
            base.Connect(); 
            Console.WriteLine("Additional for Model X");
        }
    }
    public class ModelYTerminal: BankTerminal
    {
        public ModelYTerminal(string id): base(id)
        {
        }
        public override void Connect()
        {
            Console.WriteLine("Additional for Model Y");
        }
    }
}