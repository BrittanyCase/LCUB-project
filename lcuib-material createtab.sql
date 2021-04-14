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

-- Dumping structure for table mysql.lcuib-material
CREATE TABLE IF NOT EXISTS `lcuib-material` (
  `P_ID` int NOT NULL,
  `Item_ID` varchar(50) NOT NULL DEFAULT '',
  `quantity` int DEFAULT NULL,
  KEY `Item_ID` (`Item_ID`),
  KEY `P_ID` (`P_ID`),
  CONSTRAINT `item_ID` FOREIGN KEY (`Item_ID`) REFERENCES `lcuib-item` (`Item_num`),
  CONSTRAINT `project_ID ` FOREIGN KEY (`P_ID`) REFERENCES `lcuib-project` (`project_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table mysql.lcuib-material: ~0 rows (approximately)
/*!40000 ALTER TABLE `lcuib-material` DISABLE KEYS */;
/*!40000 ALTER TABLE `lcuib-material` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
