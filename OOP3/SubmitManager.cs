using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SubmitManager
    {
        public void ApplicationSubmit(ICreditManager creditManager, ILoggerService loggerService)
        {
            // başvuran bilgileri
            creditManager.Calculate();
            loggerService.Log();
        }
        public void GiveAdvanceNotice(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
