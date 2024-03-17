-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 17, 2024 at 03:32 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `book_store_manager`
--

-- --------------------------------------------------------

--
-- Table structure for table `autor`
--

CREATE TABLE `autor` (
  `id` int(11) NOT NULL,
  `jmeno` varchar(100) COLLATE utf8_czech_ci NOT NULL,
  `narodnost` varchar(50) COLLATE utf8_czech_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `autor`
--

INSERT INTO `autor` (`id`, `jmeno`, `narodnost`) VALUES
(1, 'Karel Čapek', 'Česká'),
(2, 'William Shakespeare', 'Britská'),
(3, 'Božena Němcová', 'Česká'),
(4, 'Nguyen Nhat Anh', 'Vietnamská'),
(9, 'Ernest Hemingway', 'Americká'),
(29, 'Victor Hugo', 'Francouzská'),
(30, 'Jeffrey Archer', 'Americká');

-- --------------------------------------------------------

--
-- Stand-in structure for view `document`
-- (See below for the actual view)
--
CREATE TABLE `document` (
`dokladID` int(11)
,`nazev` varchar(255)
,`datum` date
,`datumTo` date
,`amount` int(11)
,`jmeno` varchar(100)
,`zakaznikID` int(11)
,`bookID` int(11)
);

-- --------------------------------------------------------

--
-- Table structure for table `doklad`
--

CREATE TABLE `doklad` (
  `id` int(11) NOT NULL,
  `datum` date NOT NULL DEFAULT current_timestamp(),
  `datumTo` date DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `doklad`
--

INSERT INTO `doklad` (`id`, `datum`, `datumTo`) VALUES
(91, '2024-03-17', '2024-03-17'),
(92, '2024-03-17', '2024-03-17');

-- --------------------------------------------------------

--
-- Table structure for table `doklad_kniha`
--

CREATE TABLE `doklad_kniha` (
  `id` int(11) NOT NULL,
  `id_doklad` int(11) NOT NULL,
  `id_kniha` int(11) NOT NULL,
  `amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `doklad_kniha`
--

INSERT INTO `doklad_kniha` (`id`, `id_doklad`, `id_kniha`, `amount`) VALUES
(136, 91, 2, 1),
(137, 92, 2, 8);

-- --------------------------------------------------------

--
-- Table structure for table `doklad_zakaznik`
--

CREATE TABLE `doklad_zakaznik` (
  `id` int(11) NOT NULL,
  `id_doklad` int(11) NOT NULL,
  `id_zakaznik` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `doklad_zakaznik`
--

INSERT INTO `doklad_zakaznik` (`id`, `id_doklad`, `id_zakaznik`) VALUES
(71, 91, 1),
(72, 92, 1);

-- --------------------------------------------------------

--
-- Table structure for table `kniha`
--

CREATE TABLE `kniha` (
  `id` int(11) NOT NULL,
  `nazev` varchar(255) COLLATE utf8_czech_ci NOT NULL,
  `rok_vydani` smallint(4) NOT NULL,
  `cena` double NOT NULL,
  `zanr` varchar(255) COLLATE utf8_czech_ci NOT NULL,
  `amount` int(11) NOT NULL,
  `popis` text COLLATE utf8_czech_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `kniha`
--

INSERT INTO `kniha` (`id`, `nazev`, `rok_vydani`, `cena`, `zanr`, `amount`, `popis`) VALUES
(2, 'Bílá nemoc', 1937, 100, 'drama', 60, 'a'),
(3, 'Romeo and Juliet', 1597, 200, 'drama', 138, 'Romeo a Julie (Romeo and Juliet)'),
(4, 'Mat Biec', 2010, 200, 'román', 145, 'Popis pro Mat Biec '),
(50, 'Bídnici', 1844, 500, 'drama', 300, 'Román Bídníci působí nespojitě a jediným dějovým pojítkem je hlavní postava Jean Valjean, což je nejprve vězeň číslo 24601. Jean Valjean byl odsouzen za krádež chleba k pěti letům na galejích, ale kvůli pokusům o útěk je vězněm devatenáct let. Po propuštění se setká s biskupem Myrielem, kterému ukradne stříbrné příbory a svícny, Valjeana brzy s lupem dopadnou, biskup policii řekne, že mu svícny a příbory daroval. Tento šlechetný skutek změní Jeanu Valjeanovi celý život, stává se z něj úspěšný podnikatel, který svého bohatství využívá ve prospěch chudých. Jako protiklad chování Jeana Valjeana je v knize zdůrazňováno chování policejního prefekta Javerta, který se tak stává příkladem „pedantské“ moci (respektive „přísného řádu“. Javert až slepě dodržuje zákon, Jean Valjean je pro něj navždy galejník a jako s takovým s ním i zachází).');

-- --------------------------------------------------------

--
-- Table structure for table `kniha_autor`
--

CREATE TABLE `kniha_autor` (
  `id` int(11) NOT NULL,
  `id_kniha` int(11) NOT NULL,
  `id_autor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `kniha_autor`
--

INSERT INTO `kniha_autor` (`id`, `id_kniha`, `id_autor`) VALUES
(157, 2, 1),
(158, 3, 2),
(159, 4, 4),
(160, 50, 29);

-- --------------------------------------------------------

--
-- Stand-in structure for view `kniha_autor_view`
-- (See below for the actual view)
--
CREATE TABLE `kniha_autor_view` (
`id` int(11)
,`nazev` varchar(255)
,`cena` double
,`amount` int(11)
,`jmeno` varchar(100)
,`autor_id` int(11)
);

-- --------------------------------------------------------

--
-- Table structure for table `zakaznik`
--

CREATE TABLE `zakaznik` (
  `id` int(11) NOT NULL,
  `jmeno` varchar(100) COLLATE utf8_czech_ci NOT NULL,
  `email` varchar(255) COLLATE utf8_czech_ci NOT NULL,
  `phoneNumber` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `zakaznik`
--

INSERT INTO `zakaznik` (`id`, `jmeno`, `email`, `phoneNumber`) VALUES
(1, 'David Duong', 'dd@gmail.com', 123456798),
(2, 'zakaznik 1', 'zakaznik1@gmail.com', 445975321),
(30, 'XuanAnh', 'david.anh@email.cz', 2147483647);

-- --------------------------------------------------------

--
-- Structure for view `document`
--
DROP TABLE IF EXISTS `document`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `document`  AS SELECT `doklad`.`id` AS `dokladID`, `kniha`.`nazev` AS `nazev`, `doklad`.`datum` AS `datum`, `doklad`.`datumTo` AS `datumTo`, `kd`.`amount` AS `amount`, `zakaznik`.`jmeno` AS `jmeno`, `zakaznik`.`id` AS `zakaznikID`, `kniha`.`id` AS `bookID` FROM ((((`doklad` join `doklad_kniha` `kd` on(`doklad`.`id` = `kd`.`id_doklad`)) join `kniha` on(`kniha`.`id` = `kd`.`id_kniha`)) join `doklad_zakaznik` `dz` on(`dz`.`id_doklad` = `doklad`.`id`)) join `zakaznik` on(`zakaznik`.`id` = `dz`.`id_zakaznik`)) WHERE `doklad`.`datumTo` is not null ;

-- --------------------------------------------------------

--
-- Structure for view `kniha_autor_view`
--
DROP TABLE IF EXISTS `kniha_autor_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `kniha_autor_view`  AS SELECT `k`.`id` AS `id`, `k`.`nazev` AS `nazev`, `k`.`cena` AS `cena`, `k`.`amount` AS `amount`, `a`.`jmeno` AS `jmeno`, `a`.`id` AS `autor_id` FROM ((`kniha` `k` join `kniha_autor` `ka` on(`k`.`id` = `ka`.`id_kniha`)) join `autor` `a` on(`a`.`id` = `ka`.`id_autor`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `autor`
--
ALTER TABLE `autor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `doklad`
--
ALTER TABLE `doklad`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `doklad_kniha`
--
ALTER TABLE `doklad_kniha`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `doklad_zakaznik`
--
ALTER TABLE `doklad_zakaznik`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `kniha`
--
ALTER TABLE `kniha`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `kniha_autor`
--
ALTER TABLE `kniha_autor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `zakaznik`
--
ALTER TABLE `zakaznik`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `autor`
--
ALTER TABLE `autor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `doklad`
--
ALTER TABLE `doklad`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=94;

--
-- AUTO_INCREMENT for table `doklad_kniha`
--
ALTER TABLE `doklad_kniha`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=139;

--
-- AUTO_INCREMENT for table `doklad_zakaznik`
--
ALTER TABLE `doklad_zakaznik`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=74;

--
-- AUTO_INCREMENT for table `kniha`
--
ALTER TABLE `kniha`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `kniha_autor`
--
ALTER TABLE `kniha_autor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=161;

--
-- AUTO_INCREMENT for table `zakaznik`
--
ALTER TABLE `zakaznik`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
