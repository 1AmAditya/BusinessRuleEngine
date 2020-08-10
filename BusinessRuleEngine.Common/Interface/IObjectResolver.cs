using BusinessRuleEngine.Common.Model;

namespace BusinessRuleEngine.Common.Interface
{
    public interface IObjectResolver
    {
        bool CreateObject(string ClassName, string MethodName, RequestModel requestModel);
    }
}
