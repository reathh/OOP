using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Customer : ICloneable, IComparable<Customer>
    {
        private const string currency = "bgn";

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public string PermAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public IList<Payment> Payments{ get; set; }
        public CustomerType Type { get; set; }

        public Customer(string firstName, string middleName, string lastName, string id, string permAddress, string mobilePhone, string email, IList<Payment> payments, CustomerType type)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.PermAddress = permAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = payments;
            this.Type = type;
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            if (this.ID == customer.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }
        public override string ToString()
        { 
            StringBuilder output = new StringBuilder();
            output.AppendLine(String.Format("Customer ID:{0}(First name: {1}, Middle name: {2}, Last name: {3}, Permanent address: {4}, Mobile phone: {5}, Email: {6}, Type: {7}", this.ID, this.FirstName, this.MiddleName, this.LastName, this.PermAddress, this.MobilePhone, this.Email, this.Type));
            output.AppendLine(new string('-', 5) + "Payments:");
            foreach (var payment in this.Payments)
            {
                output.AppendLine(new string('-', 2) + payment.ProductName + ":" + payment.Price + Customer.currency);
            }
            return output.ToString();
        }
        public static bool operator ==(Customer c1, Customer c2)
        {
            return c1.Equals(c2);
        }
        public static bool operator !=(Customer c1, Customer c2)
        {
            return !(c1.Equals(c2));
        }

        public object Clone()
        {
            var payments = new List<Payment>();
            foreach (var payment in this.Payments)
            {
                payments.Add((Payment)payment.Clone());
            }
            return new Customer(this.FirstName, this.MiddleName, this.LastName, this.ID, this.PermAddress, this.MobilePhone, this.Email, payments, this.Type);
        }

        public int CompareTo(Customer other)
        {
            string thisFullName = this.FirstName + this.MiddleName + this.LastName;
            string otherFullName = other.FirstName + other.MiddleName + other.LastName;

            int output = thisFullName.CompareTo(otherFullName);

            if (output == 0)
            {
                return this.ID.CompareTo(other.ID);
            }
            return output;
            
        }
    }
}
