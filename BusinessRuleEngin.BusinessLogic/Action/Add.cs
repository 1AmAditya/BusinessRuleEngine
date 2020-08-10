using BusinessRuleEngine.Common.Interface;
using BusinessRuleEngine.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine.BusinessLayer
{
    class Add : IAction
    {
        public bool TriggerAction(RequestModel requestModel)
        {
            //Add free video with brought video
            return true;
        }
    }
}
