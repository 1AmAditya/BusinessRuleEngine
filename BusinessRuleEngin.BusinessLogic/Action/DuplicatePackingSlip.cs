using BusinessRuleEngine.Common.Interface;
using BusinessRuleEngine.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.BusinessLayer
{
    /// <summary>
    /// DuplicatePackingSlip code will be written here
    /// </summary>
    class DuplicatePackingSlip : IAction
    {

        public bool TriggerAction(RequestModel requestModel)
        {
            //code
            return true;
        }
    }
}
