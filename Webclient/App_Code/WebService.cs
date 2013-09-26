using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    [WebMethod]
    public float add(float num1, float num2)
    {
        return num1 + num2;

    }
    
    [WebMethod]
    public float sub(float num1, float num2)
    {
        return num1 - num2;

    }

    [WebMethod]
    public float multiply(float num1, float num2)
    {
        return num1 * num2;

    }
    
    [WebMethod]
    public float div(float num1, float num2)
    {
        return num1 / num2;

    }
}
