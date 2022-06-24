using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Customer
    {
        private string firstName;
        private string lastName;

        public string GetFullName(string firstName , string lastName )
        {
            return lastName +" "+ firstName ;
        }
    }
}
