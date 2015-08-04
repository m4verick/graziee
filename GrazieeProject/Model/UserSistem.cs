using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrazieeProject.Model
{
    class UserSistem
    {
        private string id_user_sistem;
        private string nama_user;
        private string password_user;
        private string role_user;

        public UserSistem()
        {
            //default constructor
        }

        public UserSistem(string idUserSistem, string namaUser, string passwordUser, string roleUser)
        {
            id_user_sistem = idUserSistem;
            nama_user = namaUser;
            password_user = passwordUser;
            role_user = roleUser;
        }

        public UserSistem(string namaUser, string passwordUser)
        {
            nama_user = namaUser;
            password_user = passwordUser;
        }

        public string Id_user_sistem
        {
            set { id_user_sistem = value; }
            get { return id_user_sistem; }
        }

        public string Nama_user
        {
            set { nama_user = value; }
            get { return nama_user; }
        }

        public string Password_user
        {
            set { password_user = value; }
            get { return password_user; }
        }

        public string Role_user
        {
            set { role_user = value; }
            get { return role_user; }
        }
    }
}
