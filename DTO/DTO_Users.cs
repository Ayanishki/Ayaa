using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Users
    {
        public int AccountID { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Passwords { get; set; }
        public string Email { get; set; }
        public int Roles { get; set; }
        public string Sdt { get; set; } 
        public DTO_Users() { }
        public DTO_Users(string userName, string passwords)
        {
            UserName = userName;
            Passwords = passwords;
        }
        public DTO_Users( string displayname, string userName, string passwords, string email,string sdt, int roles)
        {
            DisplayName = displayname;
            UserName = userName;
            Passwords = passwords;
            Email = email;
            Roles = roles;
            Sdt = sdt;
        }
        public DTO_Users(int accountID,string displayname, string userName, string passwords, string email,string sdt, int roles)
        {
            AccountID = accountID;   
            DisplayName = displayname;
            UserName = userName;
            Passwords = passwords;
            Email = email;
            Roles = roles;
            Sdt = sdt;
        }
    }
}
