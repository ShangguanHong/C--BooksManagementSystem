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
    class BookDetailController
    {
        /// <summary>
        /// 通过ISBN查询图书详情
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public static BookDetail getBookDetailByISBN(string isbn)
        {
            BookDetail bookDetail = null;
            MySqlParameter[] parameters = { new MySqlParameter("@isbn", MySqlDbType.VarChar) };
            parameters[0].Value = isbn;
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `book_detail` where `isbn` = @isbn", parameters);
            if(reader.Read())
            {
                bookDetail = new BookDetail((string)reader["isbn"], (string)reader["name"], (string)reader["author"], (string)reader["press"], (double)reader["price"], (int)reader["totalnum"], (int)reader["leftnum"], (string)reader["categoryid"]);
            }
            reader.Close();
            return bookDetail;
        }

        /// <summary>
        /// 增加图书详情
        /// </summary>
        /// <param name="isbn">ISBN号</param>
        /// <param name="name">图书名称</param>
        /// <param name="author">图书作者</param>
        /// <param name="press">图书出版社</param>
        /// <param name="price">图书价格</param>
        /// <param name="totalNum">图书总库存</param>
        /// <param name="leftNum">图书剩余库存</param>
        /// <param name="categoryId">图书分类ID</param>
        /// <returns></returns>
        public static BookDetail createBookDetail(string isbn, string name, string author, string press, double price, int totalNum, int leftNum, string categoryId)
        {
            BookDetail bookDetail = null;
            MySqlParameter[] parameters = { new MySqlParameter("@isbn", MySqlDbType.VarChar), new MySqlParameter("@name", MySqlDbType.VarChar), new MySqlParameter("@author", MySqlDbType.VarChar), new MySqlParameter("@press", MySqlDbType.VarChar), new MySqlParameter("@price", MySqlDbType.Double), new MySqlParameter("@totalnum", MySqlDbType.Int32), new MySqlParameter("@leftnum", MySqlDbType.Int32), new MySqlParameter("@categoryid", MySqlDbType.VarChar) };
            parameters[0].Value = isbn;
            parameters[1].Value = name;
            parameters[2].Value = author;
            parameters[3].Value = press;
            parameters[4].Value = price;
            parameters[5].Value = totalNum;
            parameters[6].Value = leftNum;
            parameters[7].Value = categoryId;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "insert into `book_detail` value (@isbn, @name, @author, @press, @price, @totalnum, @leftnum, @categoryid)", parameters);
            if(returnValue == 1)
            {
                bookDetail = getBookDetailByISBN(isbn);
            }
            return bookDetail;
        }
        
        /// <summary>
        /// 通过ISBN号删除图书详情
        /// </summary>
        /// <param name="isbn">ISBN号</param>
        /// <returns></returns>
        public static bool deleteBookDetailByISBN(string isbn)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@isbn", MySqlDbType.VarChar) };
            parameters[0].Value = isbn;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "delete from `book_detail` where `isbn` = @isbn", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 获取所有图书详情
        /// </summary>
        /// <returns></returns>
        public static List<BookDetail> getAllBookDetailList()
        {
            List<BookDetail> bookDetailList = new List<BookDetail>();
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `book_detail`");
            while(reader.Read())
            {
                bookDetailList.Add(new BookDetail((string)reader["isbn"], (string)reader["name"], (string)reader["author"], (string)reader["press"], (double)reader["price"], (int)reader["totalnum"], (int)reader["leftnum"], (string)reader["categoryid"]));
            }
            reader.Close();
            return bookDetailList;
        }


        /// <summary>
        /// 通过图书名称搜素图书详情
        /// </summary>
        /// <param name="bookName">图书名称</param>
        /// <returns></returns>
        public static List<BookDetail> searchBookDetailByBookName(string bookName)
        {
            List<BookDetail> bookDetailList = new List<BookDetail>();
            MySqlParameter[] parameters = { new MySqlParameter("@name", MySqlDbType.VarChar) };
            parameters[0].Value = "%" + bookName + "%";
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `book_detail` where `name` like @name", parameters);
            while (reader.Read())
            {
                bookDetailList.Add(new BookDetail((string)reader["isbn"], (string)reader["name"], (string)reader["author"], (string)reader["press"], (double)reader["price"], (int)reader["totalnum"], (int)reader["leftnum"], (string)reader["categoryid"]));
            }
            reader.Close();
            return bookDetailList;
        }
        
        /// <summary>
        /// 通过ISBN编号搜索图书详情
        /// </summary>
        /// <param name="isbn">ISBN编号</param>
        /// <returns></returns>
        public static List<BookDetail> searchBookDetailByISBN(string isbn)
        {
            List<BookDetail> bookDetailList = new List<BookDetail>();
            MySqlParameter[] parameters = { new MySqlParameter("@isbn", MySqlDbType.VarChar) };
            parameters[0].Value = "%" + isbn + "%";
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `book_detail` where `isbn` like @isbn", parameters);
            while (reader.Read())
            {
                bookDetailList.Add(new BookDetail((string)reader["isbn"], (string)reader["name"], (string)reader["author"], (string)reader["press"], (double)reader["price"], (int)reader["totalnum"], (int)reader["leftnum"], (string)reader["categoryid"]));
            }
            reader.Close();
            return bookDetailList;
        }

        /// <summary>
        /// 通过ISBN编号将图书剩余数量减一
        /// </summary>
        /// <param name="isbn">ISBN号</param>
        /// <returns></returns>
        public static bool decreaseBookLeftNumByISBN(string isbn)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@isbn", MySqlDbType.VarChar) };
            parameters[0].Value = isbn;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "update `book_detail` set `leftnum` = `leftnum` - 1 where `isbn` = @isbn", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 通过ISBN编号将图书剩余数量加一
        /// </summary>
        /// <param name="isbn">ISBN号</param>
        /// <returns></returns>
        public static bool increaseBookLeftNumByISBN(string isbn)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@isbn", MySqlDbType.VarChar) };
            parameters[0].Value = isbn;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "update `book_detail` set `leftnum` = `leftnum` + 1 where `isbn` = @isbn", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 通过ISBN编号将图书总数量加一
        /// </summary>
        /// <param name="isbn">ISBN号</param>
        /// <returns></returns>
        public static bool increaseBookTotalNumByISBN(string isbn)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@isbn", MySqlDbType.VarChar) };
            parameters[0].Value = isbn;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "update `book_detail` set `totalnum` = `totalnum` + 1 where `isbn` = @isbn", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 通过关键字搜索图书详情
        /// </summary>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public static List<BookDetail> searchBookDetailByKeyword(string keyword)
        {
            List<BookDetail> bookDetailList = new List<BookDetail>();
            MySqlParameter[] parameters = { new MySqlParameter("@keyword", MySqlDbType.VarChar) };
            parameters[0].Value = "%" + keyword + "%";
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `book_detail` where `isbn` like @keyword or `name` like @keyword or `author` like @keyword or `press` like @keyword", parameters);
            while (reader.Read())
            {
                bookDetailList.Add(new BookDetail((string)reader["isbn"], (string)reader["name"], (string)reader["author"], (string)reader["press"], (double)reader["price"], (int)reader["totalnum"], (int)reader["leftnum"], (string)reader["categoryid"]));
            }
            reader.Close();
            return bookDetailList;
        }

        /// <summary>
        /// 通过ISBN号修改图书详情
        /// </summary>
        /// <param name="isbn">ISBN号</param>
        /// <param name="name">图书名字</param>
        /// <param name="author">图书作者</param>
        /// <param name="press">出版社</param>
        /// <param name="price">图书价格</param>
        /// <param name="categoryId">分类ID</param>
        /// <returns></returns>
        public static bool updateBookDetailByISBN(string isbn, string name, string author, string press, double price, string categoryId)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@isbn", MySqlDbType.VarChar), new MySqlParameter("@name", MySqlDbType.VarChar), new MySqlParameter("@author", MySqlDbType.VarChar), new MySqlParameter("@press", MySqlDbType.VarChar), new MySqlParameter("@price", MySqlDbType.Double), new MySqlParameter("@categoryid", MySqlDbType.VarChar) };
            parameters[0].Value = isbn;
            parameters[1].Value = name;
            parameters[2].Value = author;
            parameters[3].Value = press;
            parameters[4].Value = price;
            parameters[5].Value = categoryId;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "update `book_detail` set `name` = @name, `author` = @author, `press` = @press, `price` = @price, `categoryid` = @categoryId where `isbn` = @isbn", parameters);
            return returnValue == 1;
        }

    }
}
