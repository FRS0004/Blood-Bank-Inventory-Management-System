-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 30, 2021 at 07:18 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `frozen_plasma`
--

CREATE TABLE `frozen_plasma` (
  `DIN` varchar(14) NOT NULL,
  `ABO` varchar(3) NOT NULL,
  `Product_Code` varchar(8) NOT NULL,
  `Expiration_Date` varchar(18) NOT NULL,
  `Holds` varchar(1) NOT NULL,
  `Location` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `frozen_plasma`
--

INSERT INTO `frozen_plasma` (`DIN`, `ABO`, `Product_Code`, `Expiration_Date`, `Holds`, `Location`) VALUES
('W115121325698F', 'A+', 'E4545V00', '5/29/2022 12:00:00', 'N', 'DISCARDED');

-- --------------------------------------------------------

--
-- Table structure for table `platelets`
--

CREATE TABLE `platelets` (
  `DIN` varchar(14) NOT NULL,
  `ABO` varchar(3) NOT NULL,
  `Product_Code` varchar(8) NOT NULL,
  `Expiration_Date` varchar(18) NOT NULL,
  `Holds` varchar(1) NOT NULL,
  `Location` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `platelets`
--

INSERT INTO `platelets` (`DIN`, `ABO`, `Product_Code`, `Expiration_Date`, `Holds`, `Location`) VALUES
('W115121325698F', 'A+', 'E3087V00', '6/3/2021 12:00:00 ', 'N', 'MONT');

-- --------------------------------------------------------

--
-- Table structure for table `rbcs`
--

CREATE TABLE `rbcs` (
  `DIN` varchar(14) NOT NULL,
  `ABO` varchar(3) NOT NULL,
  `Product_Code` varchar(8) NOT NULL,
  `Expiration_Date` varchar(18) NOT NULL,
  `Holds` char(1) NOT NULL,
  `Location` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rbcs`
--

INSERT INTO `rbcs` (`DIN`, `ABO`, `Product_Code`, `Expiration_Date`, `Holds`, `Location`) VALUES
('W115121021521P', 'O=', 'E0336V00', '7/14/2021 12:00:00', 'N', 'MONT'),
('W115121325698F', 'A+', 'E0336V00', '7/13/2021 12:00:00', 'N', 'AL101');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `frozen_plasma`
--
ALTER TABLE `frozen_plasma`
  ADD PRIMARY KEY (`DIN`);

--
-- Indexes for table `platelets`
--
ALTER TABLE `platelets`
  ADD PRIMARY KEY (`DIN`);

--
-- Indexes for table `rbcs`
--
ALTER TABLE `rbcs`
  ADD PRIMARY KEY (`DIN`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
