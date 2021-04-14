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

-- Dumping structure for table mysql.lcuib-assemblies
CREATE TABLE IF NOT EXISTS `lcuib-assemblies` (
  `assembly ID` int NOT NULL AUTO_INCREMENT,
  `Cat_ID` int NOT NULL DEFAULT '0',
  `sub_cat_ID` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`assembly ID`),
  KEY `Cat_ID` (`Cat_ID`),
  KEY `sub_Cat` (`sub_cat_ID`),
  CONSTRAINT `cat_ID` FOREIGN KEY (`Cat_ID`) REFERENCES `lcuib-assemblies category` (`CAT_ID`),
  CONSTRAINT `sub_Cat` FOREIGN KEY (`sub_cat_ID`) REFERENCES `lcuib-assemblies_subcateagory` (`sub_category_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table mysql.lcuib-assemblies: ~29 rows (approximately)
/*!40000 ALTER TABLE `lcuib-assemblies` DISABLE KEYS */;
REPLACE INTO `lcuib-assemblies` (`assembly ID`, `Cat_ID`, `sub_cat_ID`) VALUES
	(1, 1, 1),
	(2, 1, 2),
	(3, 1, 3),
	(4, 1, 4),
	(5, 1, 5),
	(6, 1, 6),
	(7, 1, 7),
	(9, 1, 8),
	(10, 1, 9),
	(11, 1, 10),
	(12, 1, 11),
	(13, 1, 12),
	(14, 2, 13),
	(15, 2, 14),
	(16, 2, 15),
	(17, 2, 16),
	(18, 2, 12),
	(22, 3, 21),
	(23, 4, 15),
	(24, 4, 16),
	(25, 4, 12),
	(26, 5, 21),
	(28, 6, 21),
	(29, 7, 21),
	(30, 1, 17),
	(32, 8, 18),
	(33, 8, 19),
	(34, 8, 20),
	(35, 9, 21);
/*!40000 ALTER TABLE `lcuib-assemblies` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
