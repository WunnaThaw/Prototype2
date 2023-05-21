using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype2
{
    /// <summary>
    /// The Person class represents a mono unit from the family.
    /// this class holds the person properties such as name, sex and Address.
    /// </summary>
    class Person : ICloneable
    {
        /// <summary>
        /// The Name field
        /// </summary>
        private Name m_Name;

        /// <summary>
        /// Get and Set property for the name field.
        /// </summary>
        public Name FullName
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        /// <summary>
        /// Sex field of the person.
        /// </summary>
        private SEX m_Sex;
        /// <summary>
        /// The Get and Set property for the person's Sex.
        /// </summary>
        public SEX Sex
        {
            get { return m_Sex; }
            set { m_Sex = value; }
        }
        /// <summary>
        /// Person's Address field.
        /// </summary>
        private Address m_Address;

        /// <summary>
        /// Get and Set property for the address field.
        /// </summary>
        public Address HomeAddress
        {
            get { return m_Address; }
            set { m_Address = value; }
        }
        /// <summary>
        /// The dafault null argument constructor.
        /// </summary>
        public Person()
        {
            //Initialize the person object to blank.
            this.m_Name = new Name();
            this.m_Address = new Address();
            //set the Male as default sex.
            this.m_Sex = SEX.MALE;
        }
        /// <summary>
        /// The Function will create the exactly alike Person copy.
        /// </summary>
        /// <returns>reference to the new object.</returns>
        public object Clone()
        {
            //Create a new person object
            Person psTemp = new Person();
            //Copy current person information to new object member by member recursively.
            //In order to create a completely new person.
            psTemp.FullName = (Name)this.m_Name.Clone();
            psTemp.HomeAddress = this.m_Address.Clone() as Address;
            psTemp.Sex = this.Sex;
            //return the reference to new object.
            return psTemp;
        }
        /// <summary>
        /// This function returns the string based representation of the current
        /// object state.
        /// </summary>
        /// <returns>String representing the current object state.</returns>
        public override string ToString()
        {
            //Format the string and return.
            return this.m_Name.ToString() + " " + this.m_Sex.ToString() + " " + this.m_Address.ToString();
        }
    }
}
