using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France1.Model
{
    class Customer1
    {
        public string _username { get; protected set; }
        public string _password { get; protected set; }

        public Customer1(string username, string password)
        {
            _username = username;
            _password = password;
        }
        public bool Equals(Customer1 other)
        {
            if (other == null)
                return false;

            return this._username == other._username &&
                this._password == other._password;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else
                return Equals(Customer1);
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return this._username.GetHashCode();
        }

        public static bool operator !=(Customer1 person1, Customer1 person2)
        {
            return !(person1 == person2);
        }

    }
    public interface IEquateable<T>
    {

    }
}
