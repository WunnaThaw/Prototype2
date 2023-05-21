using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype2
{
    /// <summary>
    /// The Person's Name class. The name is a full name of the person
    /// Composed from the First Name,Middle name and Last Name.
    /// </summary>
    class Name : ICloneable
    {
        /// <summary>
        /// The First name string of the Name.
        /// </summary>
        private string m_FirstName;
        /// <summary>
        /// Get and set property for the FirstName.
        /// </summary>
        public string FirstName
        {
            get { return m_FirstName; }
            set { m_FirstName = value; }
        }
        /// <summary>
        /// Person's Middle Name.
        /// </summary>
        private string m_MiddleName;
        /// <summary>
        /// Get and Set property for the Middle Name.
        /// </summary>
        public string MiddleName
        {
            get { return m_MiddleName; }
            set { m_MiddleName = value; }
        }
        /// <summary>
        /// Person'd Last/sur name.
        /// </summary>
        private string m_SurName;
        /// <summary>
        /// Get and Set the property for the last/sur name.
        /// </summary>
        public string SurName
        {
            get { return m_SurName; }
            set { m_SurName = value; }
        }
        /// <summary>
        /// This method will clone the current Name object to the new object.
        /// </summary>
        /// <returns>Object</returns>
        public object Clone()
        {
            //Create a new name object
            Name nameTemp = new Name();
            //Copy the current object content member by member to new object
            nameTemp.FirstName = this.m_FirstName;
            nameTemp.MiddleName = this.MiddleName;
            nameTemp.SurName = this.SurName;
            //return new object.
            return nameTemp;
        }
        /// <summary>
        /// This function will return the current object content in the string format.
        /// </summary>
        /// <returns>object content as a String representation</returns>
        public override string ToString()
        {
            //Format the string in the required format and return.
            return this.m_FirstName + " " + this.m_MiddleName + " " + this.m_SurName;
        }
    }
}
