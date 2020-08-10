using BusinessRuleEngine.Common.Model;

namespace BusinessRuleEngine.Common.Interface
{
    public interface IAction
    {
        bool TriggerAction(RequestModel requestModel);
    }
}
