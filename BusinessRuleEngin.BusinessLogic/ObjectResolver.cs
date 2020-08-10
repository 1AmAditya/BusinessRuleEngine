using BusinessRuleEngine.Common.Interface;
using BusinessRuleEngine.Common.Model;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace BusinessRuleEngine.BusinessLayer
{
    /// <summary>
    /// Use reflection to invoke method of respective action
    /// </summary>
    public class ObjectResolver : IObjectResolver
    {
        public bool CreateObject(string ClassName , string MethodName , RequestModel requestModel)
        {
            //Reflection
            string AssemblyName = "BusinessRuleEngine.BusinessLayer." + ClassName;
            Type obj = Type.GetType(AssemblyName);

            MethodInfo methodInfo = obj.GetMethod(MethodName);
            IAction classInstance = (IAction)Activator.CreateInstance(obj); //create instance of object
            
            //Parameter
            object[] parametersArray = new object[] { requestModel };

            //Invoke method
            return (bool)methodInfo.Invoke(classInstance, parametersArray);
        }
    }
}
