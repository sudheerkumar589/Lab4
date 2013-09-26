using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WcfService7
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    //creating a simple arithmetic operations using restful service and providing the uriTemplate
    [ServiceContract]
    public interface Icalculator
    {

        [OperationContract]

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Add/{a}/{b}")]

        string Add(string a, string b);

        [OperationContract]

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Subtract/{a}/{b}")]

        string Subtract(string a, string b);

        [OperationContract]

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Multiply/{a}/{b}")]

        string Multiply(string a, string b);

        [OperationContract]

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Divide/{a}/{b}")]

        string Divide(string a, string b);

        // TODO: Add your service operations here
    }
}




