using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.classes
{
    class TestClass
    {
        static int Main(string[] args)
        {
            string test1 = "https://storeteespring.myshopify.com/admin/apps/teescape-fulfillment/active/Shopify/home.asp";
            string test2 = "https://storeteespring.myshopify.com/admin/auth/login/apps/teescape-fulfillment";
            string textLen = ".myshopify.com";
            test1 = test1.Substring(0, test1.IndexOf("myshopify.com"))+textLen;
            test2 = test2.Substring(0, test2.IndexOf("myshopify.com")) + textLen;

            Console.WriteLine("Hello cuong test1:"+ test1);
            Console.WriteLine("Hello cuong test2:" + test2);

            return 0;
        }
    }
}
