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
            Console.WriteLine("Connecting to protocol");
        }
    }

    public class ModelXTerminal : BankTerminal
    {
        public ModelXTerminal(string id) : base(id) {
        }
        
        public override void Connect()
        {
            base.Connect();
            Console.WriteLine("Additional actions for modelX");
        }
    }
    public class ModelYTerminal : BankTerminal
    {
        public ModelYTerminal(string id) : base(id) {
        }
        
        public override void Connect()
        {
            Console.WriteLine("Additional actions for modelY");
        }
    }
}