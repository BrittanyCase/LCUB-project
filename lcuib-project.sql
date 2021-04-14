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

-- Dumping data for table mysql.lcuib-project: ~21 rows (approximately)
/*!40000 ALTER TABLE `lcuib-project` DISABLE KEYS */;
REPLACE INTO `lcuib-project` (`project_ID`, `owner_ID`, `project_Name`, `project_description`, `Create_date`) VALUES
	(2, 2, 'placeholder', NULL, '2019-06-12'),
	(3, 3, 'Oak Ridge Hwy', NULL, '2019-09-06'),
	(4, 4, 'Test Ryne', NULL, '2019-11-12'),
	(5, 3, 'Semi Virtuous', NULL, '2020-01-20'),
	(6, 3, 'Ebenezer', NULL, '2020-04-07'),
	(7, 3, 'CB214 Fox Lonas', NULL, '2020-02-11'),
	(8, 3, 'Glenroth OH-URD Conversion', NULL, '2020-03-03'),
	(9, 3, 'Watt Rd - Truck Repair', NULL, '2020-08-03'),
	(10, 4, 'test', NULL, '2020-12-17'),
	(11, 4, 'capstone Test', NULL, '2021-01-27'),
	(12, 3, 'Watt RD', NULL, '2021-02-27'),
	(13, 3, 'HV @ Pellissippi TDOT', NULL, '2019-09-06'),
	(14, 3, 'simpson', NULL, '2019-02-11'),
	(15, 3, 'Temp Small Project', NULL, '2019-09-24'),
	(16, 3, 'CB214 Fox Lonas', NULL, '2020-03-19'),
	(17, 3, 'Float', NULL, '2020-10-29'),
	(18, 3, 'Bell Camp Pike', NULL, '2020-02-11'),
	(19, 3, 'Comprehensive', NULL, '2020-02-11'),
	(20, 4, 'Oak Ridge Hwy', NULL, '2019-06-19'),
	(21, 3, 'Semi Virtuous', NULL, '2019-07-11'),
	(22, 4, 'test', NULL, '2020-02-14'),
	(23, 5, 'virtue', NULL, '2020-08-06'),
	(24, 3, 'simpsonmkii', NULL, '2020-08-20');
/*!40000 ALTER TABLE `lcuib-project` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
