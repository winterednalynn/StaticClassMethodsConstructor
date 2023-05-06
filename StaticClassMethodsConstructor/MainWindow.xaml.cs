using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StaticClassMethodsConstructor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //     Main

            // On the main page add at least 5 transactions to your list inside of DailyTransactions.

            //Call the DisplayAllInfo() method from DailyTransactions.

            //This should Display the time and amount of each transaction.

            // At the start top of your application, display your Business Name(the one stored in your BusinessInfo.cs class )
            BusinessInfo.BusinessName = "CashCash";
            runDisplay.FontSize = 24;
            runDisplay.FontWeight = FontWeights.Bold;
            runDisplay.Text = BusinessInfo.BusinessName;

            

            List<string> transactionList = new List<string>();
            transactionList.Add("Banana");
            transactionList.Add("Nuts");
            transactionList.Add("Flour");
            transactionList.Add("Sugar");
            transactionList.Add("Yeast");

            foreach  (string items in transactionList)
            {
                lbFoodItems.Items.Add(items);
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // My goal was to select an item on the Listbox ; prompt the cost and add it up but I am lost on how to code that :( 
            
           
        }
    }
}
