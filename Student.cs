using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Programming_Assignment___Hunter
{
    internal class Student
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
            }
        }
        public int StudentNumber
        {
            get 
            { 
                return _studentNumber; 
            }
        }
    }
}
