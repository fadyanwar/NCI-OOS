using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp
{
    public class Person
    {
        public string LastName;
        public string FirstName;
        private string message;

        public void SendMessage(string message)
        {
            this.message = message;
        }
        public string GetMessage()
        {
            return message;
        }
        public void ShowDetails()
        {
            Console.WriteLine("First Name: {0}\nLast Name: {1}", this.FirstName, this.LastName);
        }
    }
}
