using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype2
{
    /// <summary>
    /// Person's Address class. Address is a sort composed entity, with the member elements
    /// as StreetName,AreaName,City and State. This way this object forms a complex representation.
    /// </summary>
    class Address : ICloneable
    {
        /// <summary>
        /// The Street Name from the address.
        /// </summary>
        private string m_StreetName;
        /// <summary>
        /// get and set property for the StreetName.
        /// </summary>
        public string StreetName
        {
            get { return m_StreetName; }
            set { m_StreetName = value; }
        }
        /// <summary>
        /// Area Name field.
        /// </summary>
        private string m_AreaName;
        /// <summary>
        /// Get and Set proeprty for the area name.
        /// </summary>
        public string AreaName
        {
            get { return m_AreaName; }
            set { m_AreaName = value; }
        }
        /// <summary>
        /// City member from the address.
        /// </summary>
        private string m_City;
        /// <summary>
        /// Get and set property for the city field.
        /// </summary>
        public string City
        {
            get { return m_City; }
            set { m_City = value; }
        }
        /// <summary>
        /// State field from the address.
        /// </summary>
        private string m_State;
        /// <summary>
        /// Get and set property for the State field.
        /// </summary>
        public string State
        {
            get { return m_State; }
            set { m_State = value; }
        }
        /// <summary>
        /// Public address constructor.
        /// </summary>
        public Address()
        {
            //Simply initialize all the members to blank.
            this.m_StreetName = "";
            this.m_AreaName = "";
            this.m_City = "";
            this.m_State = "";
        }

        /// <summary>
        /// This function will copy the current address field to the new object.
        /// And will copy the current object content member by member to new object.
        /// </summary>
        /// <returns>reference to new object</returns>
        public object Clone()
        {
            //Create a new address object.
            Address adrsTemp = new Address();
            //Copy current object content one by one to new object.
            adrsTemp.StreetName = this.m_StreetName;
            adrsTemp.AreaName = this.m_AreaName;
            adrsTemp.City = this.m_City;
            adrsTemp.State = this.m_State;
            //return the reference to new object.
            return adrsTemp;
        }
        /// <summary>
        /// The function will return the a string representing the current object state.
        /// </summary>
        /// <returns>A string representing the current object state.</returns>
        public override string ToString()
        {
            //Form a string form the current object state.
            return this.m_StreetName + "," +
                this.m_AreaName + "," +
                this.m_City + "," +
                this.m_State;
        }
    }
}
