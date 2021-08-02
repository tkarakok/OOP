using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCredit = new PersonalFinanceCredit();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager homeCreditManager = new HomeCreditManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new DatabaseLoggerService();

            SubmitManager submitManager = new SubmitManager();
            submitManager.ApplicationSubmit(personalFinanceCredit , fileLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCredit, vehicleCreditManager, homeCreditManager};

            //submitManager.GiveAdvanceNotice(credits);
        }
    }
}
