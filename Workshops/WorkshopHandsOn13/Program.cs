using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkshopHandsOn13
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpenseService service = ExpenseService.Create();
            service.Execute(100001);

            Console.ReadKey();
        }
    }
}
