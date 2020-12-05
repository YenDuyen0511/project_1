using System;
using System.Collections.Generic;
using System.Text;

namespace DangNhap.Entities
{
    public class dangNhap
    {
        private string user, password;
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public dangNhap() { }
        public dangNhap(dangNhap dn)
        {
            this.user = dn.user;
            this.password = dn.password;
        }
        public dangNhap(string user, string password)
        {
            this.user = user;
            this.password = password;
        }
    }
}
