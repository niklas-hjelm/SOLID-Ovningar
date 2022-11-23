using System;
using WorkshopHandsOn13.Links;

namespace WorkshopHandsOn13
{
    class ExpenseService : IExpenseService
    {
        IChainLink<int> _chain;

         public static IExpenseService Create()
         {
             return new ExpenseService();
         }
         private ExpenseService()
        {
            this._chain = new Developer()
                .SetSuccessor(new TeamLeader()
                .SetSuccessor(new TheBoss()
                .SetSuccessor(new Economist()
                .SetSuccessor(new EndOfChain()))));
        }
        public void Execute(int sum)
        {
            this._chain.Handle(sum);
        }
    }
}
