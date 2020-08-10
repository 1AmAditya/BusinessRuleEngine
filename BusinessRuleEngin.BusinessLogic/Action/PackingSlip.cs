using BusinessRuleEngine.Common.Interface;
using BusinessRuleEngine.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.BusinessLayer
{
    /// <summary>
    /// PackingSlip code will be written here
    /// </summary>
    public class PackingSlip : IAction
    {
        public bool TriggerAction(RequestModel requestModel)
        {
            //code
            return true;
        }
    }
}
