using System;

namespace WorkshopHandsOn13.Links
{
    class TeamLeader : ChainLink<int>
    {
        public override void Handle(int data)
        {
            if (!this.CanHandle(data))
            {
                this.TrySuccessor(data);
                return;
            }

            Console.WriteLine("Handled by TeamLeader. No problem, spend money!");
        }
        protected override bool CanHandle(int data)
        {
            return data > 500 && data <= 2000;
        }
    }
}
