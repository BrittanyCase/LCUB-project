-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.23 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping structure for table mysql.lcuib-assemblies category
CREATE TABLE IF NOT EXISTS `lcuib-assemblies category` (
  `CAT_ID` int NOT NULL AUTO_INCREMENT COMMENT 'PK',
  `CAT` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`CAT_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table mysql.lcuib-assemblies category: ~9 rows (approximately)
/*!40000 ALTER TABLE `lcuib-assemblies category` DISABLE KEYS */;
REPLACE INTO `lcuib-assemblies category` (`CAT_ID`, `CAT`) VALUES
	(1, 'Overhead'),
	(2, 'underground'),
	(3, 'Riser'),
	(4, 'Conduit'),
	(5, 'Meter'),
	(6, 'Fiber'),
	(7, 'Transmission'),
	(8, 'Wire'),
	(9, 'Miscellaneous');
/*!40000 ALTER TABLE `lcuib-assemblies category` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
