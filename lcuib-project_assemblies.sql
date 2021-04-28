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

-- Dumping structure for table mysql.lcuib-project_assemblies
CREATE TABLE IF NOT EXISTS `lcuib-project_assemblies` (
  `assembly_ID` int DEFAULT NULL,
  `Project_ID` int DEFAULT NULL,
  KEY `FK__lcuib-assemblies` (`assembly_ID`),
  KEY `FK__lcuib-project` (`Project_ID`),
  CONSTRAINT `FK__lcuib-assemblies` FOREIGN KEY (`assembly_ID`) REFERENCES `lcuib-assemblies` (`assemblies`),
  CONSTRAINT `FK__lcuib-project` FOREIGN KEY (`Project_ID`) REFERENCES `lcuib-project` (`project_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table mysql.lcuib-project_assemblies: ~0 rows (approximately)
/*!40000 ALTER TABLE `lcuib-project_assemblies` DISABLE KEYS */;
/*!40000 ALTER TABLE `lcuib-project_assemblies` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
