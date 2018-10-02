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
        public long BinaryCalculator(long DecimalInput)
        {
            try
            {


                long x = DecimalInput;
                string binary = "";

                while (x >= 1)
                {
                    if (x % 2 == 1)
                    {
                        binary = binary + "1";
                    }
                    else if (x % 2 == 0)
                    {
                        binary = binary + "0";
                    }

                    x = x / 2;
                }
                return long.Parse(ReverseString(binary));

            }
            catch (Exception ex)
            {
                throw new System.ArgumentException(ex.Message);
            }
        }

        [WebMethod]
        public string HexCalculator(long DecimalInput)
        {
            return DecimalInput.ToString("X");
        }

        [WebMethod]
        public string OctalCalculator(long DecimalInput)
        {
            long x = DecimalInput;
            long rem = 0;
            string result = string.Empty;

            while (x > 0)
            {
                rem = x % 8;
                x = x / 8;
                result = rem.ToString() + result;

            }

            return result;
        }

        [WebMethod]
        public string FullCalculator(long DecimalInput)
        {
            string returnstring = "";

            try
            {


                long x = DecimalInput;
                string binary = "";

                while (x >= 1)
                {
                    if (x % 2 == 1)
                    {
                        binary = binary + "1";
                    }
                    else if (x % 2 == 0)
                    {
                        binary = binary + "0";
                    }

                    x = x / 2;
                }

                long y = DecimalInput;
                long rem = 0;
                string result = string.Empty;

                while (y > 0)
                {
                    rem = y % 8;
                    y = y / 8;
                    result = rem.ToString() + result;

                }


                returnstring = returnstring + "Binary: "+ ReverseString(binary) + ", Hexadecimal: " + DecimalInput.ToString("X") + ", Octal: " + result;
                
            }
            catch
            {

            }

            return returnstring;

        }
    }
}
