using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Prototype2
{
    /// <summary>
    /// The Person SEX Enum.
    /// </summary>
    public enum SEX
    {
        MALE,
        FEMALE
    }
    /// <summary>
    /// Family Class : This class is a collection of all the family members.
    /// </summary>
    class Family
    {
        /// <summary>
        /// The Internal Array List holding all the family members.
        /// </summary>
        private ArrayList m_FamilyMembers = new ArrayList();

        /// <summary>
        /// Family memers collection property.
        /// </summary>
        public ArrayList FamilyMembers
        {
            get { return m_FamilyMembers; }
            set { m_FamilyMembers = value; }
        }

        /// <summary>
        /// This function dumps the data of each family members on the console.
        /// </summary>
        public void ShowAllFamilyMembers()
        {
            //Write the count of family members.
            System.Console.WriteLine("No Of Members in Family :{0}", this.m_FamilyMembers.Count);
            //Write the information for each family member in the family.
            foreach (Person psTemp in this.m_FamilyMembers)
            {
                //Write the member info to console.
                System.Console.WriteLine("\t" + psTemp.ToString());
            }
        }
        /// <summary>
        /// The Entry point for the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //MyFamily object created.
            Family myfamily = new Family();
            //Create a object for a single person in the family.
            Person me = new Person();
            //Initialize the person information 
            me.FullName.FirstName = "Chris";
            me.FullName.MiddleName = "T.W";
            me.FullName.SurName = "Thant";
            me.Sex = SEX.MALE;
            me.HomeAddress.StreetName = "94 Seik Ta Thuka Street, #6A";
            me.HomeAddress.AreaName = "Tamwe";
            me.HomeAddress.City = "Kyaugh Myaung";
            me.HomeAddress.State = "Yangon";

            //Just copy Single person information to another since all the members 
            //from one family Share same address, Surname and Middle name too till some extent.
            Person Father = me.Clone() as Person;
            //Just update the Person Specific information.
            Father.FullName.FirstName = "Maung";
            Father.FullName.MiddleName = "Maung";

            //Do Same for mother.
            Person Mother = me.Clone() as Person;
            Mother.FullName.FirstName = "Khin";
            Mother.FullName.MiddleName = "Phyu Phyu";
            Mother.FullName.SurName = "Win";
            Mother.Sex = SEX.FEMALE;

            // Add all the person to make MyFamily complete.
            myfamily.m_FamilyMembers.Add(me);
            myfamily.m_FamilyMembers.Add(Father);
            myfamily.m_FamilyMembers.Add(Mother);

            //Check How is the family.
            myfamily.ShowAllFamilyMembers();
            //Get halt till enter.
            System.Console.Read();
        }
    }
}
