-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3308
-- Généré le :  lun. 02 mai 2022 à 12:43
-- Version du serveur :  5.7.28
-- Version de PHP :  7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `easlille`
--

-- --------------------------------------------------------

--
-- Structure de la table `actualites`
--

DROP TABLE IF EXISTS `actualites`;
CREATE TABLE IF NOT EXISTS `actualites` (
  `IdActualite` int(11) NOT NULL AUTO_INCREMENT,
  `Titre` varchar(50) DEFAULT NULL,
  `Contenu` text,
  `DateAffichage` date DEFAULT NULL,
  PRIMARY KEY (`IdActualite`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `actualites`
--

INSERT INTO `actualites` (`IdActualite`, `Titre`, `Contenu`, `DateAffichage`) VALUES
(6, 'promotion CAF 2022', 'Affichage campagne CAF ', '2022-06-09'),
(7, 'Recherche Sponsor ', 'CocaCola', '2022-04-03'),
(10, 'préparation match', 'videos', '2021-05-21'),
(11, 'revivre le match d\'hier', 'videos', '2022-04-08'),
(14, 'revivre le match d\'hier', 'videos', '2022-05-01'),
(16, 'revivre le match d\'hier', 'videos', '2022-04-20'),
(17, 'revivre le match d\'hier', 'videos', '2022-04-23'),
(18, 'Test', 'test', '2022-04-21');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
