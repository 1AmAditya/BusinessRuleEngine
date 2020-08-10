using BusinessRuleEngine.Common.Interface;
using BusinessRuleEngine.Common.Model;
using System;

namespace BusinessRuleEngine.BusinessLayer
{
    /// <summary>
    /// Actionation membership action code will be written here
    /// </summary>
    public class ActivateMembership : IAction
    {
        public bool TriggerAction(RequestModel requestModel)
        {
            //Activation membership code
            return true;
        }
    }
}
