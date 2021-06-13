using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoSinhVien.Resources
{
    public class Account
    {
        private static Account instance;

        public
             Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance; }
            private set { instance = value; }
        }

        private Account() { }

        public bool Login(string username,string password)
        {
            return false;
        }
    }
}
