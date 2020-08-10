using BusinessRuleEngine.Common.Interface;
using BusinessRuleEngine.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BusinessRuleEngine.BusinessLayer
{
    public class ActionBuilder : IActionBuilder
    {
        #region Private Variable
        private IRuleEngineParsing _ruleEngineParsing;
        private RuleEngine _ruleEngineModel;
        private IObjectResolver _objectResolver;
        #endregion


        public ActionBuilder(IRuleEngineParsing ruleEngineParsing , IObjectResolver objectResolver)
        {
            _ruleEngineParsing = ruleEngineParsing;
            _objectResolver = objectResolver;
        }

        /// <summary>
        /// Parse action based on action category
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        public List<string> ParseAction(RequestModel requestModel)
        {
            List<string> ActionList = new List<string>();
            string TriggeredActionMethod = "TriggerAction"; // triggered action method name
            try
            {
                _ruleEngineModel = _ruleEngineParsing.GetRuleEngine;

                if(_ruleEngineModel == null)
                {
                    //if xml parsing fail
                    return null;
                }

                PaymentCategory paymentCategory = _ruleEngineModel.PaymentActionMatrix.PaymentCategory.Where(s => s.ID == (int)requestModel.Category).FirstOrDefault();

                foreach (var item in paymentCategory.Action)
                {
                    //use reflection to invoke method of class specified in rule engine xml
                    bool result = _objectResolver.CreateObject(item.Name, TriggeredActionMethod, requestModel);

                    if(result == true)
                    {
                        ActionList.Add(item.Name);
                    }


                }
                return ActionList;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}
