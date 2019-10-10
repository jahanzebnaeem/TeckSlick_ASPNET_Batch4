namespace Teckslick.Batch4.Common
{
    #region References
    using System;
    using System.Collections.Generic;
    #endregion
    public class Person
    {
        #region Properties
        public int CNIC { get; set; }
        public String Name { get; set; }
        public int DateofBirth { get; set; }
        public Address CurrentAddress { get; set; }
        public Address PermanentAddress { get; set; }
        public List<ContactNumber> ContactNumbers { get; set; }
        #endregion

        #region Constructors
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
        #endregion
    }
}
