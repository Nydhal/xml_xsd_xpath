using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "/verify?xml={xml}&xsd={xsd}}")]
        string verify(string xml, string xsd);

        [OperationContract]
        [WebGet(UriTemplate = "/xpathsearch?xml={xml}&xpath={xpath}")]
        string xpathsearch(string xml, string xpath);
    }
}
