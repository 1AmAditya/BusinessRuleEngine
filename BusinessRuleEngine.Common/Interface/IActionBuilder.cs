using BusinessRuleEngine.Common.Model;
using System.Collections.Generic;

namespace BusinessRuleEngine.Common.Interface
{
    public interface IActionBuilder
    {
        List<string> ParseAction(RequestModel requestModel);
    }
}
