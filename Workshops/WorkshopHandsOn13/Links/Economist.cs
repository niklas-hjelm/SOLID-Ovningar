using System;

namespace WorkshopHandsOn13.Links
{
    class Economist : ChainLink<int>
    {
        public override void Handle(int data)
        {
            if (!this.CanHandle(data))
            {
                this.TrySuccessor(data);
                return;
            }

            Console.WriteLine("Handled by Economist. No expenses are allowed!");
        }
        protected override bool CanHandle(int data)
        {
            return true;
        }
    }
}
