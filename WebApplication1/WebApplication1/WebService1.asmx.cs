using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        [WebMethod]
        public int BinaryCalculator(int DecimalInput)
        {
            try
            {

            
            int x = DecimalInput;
            string binary = "";

            while (x >= 1)
            {
                if (x % 2 == 1)
                {
                    binary = binary + "1";
                }else if (x % 2 == 0)
                {
                    binary = binary + "0";
                }

                x = x / 2;
            }
            return int.Parse(ReverseString(binary));

            }catch (Exception ex)
            {
                throw new System.ArgumentException(ex.Message);
            }
        }

        [WebMethod]
        public int HexCalculator(int DecimalInput)
        {
            return DecimalInput;
        }

        [WebMethod]
        public int OctalCalculator(int DecimalInput)
        {
            return DecimalInput;
        }
    }
}
