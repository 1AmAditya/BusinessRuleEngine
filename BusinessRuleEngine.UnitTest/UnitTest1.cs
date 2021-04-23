using BusinessRuleEngin.Controllers;
using BusinessRuleEngine.BusinessLayer;
using BusinessRuleEngine.Common.Interface;
using BusinessRuleEngine.Common.Model;
using BusinessRuleEngine.RepositoryLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BusinessRuleEngine.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]///
        public void Payment_PhysicalProduct()
        {
            IRuleEngineParsing ruleEngineParsing = new RuleEngineParsing();
            IObjectResolver objectResolver = new ObjectResolver();

            IActionBuilder actionBuilder = new ActionBuilder(ruleEngineParsing, objectResolver);

            //Input

            RequestModel requestModel = new RequestModel()
            {
                Category = PaymentCategoryEnum.PhysicalProduct,
                Address = "Bangalore",
                UserID = 1,
                EmailAddress = "abc@gmail.com"
            };


            List<string> result = actionBuilder.ParseAction(requestModel);

            //Assert
            Assert.AreEqual(result[0], "PackingSlip");
            Assert.AreEqual(result[1], "CommissionPayment");
        }

        [TestMethod]
        public void Payment_Book()
        {
            IRuleEngineParsing ruleEngineParsing = new RuleEngineParsing();
            IObjectResolver objectResolver = new ObjectResolver();

            IActionBuilder actionBuilder = new ActionBuilder(ruleEngineParsing, objectResolver);

            //Input

            RequestModel requestModel = new RequestModel()
            {
                Category = PaymentCategoryEnum.Book,
                Address = "Bangalore",
                UserID = 1,
                EmailAddress = "abc@gmail.com",
                Book = "Stephen King"
            };


            List<string> result = actionBuilder.ParseAction(requestModel);

            //Assert
            Assert.AreEqual(result[0], "DuplicatePackingSlip");
            Assert.AreEqual(result[1], "CommissionPayment");
        }


        [TestMethod]
        public void Payment_Membership()
        {
            IRuleEngineParsing ruleEngineParsing = new RuleEngineParsing();
            IObjectResolver objectResolver = new ObjectResolver();

            IActionBuilder actionBuilder = new ActionBuilder(ruleEngineParsing, objectResolver);

            //Input

            RequestModel requestModel = new RequestModel()
            {
                Category = PaymentCategoryEnum.Membership,
                Address = "Bangalore",
                UserID = 1,
                EmailAddress = "abc@gmail.com"
            };


            List<string> result = actionBuilder.ParseAction(requestModel);

            //Assert
            Assert.AreEqual(result[0], "Email");
            Assert.AreEqual(result[1], "ActivateMembership");
        }


        [TestMethod]
        public void Payment_Upgrade()
        {
            IRuleEngineParsing ruleEngineParsing = new RuleEngineParsing();
            IObjectResolver objectResolver = new ObjectResolver();

            IActionBuilder actionBuilder = new ActionBuilder(ruleEngineParsing, objectResolver);

            //Input

            RequestModel requestModel = new RequestModel()
            {
                Category = PaymentCategoryEnum.Upgrade,
                Address = "Bangalore",
                UserID = 1,
                EmailAddress = "abc@gmail.com",
            };


            List<string> result = actionBuilder.ParseAction(requestModel);

            //Assert
            Assert.AreEqual(result[0], "Email");
            Assert.AreEqual(result[1], "UpgradeMembership");
        }

        [TestMethod]
        public void Payment_Video()
        {
            IRuleEngineParsing ruleEngineParsing = new RuleEngineParsing();
            IObjectResolver objectResolver = new ObjectResolver();

            IActionBuilder actionBuilder = new ActionBuilder(ruleEngineParsing, objectResolver);

            //Input

            RequestModel requestModel = new RequestModel()
            {
                Category = PaymentCategoryEnum.Video,
                Address = "Bangalore",
                UserID = 1,
                EmailAddress = "abc@gmail.com",
                Video = "LearningToSki"
            };


            List<string> result = actionBuilder.ParseAction(requestModel);

            //Assert
            Assert.AreEqual(result[0], "Add");
        }

    }
}
