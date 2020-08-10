using BusinessRuleEngine.Common.Interface;
using BusinessRuleEngine.Common.Model;
using System;
using System.Data;
using System.IO;
using System.Reflection;

namespace BusinessRuleEngine.RepositoryLayer
{
    public class RuleEngineParsing : IRuleEngineParsing
    {

        public RuleEngineParsing()
        {
            //one time load of xml
            GetRuleEngine = RuleEnginParser();
        }
        public RuleEngine GetRuleEngine { get; }

        private RuleEngine RuleEnginParser()
        {
            try
            {
                //Rule Engine object to deserialize the xml into RuleEngine object
                System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(RuleEngine));
                using (StreamReader sr = new StreamReader(AssemblyDirectory + @"\RuleEngine.xml"))
                {
                    return (RuleEngine)ser.Deserialize(sr);
                }
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Get current Assembly directory
        /// </summary>
        private string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
    }
}
