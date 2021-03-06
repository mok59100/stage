DROP DATABASE IF EXISTS EASLille; 
CREATE DATABASE EASLille DEFAULT CHARACTER SET utf8;
USE EASLille;

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

-- --------------------------------------------------------

--
-- Structure de la table `adhesions`
--

DROP TABLE IF EXISTS `adhesions`;
CREATE TABLE IF NOT EXISTS `adhesions` (
  `IdAdhesion` int(11) NOT NULL AUTO_INCREMENT,
  `DateDebutAdhesion` date DEFAULT NULL,
  `DateFinAdhesion` date DEFAULT NULL,
  `IdUtilisateur` int(11) NOT NULL,
  PRIMARY KEY (`IdAdhesion`),
  KEY `FK_Adhesions_Utilisateurs` (`IdUtilisateur`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `adhesions`
--

INSERT INTO `adhesions` (`IdAdhesion`, `DateDebutAdhesion`, `DateFinAdhesion`, `IdUtilisateur`) VALUES
(1, '2022-04-14', '2022-04-21', 2);

-- --------------------------------------------------------

--
-- Structure de la table `appartient`
--

DROP TABLE IF EXISTS `appartient`;
CREATE TABLE IF NOT EXISTS `appartient` (
  `IdActualite` int(11) NOT NULL AUTO_INCREMENT,
  `IdVideo` int(11) NOT NULL,
  PRIMARY KEY (`IdActualite`),
  KEY `FK_Appartient_Videos` (`IdVideo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `contient`
--

DROP TABLE IF EXISTS `contient`;
CREATE TABLE IF NOT EXISTS `contient` (
  `IdActualite` int(11) NOT NULL AUTO_INCREMENT,
  `IdImage` int(11) NOT NULL,
  PRIMARY KEY (`IdActualite`),
  KEY `FK_Contient_Images` (`IdImage`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `contient`
--

INSERT INTO `contient` (`IdActualite`, `IdImage`) VALUES
(6, 2),
(7, 4);

-- --------------------------------------------------------

--
-- Structure de la table `cotisations`
--

DROP TABLE IF EXISTS `cotisations`;
CREATE TABLE IF NOT EXISTS `cotisations` (
  `IdCotisation` int(11) NOT NULL AUTO_INCREMENT,
  `EtatCotisation` varchar(50) DEFAULT NULL,
  `MontantCotisation` varchar(50) DEFAULT NULL,
  `ModePaiement` varchar(50) DEFAULT NULL,
  `DateCotisation` date DEFAULT NULL,
  `IdUtilisateur` int(11) NOT NULL,
  PRIMARY KEY (`IdCotisation`),
  KEY `FK_Cotisations_Utilisateurs` (`IdUtilisateur`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `cotisations`
--

INSERT INTO `cotisations` (`IdCotisation`, `EtatCotisation`, `MontantCotisation`, `ModePaiement`, `DateCotisation`, `IdUtilisateur`) VALUES
(1, 'à jour', '55', 'chèque', '2022-03-08', 4),
(3, 'à jour', '50.00', 'chèque', '2022-03-15', 3),
(4, 'à jour', '50.00', 'espece', '2021-12-08', 2),
(5, 'paye', '25', 'espece', '2022-05-22', 4);

-- --------------------------------------------------------

--
-- Structure de la table `dons`
--

DROP TABLE IF EXISTS `dons`;
CREATE TABLE IF NOT EXISTS `dons` (
  `IdDon` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) DEFAULT NULL,
  `Prenom` varchar(50) DEFAULT NULL,
  `LibelleDon` text,
  `MontantDon` decimal(15,2) DEFAULT NULL,
  PRIMARY KEY (`IdDon`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `dons`
--

INSERT INTO `dons` (`IdDon`, `Nom`, `Prenom`, `LibelleDon`, `MontantDon`) VALUES
(1, 'pierrin', 'didier', 'don travaux terrain', '2000.00'),
(2, 'admin', 'admin', 'don filet foot', '15.50'),
(4, 'jeannot', 'jean pierre', 'Achat filets et Ballons', '1500.00'),
(5, 'Terki', 'moktar', 'Achat filets et Ballons', '25.00'),
(6, 'pieer', 'luc', 'bouteille d\'eau', '200.00'),
(7, 'pieer', 'luc', 'Achat filets et Ballons', '25.00'),
(8, 'Terki', 'moktar', 'bouteille d\'eau', '200.00'),
(9, 'Terki', 'moktar', 'bouteille d\'eau', '200.00');

-- --------------------------------------------------------

--
-- Structure de la table `images`
--

DROP TABLE IF EXISTS `images`;
CREATE TABLE IF NOT EXISTS `images` (
  `IdImage` int(11) NOT NULL AUTO_INCREMENT,
  `Description` varchar(100) DEFAULT NULL,
  `images` varchar(100) NOT NULL,
  PRIMARY KEY (`IdImage`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `images`
--

INSERT INTO `images` (`IdImage`, `Description`, `images`) VALUES
(1, 'image affiche match ', 'imageFoot2'),
(2, 'image recherche sponsor ', 'imageFoot'),
(3, 'image affiche match ', 'imageFoot1'),
(4, 'image recherche sponsors ', 'imageFoot3');

-- --------------------------------------------------------

--
-- Structure de la table `messages`
--

DROP TABLE IF EXISTS `messages`;
CREATE TABLE IF NOT EXISTS `messages` (
  `IdMessage` int(11) NOT NULL AUTO_INCREMENT,
  `Auteur` varchar(50) NOT NULL,
  `Contenu` text NOT NULL,
  `Create_at` datetime DEFAULT NULL,
  PRIMARY KEY (`IdMessage`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `messages`
--

INSERT INTO `messages` (`IdMessage`, `Auteur`, `Contenu`, `Create_at`) VALUES
(1, 'momo', 'ww', '2022-05-13 15:38:20'),
(2, 'momo', '', '2022-05-13 15:38:23'),
(3, 'momo', 'ca va ', '2022-05-13 15:38:27'),
(4, 'eeee', '', '2022-05-13 15:46:07'),
(5, 'eeee', 'eeee', '2022-05-13 15:46:09'),
(6, 'eeee', '', '2022-05-13 15:46:11'),
(7, 'moktar', 'salut', '2022-05-13 16:00:39'),
(9, 'DD', 'DS', '2022-05-13 16:22:39'),
(10, 'Lior', 'cxbb', '2022-05-13 16:26:08'),
(11, '', '', '2022-05-13 17:12:50'),
(12, '', 'ddd', '2022-05-13 17:16:18'),
(13, '', '', '2022-05-13 17:17:46'),
(16, 'Lior', 'super et toi', '2022-05-13 17:19:46'),
(17, 'Lior', 'ca va cool', '2022-05-13 17:19:51'),
(18, 'Lior', 'c\'est bientot la certification', '2022-05-13 17:20:05'),
(19, 'Lior', 'ca sera le 02/06 ou 03/06', '2022-05-13 17:20:24'),
(20, 'Lior', 'oui ca va aller', '2022-05-13 17:20:32'),
(21, 'Lior', 'bien sur ', '2022-05-13 17:20:37'),
(22, 'moktar', 'super ', '2022-05-13 17:20:54'),
(23, 'moktar', 'ca ira ', '2022-05-13 17:20:59'),
(24, '', '', '2022-05-13 17:28:23'),
(25, 'moktar', 'coucou', '2022-05-16 09:24:52'),
(26, 'mpoktar', 'salut ca va ', '2022-05-16 10:57:23');


-- --------------------------------------------------------

--
-- Structure de la table `roles`
--

DROP TABLE IF EXISTS `roles`;
CREATE TABLE IF NOT EXISTS `roles` (
  `IdRole` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleRole` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdRole`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `roles`
--

INSERT INTO `roles` (`IdRole`, `LibelleRole`) VALUES
(1, 'utilisateur'),
(2, 'administrateur');

-- --------------------------------------------------------

--
-- Structure de la table `textes`
--

DROP TABLE IF EXISTS `textes`;
CREATE TABLE IF NOT EXISTS `textes` (
  `idTexte` int(11) NOT NULL AUTO_INCREMENT,
  `codeTexte` varchar(50) NOT NULL,
  `fr` longtext NOT NULL,
  `en` longtext NOT NULL,
  PRIMARY KEY (`idTexte`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `textes`
--

INSERT INTO `textes` (`idTexte`, `codeTexte`, `fr`, `en`) VALUES
(1, 'Bonjour', 'Bonjour', 'Hello'),
(2, 'Connexion', 'Connexion', 'Log in'),
(3, 'Deconnexion', 'Deconnexion', 'Log out'),
(4, 'Accueil', 'Accueil', 'Home'),
(5, 'AdresseEmail', 'Adresse email', 'Email address'),
(6, 'Mdp', 'Mot de passe', 'Password'),
(7, 'Inscription', 'Inscription', 'Registration'),
(8, 'Nom', 'Nom', 'Surname'),
(9, 'Prenom', 'Prenom', 'Name'),
(10, 'InfoMdpLegend', 'Veuillez saisir au moins', 'Please enter at least'),
(11, 'UneMajuscule', '1 majuscule', '1 uppercase'),
(12, 'UneMinuscule', '1 minuscule', '1 lowercase'),
(13, 'UnChiffre', '1 chiffre', '1 number'),
(14, 'UnCaractereSpecial', '1 caractère spécial ( ! @ & # * ^ $ % +)', '1 special character ( ! @ & # * ^ $ % +)'),
(15, 'MinimumCaractere', '8 caractères', '8 character'),
(16, 'Confirmation', 'Confirmation', 'Confirmation'),
(17, 'Reset', 'Réinitialisation', 'Reset'),
(18, 'inputDefault', 'Choisir une valeur', 'Choose a value'),
(19, 'Envoyer', 'Envoyer', 'Send'),
(20, 'Bonjour', 'Bonjour', 'Hello'),
(21, 'Connexion', 'Connexion', 'Log in'),
(22, 'Deconnexion', 'Deconnexion', 'Log out'),
(23, 'Accueil', 'Accueil', 'Home'),
(24, 'AdresseEmail', 'Adresse email', 'Email address'),
(25, 'Mdp', 'Mot de passe', 'Password'),
(26, 'Inscription', 'Inscription', 'Registration'),
(27, 'Nom', 'Nom', 'Surname'),
(28, 'Prenom', 'Prenom', 'Name'),
(29, 'InfoMdpLegend', 'Veuillez saisir au moins', 'Please enter at least'),
(30, 'UneMajuscule', '1 majuscule', '1 uppercase'),
(31, 'UneMinuscule', '1 minuscule', '1 lowercase'),
(32, 'UnChiffre', '1 chiffre', '1 number'),
(33, 'UnCaractereSpecial', '1 caractère spécial ( ! @ & # * ^ $ % +)', '1 special character ( ! @ & # * ^ $ % +)'),
(34, 'MinimumCaractere', '8 caractères', '8 character'),
(35, 'Confirmation', 'Confirmation', 'Confirmation'),
(36, 'Reset', 'Réinitialisation', 'Reset'),
(37, 'inputDefault', 'Choisir une valeur', 'Choose a value'),
(38, 'Envoyer', 'Envoyer', 'Send');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

DROP TABLE IF EXISTS `utilisateurs`;
CREATE TABLE IF NOT EXISTS `utilisateurs` (
  `IdUtilisateur` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) NOT NULL,
  `Prenom` varchar(50) NOT NULL,
  `AdresseMail` varchar(50) NOT NULL,
  `MotDePasse` varchar(50) NOT NULL,
  `TelephoneUtilisateur` int(11) DEFAULT NULL,
  `SituationProfessionnelle` varchar(50) DEFAULT NULL,
  `Active` tinyint(1) DEFAULT NULL,
  `IdRole` int(11) NOT NULL,
  PRIMARY KEY (`IdUtilisateur`),
  UNIQUE KEY `AdresseMail` (`AdresseMail`),
  KEY `FK_Utilisateurs_Roles` (`IdRole`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`IdUtilisateur`, `Nom`, `Prenom`, `AdresseMail`, `MotDePasse`, `TelephoneUtilisateur`, `SituationProfessionnelle`, `Active`, `IdRole`) VALUES
(2, 'admin', 'admin', 'admin@gmail.fr', '', 652321452, 'formation', 1, 2),
(3, 'terki', 'moktar', 'moktar.terki@gmail.com', '', 666558963, 'formation', 1, 1),
(4, 'ad', 'ad', 'ad@gmail.com', '', 666558963, 'formation', 1, 1),
(10, 'administrateur', 'administrateur', 'administrateur@gmail.fr', '1039c5bba2f583c93c62dc41a3cb365f', 320529686, 'formation', 1, 2),
(11, 'utilisateur', 'utilisateur', 'utilisateur@gmail.fr', '1039c5bba2f583c93c62dc41a3cb365f', 320258956, 'formation', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `videos`
--

DROP TABLE IF EXISTS `videos`;
CREATE TABLE IF NOT EXISTS `videos` (
  `IdVideo` int(11) NOT NULL AUTO_INCREMENT,
  `Description` varchar(100) DEFAULT NULL,
  `videos` varchar(100) NOT NULL,
  PRIMARY KEY (`IdVideo`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `videos`
--

INSERT INTO `videos` (`IdVideo`, `Description`, `videos`) VALUES
(2, 'vidéo match 25/08/2021', 'videoFoot4'),
(3, 'video match stade jean Bouin', 'videoFoot5');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `adhesions`
--
ALTER TABLE `adhesions`
  ADD CONSTRAINT `FK_Adhesions_Utilisateurs` FOREIGN KEY (`IdUtilisateur`) REFERENCES `utilisateurs` (`IdUtilisateur`);

--
-- Contraintes pour la table `appartient`
--
ALTER TABLE `appartient`
  ADD CONSTRAINT `FK_Appartient_Actualites` FOREIGN KEY (`IdActualite`) REFERENCES `actualites` (`IdActualite`),
  ADD CONSTRAINT `FK_Appartient_Videos` FOREIGN KEY (`IdVideo`) REFERENCES `videos` (`IdVideo`);

--
-- Contraintes pour la table `contient`
--
ALTER TABLE `contient`
  ADD CONSTRAINT `FK_Contient_Actualites` FOREIGN KEY (`IdActualite`) REFERENCES `actualites` (`IdActualite`),
  ADD CONSTRAINT `FK_Contient_Images` FOREIGN KEY (`IdImage`) REFERENCES `images` (`IdImage`);

--
-- Contraintes pour la table `cotisations`
--
ALTER TABLE `cotisations`
  ADD CONSTRAINT `FK_Cotisations_Utilisateurs` FOREIGN KEY (`IdUtilisateur`) REFERENCES `utilisateurs` (`IdUtilisateur`);

--
-- Contraintes pour la table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  ADD CONSTRAINT `FK_Utilisateurs_Roles` FOREIGN KEY (`IdRole`) REFERENCES `roles` (`IdRole`);
COMMIT;


