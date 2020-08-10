using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessRuleEngine.Common.Interface;
using BusinessRuleEngine.Common.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BusinessRuleEngin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
        private IActionBuilder _actionBuilder;
        public PaymentController(IActionBuilder actionBuilder)
        {
            _actionBuilder = actionBuilder;
        }

        [HttpPost]
        public IActionResult PaymentAction(RequestModel requestModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Model validation failed"); 
            }
            List<string> result = _actionBuilder.ParseAction(requestModel);

            return Ok(result);
        }
    }
}
