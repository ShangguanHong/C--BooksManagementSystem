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
    class BookController
    {
        /// <summary>
        /// 增加图书
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public static bool createBook(string isbn, string location)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@isbn", MySqlDbType.VarChar), new MySqlParameter("@location", MySqlDbType.VarChar) };
            parameters[0].Value = isbn;
            parameters[1].Value = location;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "insert into `book` (`isbn`, `location`) value (@isbn, @location)", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 通过ID删除图书
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool deleteBookById(int id)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.Int32) };
            parameters[0].Value = id;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "delete from `book` where `id` = @id", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 获取所有图书
        /// </summary>
        /// <returns></returns>
        public static List<Book> getAllBookList()
        {
            List<Book> bookList = new List<Book>();
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `book`");
            while(reader.Read())
            {
                bookList.Add(new Book((int)reader["id"], (string)reader["isbn"], (bool)reader["isborrow"], (string)reader["location"]));
            }
            reader.Close();
            return bookList;
        }
        
        /// <summary>
        /// 通过ISBN查询图书列表
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public static List<Book> getBookListByISBN(string isbn)
        {
            List<Book> bookList = new List<Book>();
            MySqlParameter[] parameters = { new MySqlParameter("@isbn", MySqlDbType.VarChar) };
            parameters[0].Value = isbn;
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `book` where `isbn` = @isbn", parameters);
            while (reader.Read())
            {
                bookList.Add(new Book((int)reader["id"], (string)reader["isbn"], (bool)reader["isborrow"], (string)reader["location"]));
            }
            reader.Close();
            return bookList;
        }

        /// <summary>
        /// 通过图书ID获取图书详情
        /// </summary>
        /// <param name="bookId">图书ID</param>
        /// <returns></returns>
        public static BookDetail getBookDetailByBookId(int bookId)
        {
            BookDetail bookDetail = null;
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.Int32) };
            parameters[0].Value = bookId;
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `book`, `book_detail` where `book`.`isbn` = `book_detail`.`isbn` and `book`.`id` = @id", parameters);
            if(reader.Read())
            {
                bookDetail = new BookDetail((string)reader["isbn"], (string)reader["name"], (string)reader["author"], (string)reader["press"], (double)reader["price"], (int)reader["totalnum"], (int)reader["leftnum"], (string)reader["categoryid"]);
            }
            reader.Close();
            return bookDetail;
        }

        /// <summary>
        /// 通过图书ID修改图书出借状态
        /// </summary>
        /// <param name="bookId">图书ID</param>
        /// <param name="isBorrow">图书出借状态</param>
        /// <returns></returns>
        public static bool updateBookBorrowStatusByBookId(int bookId, bool isBorrow)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.Int32), new MySqlParameter("@isborrow", MySqlDbType.Bit) };
            parameters[0].Value = bookId;
            parameters[1].Value = isBorrow;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "update `book` set `isborrow` = @isborrow where `id` = @id", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 通过图书ID查询图书ISBN编号
        /// </summary>
        /// <param name="bookId">图书ID</param>
        /// <returns></returns>
        public static String getISBNByBookId(int bookId)
        {
            String result = null;
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.Int32) };
            parameters[0].Value = bookId;
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select `isbn` from `book` where `id` = @id", parameters);
            if(reader.Read())
            {
                result = (String)reader["isbn"];
            }
            reader.Close();
            return result;
        }

        /// <summary>
        /// 通过关键字搜索图书信息
        /// </summary>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public static List<Book> searchBookByKeyword(string keyword)
        {
            List<Book> bookList = new List<Book>();
            MySqlParameter[] parameters = { new MySqlParameter("@keyword", MySqlDbType.VarChar) };
            parameters[0].Value = "%" + keyword + "%";
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `book` where `id` like @keyword or `isbn` like @keyword", parameters);
            while (reader.Read())
            {
                bookList.Add(new Book((int)reader["id"], (string)reader["isbn"], (bool)reader["isborrow"], (string)reader["location"]));
            }
            reader.Close();
            return bookList;
        }

        /// <summary>
        /// 通过图书ID修改图书信息
        /// </summary>
        /// <param name="bookId">图书ID</param>
        /// <param name="isbn">ISBN号</param>
        /// <param name="location">馆藏位置</param>
        /// <returns></returns>
        public static bool updateBookByBookId(int bookId, string isbn, string location)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.Int32), new MySqlParameter("@isbn", MySqlDbType.VarChar), new MySqlParameter("@location", MySqlDbType.VarChar) };
            parameters[0].Value = bookId;
            parameters[1].Value = isbn;
            parameters[2].Value = location;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "update `book` set `isbn` = @isbn, `location` = @location where `id` = @id", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 通过图书ID获取书名
        /// </summary>
        /// <param name="bookId">图书ID</param>
        /// <returns></returns>
        public static String getBookNameByBookId(int bookId)
        {
            String result = null;
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.Int32) };
            parameters[0].Value = bookId;
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select `name` from `book`, `book_detail` where `book`.`isbn` = `book_detail`.`isbn` and `book`.`id` = @id", parameters);
            if(reader.Read())
            {
                result = (String)reader["name"];
            }
            reader.Close();
            return result;
        }
    }
}
