using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Customer
    {
        public Customer() : this(0) // constructor chaining (calling another constructor at a time of call of first constructor)
        { }
        public Customer(int customerId)
        {
            this.customerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int customerId { get; set; }
        public int customerType { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string fullName
        {
            get
            {
                return firstName + " " + LastName;
            }
        }

        private string _lastname;

        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public override string ToString() => fullName;
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(email)) isValid = false;

            return isValid;
        }
    }   
}
