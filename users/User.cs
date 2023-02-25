using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_facturation_software.users
{
    internal class User
    {
        private int ID;
        private int ID_employee;
        private string user_name;
        private string password;
        private string email;
        private string position;
        private DateTime created_at;
        private DateTime last_updated;
        private bool status;

        public User(string _user_name, string _password) 
        {
            user_name = _user_name;
            password = _password;
        }

        public User(int _id, int _id_employee, string _user_name, string _email, DateTime _created_at, DateTime _last_updated, bool _status, string _position)
        {
            ID = _id;
            ID_employee = _id_employee;
            user_name = _user_name;
            Email = _email;
            created_at = _created_at;
            last_updated = _last_updated;
            status = _status;
            position = _position;
        }

        public int GetID() { return ID; }

        public int IDEmployees { get { return ID_employee; } set { ID_employee = value; } }

        public string UserName { get { return user_name; } set { user_name = value; } }

        public string Password { get { return password; } set { password = value; } }

        public string Email { get { return email; } set { email = value; } }

        public DateTime GetCreatedAt() { return created_at; }

        public DateTime GetLastUpdated() { return last_updated; }

        public bool Status { get { return status; } set { status = value; } }

        public string Position { get { return position; } set { position = value; } }
    }
}
