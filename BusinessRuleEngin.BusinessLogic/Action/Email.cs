using BusinessRuleEngine.Common.Interface;
using BusinessRuleEngine.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.BusinessLayer
{
    /// <summary>
    /// Code to send email to user
    /// </summary>
    class Email : IAction
    {
        public bool TriggerAction(RequestModel requestModel)
        {
            //Code
            return true;
        }
    }
}
