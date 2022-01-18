-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mar. 18 jan. 2022 à 03:15
-- Version du serveur : 10.4.22-MariaDB
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;


-- Base de données : `annuaire`
--

-- --------------------------------------------------------

--
-- Structure de la table `person`
--

CREATE TABLE `person` (
  `id_person` int(11) NOT NULL,
  `firstname` varchar(50) DEFAULT NULL,
  `lastname` varchar(50) DEFAULT NULL,
  `phone` int(11) DEFAULT NULL,
  `mobile_phone` int(11) DEFAULT NULL,
  `mail` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `id_site` int(11) DEFAULT NULL,
  `id_service` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `person`
--

INSERT INTO `person` (`id_person`, `firstname`, `lastname`, `phone`, `mobile_phone`, `mail`, `password`, `id_site`, `id_service`) VALUES
(3, 'admin', '(administrateur)', 1, 1, 'admin', 'PaDAa5S+4VqBtRwOoi2oUSKlebNuoTPZNtRg9xdTeeQHDQ89', 1, 1),
(4, 'Jean', 'Dupont', 645257848, 312454741, 'jean@mail.fr', NULL, 2, 4),
(5, 'Laure', 'Dubois', 650575254, 326584101, 'laure@mail.fr', NULL, 2, 3);

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

CREATE TABLE `service` (
  `id_service` int(11) NOT NULL,
  `name_service` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`id_service`, `name_service`) VALUES
(1, 'commercial'),
(2, 'informatique'),
(3, 'accueil'),
(4, 'comptabilité'),
(5, 'production');

-- --------------------------------------------------------

--
-- Structure de la table `site`
--

CREATE TABLE `site` (
  `id_site` int(11) NOT NULL,
  `name_site` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `site`
--

INSERT INTO `site` (`id_site`, `name_site`) VALUES
(1, 'Lille'),
(2, 'Nice'),
(3, 'Paris'),
(4, 'Toulouse'),
(5, 'Nantes');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`id_person`),
  ADD KEY `id_service` (`id_service`),
  ADD KEY `id_site` (`id_site`);

--
-- Index pour la table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`id_service`);

--
-- Index pour la table `site`
--
ALTER TABLE `site`
  ADD PRIMARY KEY (`id_site`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `person`
--
ALTER TABLE `person`
  MODIFY `id_person` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `service`
--
ALTER TABLE `service`
  MODIFY `id_service` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `site`
--
ALTER TABLE `site`
  MODIFY `id_site` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `person`
--
ALTER TABLE `person`
  ADD CONSTRAINT `person_ibfk_1` FOREIGN KEY (`id_service`) REFERENCES `service` (`id_service`),
  ADD CONSTRAINT `person_ibfk_2` FOREIGN KEY (`id_site`) REFERENCES `site` (`id_site`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
