using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Programming_Assignment___Hunter
{
    internal class Student : IComparable<Student>
    {
        private static Random generator = new Random();
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _studentNumber;
        public Student(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._studentNumber = 555000 + generator.Next(0, 1000);
            GenerateEmail();
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                this._firstName=value;
                GenerateEmail();
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                this._lastName = value;
                GenerateEmail();
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
        }
        public int StudentNumber
        {
            get 
            { 
                return _studentNumber; 
            }
        }
        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }
        public void ResetStudentNumber()
        {
            this._studentNumber = 555000 + generator.Next(0, 1000);
            GenerateEmail();
        }
        private void GenerateEmail()
        {
            this._email = "";
            if (this.LastName.Length < 3){
                this._email += this._lastName.ToLower();
            }
            else{
                this._email += this._lastName.Substring(0,3).ToLower();
            }
            if (this._firstName.Length < 3)
            {
                this._email += this._firstName.ToLower();
            }
            else
            {
                this._email += this._firstName.Substring(0, 3).ToLower();
            }
            this._email += $"{this._studentNumber - 555000}@ICS4U.com";
        }
        public int CompareTo(Student that)
        {
            if (this.LastName.CompareTo(that.LastName) == 0)
                return this.FirstName.CompareTo(that.FirstName);
            else
                return this.LastName.CompareTo(that.LastName);
        }
    }
}
