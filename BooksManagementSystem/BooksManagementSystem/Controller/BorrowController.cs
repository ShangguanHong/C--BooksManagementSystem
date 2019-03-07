using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksManagementSystem.Model;
using BooksManagementSystem.Util;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace BooksManagementSystem.Controller
{
    class BorrowController
    {
        /// <summary>
        /// 创建一个借阅信息
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="bookId">图书ID</param>
        /// <param name="borrowDate">借阅日期</param>
        /// <param name="lastReturnDate">最晚归还日期</param>
        /// <returns></returns>
        public static bool createBorrow(int userId, int bookId, DateTime borrowDate, DateTime lastReturnDate)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@userid", MySqlDbType.Int32), new MySqlParameter("@bookid", MySqlDbType.Int32), new MySqlParameter("@borrowdate", MySqlDbType.DateTime), new MySqlParameter("@lastreturndate", MySqlDbType.DateTime) };
            parameters[0].Value = userId;
            parameters[1].Value = bookId;
            parameters[2].Value = borrowDate;
            parameters[3].Value = lastReturnDate;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "insert into `borrow` (`userid`, `bookid`, `borrowdate`, `lastreturndate`) value (@userid, @bookid, @borrowdate, @lastreturndate)", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 通过借阅ID归还图书
        /// </summary>
        /// <param name="id">借阅ID</param>
        /// <param name="returnDate">归还日期</param>
        /// <returns></returns>
        public static bool cancelBorrowByBorrowId(int id, DateTime returnDate)
        {
            MySqlParameter[] parameters = { new MySqlParameter("@id", MySqlDbType.Int32), new MySqlParameter("@returndate", MySqlDbType.DateTime) };
            parameters[0].Value = id;
            parameters[1].Value = returnDate;
            int returnValue = MySQLUtil.executeNonQuery(System.Data.CommandType.Text,
                "update `borrow` set `returndate` = @returndate, `isreturn` = 1 where `id` = @id", parameters);
            return returnValue == 1;
        }

        /// <summary>
        /// 通过用户ID获取用户借阅列表
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns></returns>
        public static List<Borrow> getBorrowListByUserId(int userId)
        {
            List<Borrow> borrowList = new List<Borrow>();
            MySqlParameter[] parameters = { new MySqlParameter("@userid", MySqlDbType.Int32) };
            parameters[0].Value = userId;
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `borrow` where `userid` = @userid and `isreturn` = 0", parameters);
            while(reader.Read())
            {
                borrowList.Add(new Borrow((int)reader["id"], (int)reader["userid"], (int)reader["bookid"], (DateTime)reader["borrowdate"],
                                    (DateTime)reader["lastreturndate"], Convert.IsDBNull(reader["returndate"]) ? null : (DateTime?)reader["returndate"], (bool)reader["isreturn"]));
            }
            reader.Close();
            return borrowList;
        }

        /// <summary>
        /// 获取所有借阅信息
        /// </summary>
        /// <returns></returns>
        public static List<Borrow> getAllBorrowList()
        {
            List<Borrow> borrowList = new List<Borrow>();
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select * from `borrow`");
            while (reader.Read())
            {
                borrowList.Add(new Borrow((int)reader["id"], (int)reader["userid"], (int)reader["bookid"], (DateTime)reader["borrowdate"],
                    (DateTime)reader["lastreturndate"], Convert.IsDBNull(reader["returndate"]) ? null : (DateTime?)reader["returndate"], (bool)reader["isreturn"]));
            }
            reader.Close();
            return borrowList;
        }

        /// <summary>
        /// 通过关键字查询借阅列表
        /// </summary>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public static List<Borrow> getBorrowListByKeyword(string keyword)
        {
            List<Borrow> borrowList = new List<Borrow>();
            MySqlParameter[] parameters = { new MySqlParameter("@keyword", MySqlDbType.VarChar) };
            parameters[0].Value = "%" + keyword + "%";
            MySqlDataReader reader = MySQLUtil.executeReader(System.Data.CommandType.Text,
                "select `borrow`.* from `borrow`, `user`, `book`, `book_detail` where `borrow`.`userid` = `user`.`id` and `borrow`.`bookid` = `book`.`id` and `book`.`isbn` = `book_detail`.`isbn` and (`user`.`id` like @keyword or `user`.`truename` like @keyword or `book`.`id` like @keyword or `book_detail`.`name` like @keyword) order by `borrow`.`id`", parameters);
            while (reader.Read())
            {
                borrowList.Add(new Borrow((int)reader["id"], (int)reader["userid"], (int)reader["bookid"], (DateTime)reader["borrowdate"],
                    (DateTime)reader["lastreturndate"], Convert.IsDBNull(reader["returndate"]) ? null : (DateTime?)reader["returndate"], (bool)reader["isreturn"]));
            }
            reader.Close();
            return borrowList;
        }
    }
}
