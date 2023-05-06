using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Documents;

namespace StaticClassMethodsConstructor
{

    class DailyTransaction
    {
        //Fields( static )
        //List<Transaction> _transactions;
        
        private static List<Transaction> _transactions;

        //static Constructor
        //Initialize list inside of the static constructor

        static DailyTransaction()
        {
            _transactions = new List<Transaction>(); 
        }
        //Method
        //static void AddTransaction()
        
        public static void  AddTransaction()
        {
            
           List<double> Cost = new List<double>();

        }

        //double CalculateTotal() // total all the transactions and return the amount with tax added
        static double CalculateTotal(double a , double b)
        {
            return a += b; 
        }



        //void DisplayAllInfo()
        //Print all transactions and then the total after taxes
        static void DisplayAllInfo()
        {
          
        }
        
    }
}
