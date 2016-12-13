using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class TestClass
    {
        private string _FirstName;
        private string _LastName;
        private string _Age;

        public string FirstName
        {
            set
            {
                _FirstName = value;
            }
            get
            {
                return _FirstName;
            }
        }

        public string LastName
        {
            set
            {
                _LastName = value;
            }
            get
            {
                return _LastName;
            }
        }

        public string Age
        {
            set
            {
                _Age = value;
            }
            get
            {
                return _Age;
            }
        }
    }
}