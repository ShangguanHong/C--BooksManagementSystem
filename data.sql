-- --------------------------------------------------------
-- 主机:                           127.0.0.1
-- 服务器版本:                        10.1.37-MariaDB - mariadb.org binary distribution
-- 服务器操作系统:                      Win32
-- HeidiSQL 版本:                  9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- 导出 booksmanagementsystem 的数据库结构
CREATE DATABASE IF NOT EXISTS `booksmanagementsystem` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `booksmanagementsystem`;

-- 导出  表 booksmanagementsystem.book 结构
CREATE TABLE IF NOT EXISTS `book` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `isbn` varchar(50) NOT NULL,
  `isborrow` tinyint(1) NOT NULL DEFAULT '0',
  `location` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_book_book_detail` (`isbn`),
  CONSTRAINT `FK_book_book_detail` FOREIGN KEY (`isbn`) REFERENCES `book_detail` (`isbn`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;

-- 正在导出表  booksmanagementsystem.book 的数据：~13 rows (大约)
/*!40000 ALTER TABLE `book` DISABLE KEYS */;
INSERT INTO `book` (`id`, `isbn`, `isborrow`, `location`) VALUES
	(10, '978-7-5133-3083-1', 0, '延奎图书馆'),
	(11, '978-7-5133-3083-1', 0, '延奎图书馆'),
	(12, '978-7-5133-3083-1', 0, '延奎图书馆'),
	(13, '978-7-5133-3083-1', 0, '延奎图书馆'),
	(14, '978-7-5133-3083-1', 0, '延奎图书馆'),
	(16, '978-7-121-17740-8', 0, '嘉庚图书馆'),
	(17, '978-7-121-17740-8', 0, '嘉庚图书馆'),
	(18, '978-7-121-17740-8', 0, '嘉庚图书馆'),
	(19, '978-7-121-17740-8', 0, '嘉庚图书馆'),
	(20, '978-7-121-17740-8', 0, '嘉庚图书馆'),
	(21, '978-7-302-36038-4', 0, '嘉庚图书馆'),
	(22, '978-7-302-36038-4', 0, '嘉庚图书馆'),
	(23, '978-7-121-17740-8', 0, '嘉庚图书馆');
/*!40000 ALTER TABLE `book` ENABLE KEYS */;

-- 导出  表 booksmanagementsystem.book_detail 结构
CREATE TABLE IF NOT EXISTS `book_detail` (
  `isbn` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `author` varchar(50) NOT NULL,
  `press` varchar(50) NOT NULL,
  `price` double NOT NULL,
  `totalnum` int(11) NOT NULL DEFAULT '0',
  `leftnum` int(11) NOT NULL DEFAULT '0',
  `categoryid` varchar(50) NOT NULL,
  PRIMARY KEY (`isbn`),
  KEY `FK_book_detail_category` (`categoryid`),
  CONSTRAINT `FK_book_detail_category` FOREIGN KEY (`categoryid`) REFERENCES `category` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 正在导出表  booksmanagementsystem.book_detail 的数据：~3 rows (大约)
/*!40000 ALTER TABLE `book_detail` DISABLE KEYS */;
INSERT INTO `book_detail` (`isbn`, `name`, `author`, `press`, `price`, `totalnum`, `leftnum`, `categoryid`) VALUES
	('978-7-121-17740-8', 'JavaScript语言精粹', 'Douglas Crockford', '电子工业出版社', 49, 6, 6, '001'),
	('978-7-302-36038-4', '计算机系统结构教程', '张晨曦', '清华大学出版社', 39.5, 2, 2, '001'),
	('978-7-5133-3083-1', '刺客信条[专著]：起源·沙漠誓言', 'Oliver Bowden', '新星出版社', 48, 5, 5, '002');
/*!40000 ALTER TABLE `book_detail` ENABLE KEYS */;

-- 导出  表 booksmanagementsystem.borrow 结构
CREATE TABLE IF NOT EXISTS `borrow` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `userid` int(11) NOT NULL,
  `bookid` int(11) NOT NULL,
  `borrowdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `lastreturndate` timestamp NOT NULL,
  `returndate` timestamp,
  `isreturn` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `FK_borrow_user` (`userid`),
  KEY `FK_borrow_book` (`bookid`),
  CONSTRAINT `FK_borrow_book` FOREIGN KEY (`bookid`) REFERENCES `book` (`id`) ON DELETE NO ACTION,
  CONSTRAINT `FK_borrow_user` FOREIGN KEY (`userid`) REFERENCES `user` (`id`) ON DELETE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

-- 正在导出表  booksmanagementsystem.borrow 的数据：~2 rows (大约)
/*!40000 ALTER TABLE `borrow` DISABLE KEYS */;
INSERT INTO `borrow` (`id`, `userid`, `bookid`, `borrowdate`, `lastreturndate`, `returndate`, `isreturn`) VALUES
	(15, 12, 16, '2019-01-11 12:52:06', '2019-02-10 12:52:06', '2019-01-11 12:56:32', 1),
	(16, 12, 19, '2019-01-11 12:56:39', '2019-02-10 12:56:39', '2019-01-11 12:56:45', 1);
/*!40000 ALTER TABLE `borrow` ENABLE KEYS */;

-- 导出  表 booksmanagementsystem.category 结构
CREATE TABLE IF NOT EXISTS `category` (
  `id` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 正在导出表  booksmanagementsystem.category 的数据：~3 rows (大约)
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` (`id`, `name`) VALUES
	('001', '计算机'),
	('002', '小说'),
	('003', '文学');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;

-- 导出  表 booksmanagementsystem.user 结构
CREATE TABLE IF NOT EXISTS `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(32) NOT NULL,
  `truename` varchar(50) NOT NULL,
  `tel` varchar(11) NOT NULL,
  `role` int(11) NOT NULL DEFAULT '2',
  PRIMARY KEY (`id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

-- 正在导出表  booksmanagementsystem.user 的数据：~3 rows (大约)
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` (`id`, `username`, `password`, `truename`, `tel`, `role`) VALUES
	(11, 'admin', '21232f297a57a5a743894a0e4a801fc3', '小明', '10086', 0),
	(12, '123', '202cb962ac59075b964b07152d234b70', '张三', '1323', 2),
	(13, 'admin2', 'c84258e9c39059a89ab77d846ddab909', 'admin2', '123', 1);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
