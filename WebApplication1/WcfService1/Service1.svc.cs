using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string verify(string xml, string xsd) {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(null, xsd);
                settings.ValidationType = ValidationType.Schema;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                settings.IgnoreWhitespace = true;

                XmlReader myxml = XmlReader.Create(xml, settings);
                XmlDocument document = new XmlDocument();
                document.Load(myxml);

                ValidationEventHandler eventHandler = new ValidationEventHandler(validate);

                // the following call to Validate succeeds.
                document.Validate(eventHandler);
                return "Validation Successfull !";
            }
            catch (Exception err)
            {
                return err.Message;
            }
            void validate(object sender, ValidationEventArgs e)
            {
                if (e.Severity == XmlSeverityType.Warning)
                    Console.WriteLine(" Warning" + e.Message);
                else // Error
                    Console.WriteLine(" Error message" + e.Message);
            }
        }

        public string xpathsearch(string xml, string xpath)
        {
            XPathDocument dx = new XPathDocument(xml);
            Console.WriteLine(dx);
            XPathNavigator nav = dx.CreateNavigator();
            string result = "";
            try {
                XPathNodeIterator iterator = nav.Select(xpath);
                while (iterator.MoveNext())
                {
                    string val = iterator.Current.Value;
                    result += val + Environment.NewLine + " \r\n";
                }
            } catch(Exception err)
            {
                return err.Message;
            }
            return result;
        }
    }
}
