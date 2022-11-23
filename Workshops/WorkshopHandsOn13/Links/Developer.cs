using System;

namespace WorkshopHandsOn13.Links
{
    class Developer : ChainLink<int>
    {
        public override void Handle(int data)
        {
            if (!this.CanHandle(data))
            {
                this.TrySuccessor(data);
                return;
            }

            Console.WriteLine("Handled by Developer!");
        }
        protected override bool CanHandle(int data)
        {
            return data <= 500;
        }
    }
}
