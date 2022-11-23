using System;

namespace WorkshopHandsOn13.Links
{
    class EndOfChain : ChainLink<int>
    {
        public override void Handle(int data)
        {
            Console.WriteLine("EndOfChain reached. Exception is raised!!!");
        }
        protected override bool CanHandle(int data)
        {
            return true;
        }
    }
}
