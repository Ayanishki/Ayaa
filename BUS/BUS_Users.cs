using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Users
    {
        DAO_User daouser =  new DAO_User();
        public DataTable GetUser(string sql)
        {
            return daouser.GetUser(sql);
        }
        public DataTable GetUser()
        {
            return daouser.GetUser();
        }
        public bool Login(DTO_Users user)
        {
            if( daouser.Login(user))
                return true;
            return false;
        }
        public bool Loginadmin(DTO_Users user)
        {
            return daouser.Loginadmin(user);
        }
        public bool Add(DTO_Users user)
        {
            return daouser.Add(user);
        }
        public bool Update(DTO_Users user)
        {
            return daouser.Update(user);
        }
        public bool Delete(DTO_Users user)
        {
            return daouser.Delete(user);
        }
        public object SqlScalar(string sql) 
        { 
            return daouser.SqlScalar(sql);
        }
        public DataTable Timkiem(string keyword)
        {
            return daouser.Timkiemtaikhoan(keyword);
        }
    }
}
