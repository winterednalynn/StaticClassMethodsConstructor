using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StaticClassMethodsConstructor
{
    class Transaction
    {
        //Create a class: Transaction

        //Fields
        //DateTime _now = DateTime.Now;
        DateTime _now = DateTime.Now;

        //string _name
        static string _name;


        //double _amount;
        static double _amount;

        //Constructor
        //Transaction(name, amount);

        static Transaction()
        {
            
        }

        //Property
        //Get for both

        public static string Name
        {
            get => _name; 
            set => _name = value;
        }

        public static double Amount
        {
            get => _amount;
            set => _amount = value;
        }

        //Override ToString() to show Name - Datetime.Short - Amount(use.ToString("c")
        public override string ToString()
        {
            return $"Name : {_name} -{DateTime.Now} - Amount: {_amount}"; 
        }

       
    }
}
