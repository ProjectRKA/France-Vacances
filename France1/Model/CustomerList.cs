using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France1.Model
{
    class CustomerList
    {
        private string x; //username
        private string y; //password

        private List<Customer> list;

        public string Username
        {
            get { return x; }
            set { x = value; }
        }
        public string Password
        {
            get { return y; }
            set { y = value; }
        }

        public CustomerList()
        {
            list = new List<Customer>();
        }

        public void Register()
        {
            list.Add(new Customer(x, y));
            x = null;
            y = null;
        }
    }
    
}
