using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France1.Model
{
    class Customer
    {
        private string _x;
        private string _y;
        private string _password;
        private string _username;

        public Customer()
        {
            
            
        }

        public Customer(string password, string username)
        {
            this._password = password;
            this._username = username;
        }
        public void Login()
        {

        }
    }
}
