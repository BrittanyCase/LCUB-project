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

-- Dumping structure for table mysql.lcuib-assemblies_subcateagory
CREATE TABLE IF NOT EXISTS `lcuib-assemblies_subcateagory` (
  `sub_category_ID` int NOT NULL,
  `sub_cat` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`sub_category_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table mysql.lcuib-assemblies_subcateagory: ~21 rows (approximately)
/*!40000 ALTER TABLE `lcuib-assemblies_subcateagory` DISABLE KEYS */;
REPLACE INTO `lcuib-assemblies_subcateagory` (`sub_category_ID`, `sub_cat`) VALUES
	(1, 'single phase'),
	(2, 'two phase'),
	(3, 'three phase'),
	(4, 'double circuit'),
	(5, 'reclosers'),
	(6, 'switches&fuses'),
	(7, 'Transformers'),
	(8, 'volt/var control'),
	(9, 'scondaries'),
	(10, 'guys & anchors'),
	(11, 'Lighting'),
	(12, 'Miscellaneous'),
	(13, 'Pad Mount Transformers'),
	(14, 'switchgear'),
	(15, 'trenches & ductbanks'),
	(16, 'pads & vaults'),
	(17, 'poles'),
	(18, 'CU'),
	(19, 'AL'),
	(20, 'URD'),
	(21, 'none');
/*!40000 ALTER TABLE `lcuib-assemblies_subcateagory` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
