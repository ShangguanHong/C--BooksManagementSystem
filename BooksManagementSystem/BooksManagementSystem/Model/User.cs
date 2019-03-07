using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem.Model
{
    public class User
    {
        public enum UserRole
        {
            superAdmin = 0,     //超级管理员
            commonAdmin = 1,    //普通管理员
            commonUser = 2      //普通用户
        }
        private int id;
        private string username;
        private string password;
        private string trueName;
        private string tel;
        private UserRole role;   // 0 -> 超级管理员, 1 -> 管理员, 2 -> 普通用户

        public User() { }

        public User(int id, string username, string password, string trueName, string tel, UserRole role)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.trueName = trueName;
            this.tel = tel;
            this.role = role;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string TrueName
        {
            get
            {
                return trueName;
            }

            set
            {
                trueName = value;
            }
        }

        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }

        public UserRole Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }
    }
}
