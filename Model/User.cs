using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public abstract class User
    {
        private string _name, _surname;
        private int _id;

        public User(int id, string name, string surname)
        {
            this._id = id;
            this._name = name;
            this._surname = surname;
        }
        
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string FullName
        {
            get { return $"{_name} {_surname}"; }
        }

    }
}
