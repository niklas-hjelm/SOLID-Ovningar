using System;

namespace WorkshopHandsOn13.Links
{
    class TheBoss : ChainLink<int>
    {
        public override void Handle(int data)
        {
            if (!this.CanHandle(data))
            {
                this.TrySuccessor(data);
                return;
            }

            Console.WriteLine("Handled by The Boss. No problem, spend money!");
        }
        protected override bool CanHandle(int data)
        {
            return data > 2000 && data <= 10000;
        }
    }
}
