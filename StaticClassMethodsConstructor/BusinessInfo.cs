using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassMethodsConstructor
{
    class BusinessInfo
    {

        //BusinessInfo.cs

        //Fields(all static )
        //string _businessName; // Your choice
        //double _taxAmount;

        static string _businessName; 
        static double _taxAmount;


        //static constructor
        //Initialize both fields inside of the constructor
        static BusinessInfo()
        {
            
        }

        public static string BusinessName 
        { get => _businessName; set => _businessName = value; }
        public static double TaxAmount { get => _taxAmount; set => _taxAmount = value; }

       
    }
}
