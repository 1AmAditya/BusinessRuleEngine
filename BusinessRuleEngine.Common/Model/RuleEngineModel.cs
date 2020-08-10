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

        public List<VideoDescription> VideoDetail { get; set; }

        [XmlElement(ElementName = "PaymentActionMatrix")]
        public PaymentActionMatrix PaymentActionMatrix = new PaymentActionMatrix();

        [XmlElement(ElementName = "VideoActionMatrix")]
        public VideoActionMatrix VideoActionMatrix = new VideoActionMatrix();
    }

    public class VideoActionMatrix //stage
    {

        [XmlElement(ElementName = "VideoDescription")]
        public List<VideoDescriptionAction> VideoDescription = new List<VideoDescriptionAction>();
    }

    public class VideoDescription
    {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }

    public class VideoDescriptionAction : VideoDescription
    {
        [XmlElement(ElementName = "Action")]
        public List<VideoAction> Action = new List<VideoAction>();
    }

    public class VideoAction : Action
    {
        [XmlElement(ElementName = "VideoDescription")]
        public List<VideoDescription> Action = new List<VideoDescription>();
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
