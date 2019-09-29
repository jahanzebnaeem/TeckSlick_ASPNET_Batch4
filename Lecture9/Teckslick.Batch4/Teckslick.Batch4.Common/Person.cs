using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teckslick.Batch4.Common
{
    public class Person
    {
        public int CNIC { get; set; }
        public String Name { get; set; }
        public int DateofBirth { get; set; }
        public Address CurrentAddress { get; set; }
        public Address PermanentAddress { get; set; }
        public List<ContactNumber> ContactNumbers { get; set; }

        public Person() { }
        public Person(int cnic, string name, int dob, Address currentAddress, Address permanentAddress)
        {
            CNIC = cnic;
            Name = name;
            DateofBirth = dob;
            CurrentAddress = currentAddress;
            PermanentAddress = permanentAddress;
        }
        public Person(int cnic, string name, int dob, Address currentAddress, Address permanentAddress, List<ContactNumber> contacts) : this(cnic, name, dob, currentAddress, permanentAddress)
        {
            ContactNumbers = contacts;
        }
    }
}
