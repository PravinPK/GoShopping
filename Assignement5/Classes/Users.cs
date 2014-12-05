using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignement5.Classes
{
    public class Users
    {
        public string _UserName;
        public string _Password;
        public string _FirstName;
        public string _Address;
        public string _City;
        public string _PhoneNumber;
        public string _EmailID;
        public string _role;
        public Users(string UserName, string Password, string FirstName, string Address, string City, string PhoneNumber, string EmailID, string role)
	{	
        _UserName = UserName;
        _Password = Password;
        _FirstName = FirstName;
        _Address = Address;
        _City = City;
        _PhoneNumber = PhoneNumber;
        _EmailID = EmailID;
        _role=role;
       

    }

    }
}