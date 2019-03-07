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
    class CategoryController
    {
        /// <summary>
        /// 通过分类ID获取分类信息
        /// </summary>
        /// <param name="id">分类ID</param>
        /// <returns></returns>
        public static Category getCategoryByCategoryId(string id)
        {
            Category category = null;
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.VarChar) };
            parameters[0].Value = id;
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `category` where `id` = @id", parameters);
            if(reader.Read())
            {
                category = new Category((string)reader["id"], (string)reader["name"]);
            }
            reader.Close();
            return category;
        }

        /// <summary>
        /// 创建分类
        /// </summary>
        /// <param name="id">分类ID</param>
        /// <param name="name">分类名称</param>
        /// <returns></returns>
        public static Category createCategory(string id, string name)
        {
            Category category = null;
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.VarChar), new MySqlParameter("@name", MySqlDbType.VarChar) };
            parameters[0].Value = id;
            parameters[1].Value = name;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "insert into `category` value (@id, @name)", parameters);
            if(returnValue == 1)
            {
                category = getCategoryByCategoryId(id);
            }
            return category;
        }

        /// <summary>
        /// 通过分类ID删除分类
        /// </summary>
        /// <param name="id">分类ID</param>
        /// <returns></returns>
        public static bool deleteCategoryByCategoryId(string id)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.VarChar) };
            parameters[0].Value = id;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "delete from `category` where `id` = @id", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 通过分类ID修改分类名称
        /// </summary>
        /// <param name="categoryId">分类ID</param>
        /// <param name="name">分类名称</param>
        /// <returns></returns>
        public static bool updateNameByCategoryId(string categoryId, string name)
        {
            Category category = null;
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.VarChar), new MySqlParameter("name", MySqlDbType.VarChar) };
            parameters[0].Value = categoryId;
            parameters[1].Value = name;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "update `category` set `name` = @name where `id` = @id", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 获取所有分类
        /// </summary>
        /// <returns></returns>
        public static List<Category> getAllCategory()
        {
            List<Category> categoryList = new List<Category>();
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `category`");
            while(reader.Read())
            {
                categoryList.Add(new Category((string)reader["id"], (string)reader["name"]));
            }
            reader.Close();
            return categoryList;
        }

        /// <summary>
        /// 获取所有分类信息，返回Dictionary，Key => 分类ID, Value => 分类名称
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> getAllCategoryToDict()
        {
            Dictionary<string, string> categoryDict = new Dictionary<string, string>();
            List<Category> categoryList = getAllCategory();
            foreach (Category category in categoryList)
            {
                categoryDict.Add(category.Id, category.Name);
            }
            return categoryDict;
        }

        /// <summary>
        /// 通过关键字搜索分类信息
        /// </summary>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public static List<Category> searchCategoryByKeyword(string keyword)
        {
            List<Category> categoryList = new List<Category>();
            MySqlParameter[] parameters = { new MySqlParameter("@keyword", MySqlDbType.VarChar) };
            parameters[0].Value = "%" + keyword + "%";
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `category` where `id` like @keyword or `name` like @keyword", parameters);
            while(reader.Read())
            {
                categoryList.Add(new Category((string)reader["id"], (string)reader["name"]));
            }
            reader.Close();
            return categoryList;
        }
    }
}
