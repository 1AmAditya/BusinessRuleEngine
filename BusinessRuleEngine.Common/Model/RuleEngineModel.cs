using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BusinessRuleEngine.Common.Model
{
    /// <summary>
    /// Rule Engine object to deserialize the xml into RuleEngine object
    /// </summary>
    public class RuleEngine
    {
        public List<PaymentCategory> Payment { get; set; }
        public List<Action> PaymentAction { get; set; }

        [XmlElement(ElementName = "PaymentActionMatrix")]
        public PaymentActionMatrix PaymentActionMatrix = new PaymentActionMatrix();
    }

    public class PaymentActionMatrix 
    {

        [XmlElement(ElementName = "PaymentCategory")]
        public List<PaymentCategory> PaymentCategory = new List<PaymentCategory>();
    }

    public class Action
    {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }

    public class PaymentCategory
    {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Action")]
        public List<Action> Action = new List<Action>();
    }
}
