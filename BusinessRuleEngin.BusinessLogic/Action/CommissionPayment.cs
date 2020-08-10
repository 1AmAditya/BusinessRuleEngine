using BusinessRuleEngine.Common.Interface;
using BusinessRuleEngine.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.BusinessLayer
{
    /// <summary>
    /// Commission payment code will be written here
    /// </summary>
    class CommissionPayment : IAction
    {
        public bool TriggerAction(RequestModel requestModel)
        {
            //Code
            return true;
        }
    }
}
