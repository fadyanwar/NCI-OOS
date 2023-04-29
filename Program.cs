using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //Console.WriteLine("First Name: {0}\nLast Name: {1}", fady.FirstName, fady.LastName);
            //fady.SendMessage("Hello buddy!");
            //Console.WriteLine("Recieved Message: {0}", fady.GetMessage());



            
            Person fady = new Person();
            fady.FirstName = "Fady";
            fady.LastName = "Anwar";

            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";

            Employee employee = new Employee();
            employee.FirstName = "Jane";
            employee.LastName = "Doe";
            //employee.ShowDetails();

            Account parentAccount = new Account(john);
            parentAccount.AccountOwner = employee;

            Account fadysAccount = new Account(fady, employee, parentAccount);
            fadysAccount.AddBalance(100);
            fadysAccount.ShowBalance();


            Console.WriteLine("Account Holder Details:");
            fadysAccount.AccountHolder.ShowDetails();
            Console.WriteLine("Parent Account Holder Details:");
            fadysAccount.ParentAccount.AccountHolder.ShowDetails();
            Console.WriteLine("Parent Account Owner Details:");
            fadysAccount.ParentAccount.AccountOwner.ShowDetails();
            Console.ReadKey();
        }
    }
}
