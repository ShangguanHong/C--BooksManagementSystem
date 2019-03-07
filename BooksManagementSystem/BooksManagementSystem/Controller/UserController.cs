using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksManagementSystem.Model;
using BooksManagementSystem.Util;
using MySql.Data.MySqlClient;

namespace BooksManagementSystem.Controller
{
    class UserController
    {
        /// <summary>
        /// 通过用户ID获取用户信息
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns></returns>
        public static User getUserByUserId(int userId)
        {
            User user = null;
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.Int32) };
            parameters[0].Value = userId;
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `user` where `id` = @id", parameters);
            if(reader.Read())
            {
                user = new User((int)reader["id"], (string)reader["username"], (string)reader["password"], (string)reader["truename"], (string)reader["tel"], (User.UserRole)reader["role"]);
            }
            reader.Close();
            return user;
        }

        /// <summary>
        /// 通过用户名获取用户信息
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public static User getUserByUsername(string username)
        {
            User user = null;
            MySqlParameter[] parameters = { new MySqlParameter("@username", MySqlDbType.VarChar) };
            parameters[0].Value = username;
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `user` where `username` = @username", parameters);
            if (reader.Read())
            {
                user = new User((int)reader["id"], (string)reader["username"], (string)reader["password"], (string)reader["truename"], (string)reader["tel"], (User.UserRole)reader["role"]);
            }
            reader.Close();
            return user;
        }

        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="trueName">真实姓名</param>
        /// <param name="tel">联系电话</param>
        /// <param name="role">用户角色</param>
        /// <returns></returns>
        public static User createUser(string username, string password, string trueName, string tel, User.UserRole role)
        {
            User user = null;
            MySqlParameter[] parameters = { new MySqlParameter("@username", MySqlDbType.VarChar), new MySqlParameter("@password", MySqlDbType.VarChar), new MySqlParameter("@truename", MySqlDbType.VarChar), new MySqlParameter("@tel", MySqlDbType.VarChar), new MySqlParameter("@role", MySqlDbType.Int32) };
            parameters[0].Value = username;
            parameters[1].Value = EncryptUtil.md5(password);
            parameters[2].Value = trueName;
            parameters[3].Value = tel;
            parameters[4].Value = (int)role;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "insert into `user` (`username`, `password`, `truename`, `tel`, `role`) value (@username, @password, @truename, @tel, @role)", parameters);
            if(returnValue == 1)
            {
                user = getUserByUsername(username);
            }
            return user;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public static User login(string username, string password)
        {
            User user = null;
            MySqlParameter[] parameters = { new MySqlParameter("@username", MySqlDbType.VarChar), new MySqlParameter("@password", MySqlDbType.VarChar) };
            parameters[0].Value = username;
            parameters[1].Value = EncryptUtil.md5(password);
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `user` where `username` = @username and `password` = @password", parameters);
            if(reader.Read())
            {
                user = new User((int)reader["id"], (string)reader["username"], (string)reader["password"], (string)reader["truename"], (string)reader["tel"], (User.UserRole)reader["role"]);
            }
            reader.Close();
            return user;
        }

        /// <summary>
        /// 通过用户ID删除用户
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns></returns>
        public static bool deleteUserByUserId(int userId)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.Int32) };
            parameters[0].Value = userId;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "delete from `user` where `id` = @id", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 通过用户名删除用户
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public static bool deleteUserByUsername(string username)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@username", MySqlDbType.VarChar) };
            parameters[0].Value = username;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "delete from `user` where `username` = @username", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 通过用户ID修改用户名
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public static User updateUsernameByUserId(int userId, string username)
        {
            User user = null;
            MySqlParameter[] parameters = { new MySqlParameter("@username", MySqlDbType.VarChar), new MySqlParameter("@id", MySqlDbType.Int32) };
            parameters[0].Value = username;
            parameters[1].Value = userId;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "update `user` set `username` = @username where `id` = @id", parameters);
            if (returnValue == 1)
            {
                user = getUserByUserId(userId);
            }
            return user;
        }

        /// <summary>
        /// 通过用户ID修改密码
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="password">用户密码</param>
        /// <returns></returns>
        public static User updatePasswordByUserId(int userId, string password)
        {
            User user = null;
            MySqlParameter[] parameters = { new MySqlParameter("@password", MySqlDbType.VarChar), new MySqlParameter("@id", MySqlDbType.Int32) };
            parameters[0].Value = EncryptUtil.md5(password);
            parameters[1].Value = userId;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "update `user` set `password` = @password where `id` = @id", parameters);
            if(returnValue == 1)
            {
                user = getUserByUserId(userId);
            }
            return user;
        }

        /// <summary>
        /// 通过用户ID修改用户角色
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="role">用户角色</param>
        /// <returns></returns>
        public static User updateRoleByUserId(int userId, User.UserRole role)
        {
            User user = null;
            MySqlParameter[] parameters = { new MySqlParameter("@role", MySqlDbType.Int32), new MySqlParameter("@id", MySqlDbType.Int32) };
            parameters[0].Value = (int)role;
            parameters[1].Value = userId;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "update `user` set `role` = @role where `id` = @id", parameters);
            if (returnValue == 1)
            {
                user = getUserByUserId(userId);
            }
            return user;
        }

        /// <summary>
        /// 通过用户ID修改用户真实姓名
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="trueName">用户真实姓名</param>
        /// <returns></returns>
        public static User updateTrueNameByUserId(int userId, string trueName)
        {
            User user = null;
            MySqlParameter[] parameters = { new MySqlParameter("@truename", MySqlDbType.VarChar), new MySqlParameter("@id", MySqlDbType.Int32) };
            parameters[0].Value = trueName;
            parameters[1].Value = userId;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "update `user` set `truename` = @truename where `id` = @id", parameters);
            if (returnValue == 1)
            {
                user = getUserByUserId(userId);
            }
            return user;
        }

        /// <summary>
        /// 通过用户ID修改用户联系方式
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="tel">用户联系方式</param>
        /// <returns></returns>
        public static User updateTelByUserId(int userId, string tel)
        {
            User user = null;
            MySqlParameter[] parameters = { new MySqlParameter("@tel", MySqlDbType.VarChar), new MySqlParameter("@id", MySqlDbType.Int32) };
            parameters[0].Value = tel;
            parameters[1].Value = userId;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "update `user` set `tel` = @tel where `id` = @id", parameters);
            if (returnValue == 1)
            {
                user = getUserByUserId(userId);
            }
            return user;
        }

        /// <summary>
        /// 通过用户ID修改用户信息
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="username">用户名</param>
        /// <param name="password">用户密码，仅当该项不为空时修改用户密码</param>
        /// <param name="trueName">用户真实姓名</param>
        /// <param name="tel">用户联系方式</param>
        /// <param name="role">用户角色</param>
        /// <returns></returns>
        public static User updateUserByUserId(int userId, string username, string password, string trueName, string tel, User.UserRole role)
        {
            User user = null;
            int returnValue = 0;
            if(password.Length != 0)
            {
                MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.Int32), new MySqlParameter("@username", MySqlDbType.VarChar), new MySqlParameter("@password", MySqlDbType.VarChar), new MySqlParameter("@truename", MySqlDbType.VarChar), new MySqlParameter("@tel", MySqlDbType.VarChar), new MySqlParameter("@role", MySqlDbType.Int32) };
                parameters[0].Value = userId;
                parameters[1].Value = username;
                parameters[2].Value = EncryptUtil.md5(password);
                parameters[3].Value = trueName;
                parameters[4].Value = tel;
                parameters[5].Value = (int)role;
                returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                    "update `user` set `username` = @username, `password` = @password, `truename` = @truename, `tel` = @tel, `role` = @role where `id` = @id", parameters);
            }
            else
            {
                MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.Int32), new MySqlParameter("@username", MySqlDbType.VarChar), new MySqlParameter("@truename", MySqlDbType.VarChar), new MySqlParameter("@tel", MySqlDbType.VarChar), new MySqlParameter("@role", MySqlDbType.Int32) };
                parameters[0].Value = userId;
                parameters[1].Value = username;
                parameters[2].Value = trueName;
                parameters[3].Value = tel;
                parameters[4].Value = (int)role;
                returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                    "update `user` set `username` = @username, `truename` = @truename, `tel` = @tel, `role` = @role where `id` = @id", parameters);
            }
            if(returnValue == 1)
            {
                user = getUserByUserId(userId);
            }
            return user;
        }

        /// <summary>
        /// 获取所有用户列表
        /// </summary>
        /// <returns></returns>
        public static List<User> getAllUser()
        {
            List<User> userList = new List<User>();
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `user`");
            while(reader.Read())
            {
                userList.Add(new User((int)reader["id"], (string)reader["username"], (string)reader["password"], (string)reader["truename"], (string)reader["tel"], (User.UserRole)reader["role"]));
            }
            reader.Close();
            return userList;
        }

        /// <summary>
        /// 通过用户名搜索用户
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public static List<User> searchUserByUsername(string username)
        {
            List<User> userList = new List<User>();
            MySqlParameter[] parameters = { new MySqlParameter("@username", MySqlDbType.VarChar) };
            parameters[0].Value = "%" + username + "%";
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `user` where `username` like @username", parameters);
            while(reader.Read())
            {
                userList.Add(new User((int)reader["id"], (string)reader["username"], (string)reader["password"], (string)reader["truename"], (string)reader["tel"], (User.UserRole)reader["role"]));
            }
            reader.Close();
            return userList;
        }


        /// <summary>
        /// 通过用户真实姓名搜索用户
        /// </summary>
        /// <param name="trueName">用户真实姓名</param>
        /// <returns></returns>
        public static List<User> searchUserByTrueName(string trueName)
        {
            List<User> userList = new List<User>();
            MySqlParameter[] parameters = { new MySqlParameter("@truename", MySqlDbType.VarChar) };
            parameters[0].Value = "%" + trueName + "%";
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `user` where `truename` like @truename", parameters);
            while (reader.Read())
            {
                userList.Add(new User((int)reader["id"], (string)reader["username"], (string)reader["password"], (string)reader["truename"], (string)reader["tel"], (User.UserRole)reader["role"]));
            }
            reader.Close();
            return userList;
        }

        /// <summary>
        /// 通过关键字查找用户
        /// </summary>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public static List<User> searchUserByKeyword(string keyword)
        {
            List<User> userList = new List<User>();
            MySqlParameter[] parameters = { new MySqlParameter("@keyword", MySqlDbType.VarChar) };
            parameters[0].Value = "%" + keyword + "%";
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `user` where `id` like @keyword or `username` like @keyword or `truename` like @keyword or `tel` like @keyword", parameters);
            while (reader.Read())
            {
                userList.Add(new User((int)reader["id"], (string)reader["username"], (string)reader["password"], (string)reader["truename"], (string)reader["tel"], (User.UserRole)reader["role"]));
            }
            reader.Close();
            return userList;
        }

        /// <summary>
        /// 通过用户ID查询用户姓名
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns></returns>
        public static String getTruenameByUserId(int userId)
        {
            String result = null;
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.Int32) };
            parameters[0].Value = userId;
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select `truename` from `user` where `id` = @id", parameters);
            if(reader.Read())
            {
                result = (string)reader["truename"];
            }
            reader.Close();
            return result;
        }
    }
}
