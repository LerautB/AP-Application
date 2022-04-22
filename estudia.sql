-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : ven. 22 avr. 2022 à 18:36
-- Version du serveur : 10.4.22-MariaDB
-- Version de PHP : 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `estudia`
--

DELIMITER $$
--
-- Procédures
--
CREATE DEFINER=`ipssisqestudia`@`%` PROCEDURE `recupConvUser` (IN `p_idUser` INT)  BEGIN 
    
    SELECT COUNT(*)
    FROM conversations
    WHERE idEnvoyeur = p_idUser OR idReceveur = p_idUser;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

CREATE TABLE `absence` (
  `idAbsence` int(11) NOT NULL,
  `idUtilisateur` int(11) NOT NULL,
  `idProf` int(11) NOT NULL,
  `justification` varchar(100) NOT NULL,
  `verifJustification` varchar(3) NOT NULL,
  `idCours` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déclencheurs `absence`
--
DELIMITER $$
CREATE TRIGGER `AppelDone` AFTER INSERT ON `absence` FOR EACH ROW UPDATE edt SET edt.appel = 1 WHERE edt.idCours = idCours
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `conversations`
--

CREATE TABLE `conversations` (
  `idConversation` int(11) NOT NULL,
  `idEnvoyeur` int(11) NOT NULL,
  `idReceveur` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `devoirs`
--

CREATE TABLE `devoirs` (
  `idDevoir` int(11) NOT NULL,
  `idEtude` int(11) NOT NULL,
  `idProf` int(11) NOT NULL,
  `idMatiere` int(11) NOT NULL,
  `Titre` varchar(100) NOT NULL,
  `Info` varchar(100) DEFAULT NULL,
  `laDate` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `devoirs`
--

INSERT INTO `devoirs` (`idDevoir`, `idEtude`, `idProf`, `idMatiere`, `Titre`, `Info`, `laDate`) VALUES
(1, 16, 60, 5, 'rtest', 'Exo 1,2,3', '2022-04-22'),
(2, 18, 60, 5, 'Exercice', 'Exo 1,2,3', '2022-04-22');

-- --------------------------------------------------------

--
-- Structure de la table `edt`
--

CREATE TABLE `edt` (
  `idCours` int(11) NOT NULL,
  `idUtilisateur` int(11) NOT NULL,
  `idSalle` int(11) NOT NULL,
  `idClasse` int(11) NOT NULL,
  `matiere` varchar(100) NOT NULL,
  `date` date NOT NULL,
  `horaireDebut` time NOT NULL,
  `horaireFin` time NOT NULL,
  `appel` tinyint(1) DEFAULT NULL,
  `resumeCours` varchar(150) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `edt`
--

INSERT INTO `edt` (`idCours`, `idUtilisateur`, `idSalle`, `idClasse`, `matiere`, `date`, `horaireDebut`, `horaireFin`, `appel`, `resumeCours`) VALUES
(1, 83, 1, 17, 'Physique-Chimie', '2022-04-14', '08:30:00', '09:30:00', 0, NULL),
(2, 60, 2, 17, 'Histoire-Géographie', '2022-04-14', '09:30:00', '10:30:00', 0, NULL),
(3, 82, 3, 17, 'Science', '2022-04-14', '10:45:00', '11:30:00', 0, NULL),
(4, 81, 4, 17, 'Mathématiques', '2022-04-14', '11:30:00', '12:30:00', 0, NULL),
(5, 80, 5, 17, 'Français', '2022-04-14', '13:30:00', '14:30:00', 0, NULL),
(6, 84, 5, 17, 'Anglais', '2022-04-14', '14:30:00', '16:30:00', 0, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `eleve`
--

CREATE TABLE `eleve` (
  `nom` varchar(100) NOT NULL,
  `prenom` varchar(100) NOT NULL,
  `idUtilisateur` int(11) NOT NULL,
  `IDfiliere` int(11) DEFAULT NULL,
  `idEtude` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `eleve`
--

INSERT INTO `eleve` (`nom`, `prenom`, `idUtilisateur`, `IDfiliere`, `idEtude`) VALUES
('Dufour', 'Adrien', 109, 3, 18),
('Dupont', 'Alexandre', 108, 3, 18),
('Dupont', 'Andréa', 107, 3, 18),
('Renault', 'Megane', 106, 3, 18),
('Cook', 'Rachel', 105, 3, 18),
('Sanchez', 'Roberto', 104, 3, 18),
('Poitiers', 'Roger', 103, 3, 18),
('Georges', 'Lucas', 102, 3, 18),
('Hauchard', 'Lucas', 101, 3, 18),
('Rochu', 'Samy', 100, 3, 18),
('Canyon', 'Luc', 99, 3, 18),
('Michel', 'Hugo', 98, 3, 18),
('Hasley', 'Loris', 97, 2, 17),
('Daval', 'Enzo', 96, 2, 17),
('Maille', 'Corentin', 95, 2, 17),
('Barbier', 'Nathan', 94, 2, 17),
('Chauveau', 'Damien', 93, 2, 17),
('Chaumont', 'Romain', 92, 2, 17),
('Leraut', 'Bastien', 91, 2, 17),
('Julia', 'Clément', 90, 2, 17),
('Cavaille-Coll', 'Théodore', 89, 2, 17),
('Carneiro', 'David', 76, 2, 17),
('Tisba', 'Raphaël', 88, 2, 17),
('Treflest', 'Remy', 87, 2, 17),
('Vincenti', 'Enzo', 110, 3, 18),
('Vincent', 'Tim', 111, 3, 18);

-- --------------------------------------------------------

--
-- Structure de la table `enseignants`
--

CREATE TABLE `enseignants` (
  `idEnseignant` int(11) NOT NULL,
  `Nom` varchar(100) NOT NULL,
  `Prenom` varchar(100) NOT NULL,
  `idUtilisateur` int(11) NOT NULL,
  `idFiliere` int(11) DEFAULT NULL,
  `idMatiere` int(11) NOT NULL,
  `matiere` varchar(100) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `enseignants`
--

INSERT INTO `enseignants` (`idEnseignant`, `Nom`, `Prenom`, `idUtilisateur`, `idFiliere`, `idMatiere`, `matiere`) VALUES
(16, 'Franck', 'Anne', 83, NULL, 4, 'Physique-Chimie'),
(8, 'Lapuce', 'Marie', 60, NULL, 5, 'Histoire-Géographie'),
(15, 'Laplace', 'Géraldine', 82, NULL, 3, 'Science'),
(14, 'Durand', 'Emile', 81, NULL, 2, 'Mathématiques'),
(13, 'Pestel', 'Jean', 80, NULL, 1, 'Français'),
(17, 'Jackson', 'John', 84, NULL, 6, 'Anglais'),
(18, 'Legalle', 'Thierry', 85, NULL, 9, 'Sport'),
(20, 'Alejandro', 'De Fougas', 112, NULL, 7, 'Espagnol'),
(21, 'Mickael', 'Le Bras', 113, NULL, 9, 'Sport');

-- --------------------------------------------------------

--
-- Structure de la table `etudes`
--

CREATE TABLE `etudes` (
  `idEtude` int(11) NOT NULL,
  `classe` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `etudes`
--

INSERT INTO `etudes` (`idEtude`, `classe`, `nom`) VALUES
(16, 1, 'Seconde'),
(17, 1, 'Premiere'),
(18, 1, 'Terminale');

-- --------------------------------------------------------

--
-- Structure de la table `examen`
--

CREATE TABLE `examen` (
  `idExamen` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `idProf` int(11) NOT NULL,
  `matiere` varchar(100) NOT NULL,
  `idEtude` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `examen`
--

INSERT INTO `examen` (`idExamen`, `nom`, `idProf`, `matiere`, `idEtude`) VALUES
(1, 'TEST', 60, '5', 17);

-- --------------------------------------------------------

--
-- Structure de la table `filiere`
--

CREATE TABLE `filiere` (
  `IDfiliere` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `filiere`
--

INSERT INTO `filiere` (`IDfiliere`, `nom`) VALUES
(1, 'Economique et sociale'),
(2, 'Littéraire'),
(3, 'Scientifique'),
(4, 'Sciences et Technologies du Management et de la Gestion '),
(5, 'Sciences et Technologies de l\'Industrie et du Développement Durable'),
(6, 'Générale');

-- --------------------------------------------------------

--
-- Structure de la table `ipadmin`
--

CREATE TABLE `ipadmin` (
  `idIpAllowed` int(11) NOT NULL,
  `ip` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `ipadmin`
--

INSERT INTO `ipadmin` (`idIpAllowed`, `ip`) VALUES
(1, '::1:');

-- --------------------------------------------------------

--
-- Structure de la table `ipbanned`
--

CREATE TABLE `ipbanned` (
  `idBanIp` int(11) NOT NULL,
  `ip` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `logs`
--

CREATE TABLE `logs` (
  `idLog` int(11) NOT NULL,
  `idUtilisateur` int(11) NOT NULL,
  `date` datetime NOT NULL,
  `ip` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `logs`
--

INSERT INTO `logs` (`idLog`, `idUtilisateur`, `date`, `ip`) VALUES
(1, 1, '2022-04-14 13:02:04', '::1'),
(2, 1, '2022-04-14 13:02:10', '::1'),
(3, 1, '2022-04-14 13:02:21', '::1'),
(4, 1, '2022-04-14 13:02:41', '::1'),
(5, 1, '2022-04-14 13:03:35', '::1'),
(6, 60, '2022-04-14 14:05:29', '::1'),
(7, 1, '2022-04-14 14:13:28', '::1'),
(8, 1, '2022-04-14 14:13:49', '::1'),
(9, 1, '2022-04-14 14:15:18', '::1'),
(10, 1, '2022-04-22 10:33:17', '::1'),
(11, 111, '2022-04-22 10:33:55', '::1'),
(12, 60, '2022-04-22 11:03:57', '::1'),
(13, 1, '2022-04-22 13:06:52', '::1'),
(14, 60, '2022-04-22 14:56:46', '::1');

-- --------------------------------------------------------

--
-- Structure de la table `matieres`
--

CREATE TABLE `matieres` (
  `idMatiere` int(11) NOT NULL,
  `matiere` varchar(100) NOT NULL,
  `CoefMatiere` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `matieres`
--

INSERT INTO `matieres` (`idMatiere`, `matiere`, `CoefMatiere`) VALUES
(1, 'Français', 5),
(2, 'Mathématiques', 7),
(3, 'Science', 8),
(4, 'Physique-Chimie', 6),
(5, 'Histoire-Géographie', 3),
(6, 'Anglais', 3),
(7, 'Espagnol', 2),
(9, 'Sport', 2);

-- --------------------------------------------------------

--
-- Structure de la table `messages`
--

CREATE TABLE `messages` (
  `idMessage` int(11) NOT NULL,
  `idConversation` int(11) NOT NULL,
  `idEnvoyeur` int(11) DEFAULT NULL,
  `idReceveur` int(11) DEFAULT NULL,
  `message` varchar(400) DEFAULT NULL,
  `date_envoie` date DEFAULT NULL,
  `heure_envoie` time DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `notes`
--

CREATE TABLE `notes` (
  `idNote` int(11) NOT NULL,
  `idUtilisateur` int(11) NOT NULL,
  `idProf` int(11) NOT NULL,
  `Note` float DEFAULT NULL,
  `idMatiere` int(11) NOT NULL,
  `idExamen` int(11) NOT NULL,
  `designation` varchar(255) NOT NULL,
  `NoteMax` int(2) NOT NULL DEFAULT 20,
  `Coef` int(11) NOT NULL,
  `Commentaire` text DEFAULT NULL,
  `dateNote` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `notes`
--

INSERT INTO `notes` (`idNote`, `idUtilisateur`, `idProf`, `Note`, `idMatiere`, `idExamen`, `designation`, `NoteMax`, `Coef`, `Commentaire`, `dateNote`) VALUES
(2, 111, 60, 16, 5, 1, 'TEST', 20, 1, 'TEST', '2022-04-22'),
(3, 94, 60, 10, 5, 1, 'TEST', 20, 2, '', '2022-04-22'),
(4, 76, 60, 14, 5, 1, 'TEST', 20, 2, '', '2022-04-22'),
(5, 89, 60, 13, 5, 1, 'TEST', 20, 2, '', '2022-04-22'),
(6, 92, 60, 12, 5, 1, 'TEST', 20, 2, '', '2022-04-22'),
(7, 93, 60, 12, 5, 1, 'TEST', 20, 2, '', '2022-04-22'),
(8, 96, 60, 12, 5, 1, 'TEST', 20, 2, '', '2022-04-22'),
(9, 97, 60, 12, 5, 1, 'TEST', 20, 2, '', '2022-04-22'),
(10, 90, 60, 12, 5, 1, 'TEST', 20, 2, '', '2022-04-22'),
(11, 91, 60, 12, 5, 1, 'TEST', 20, 2, '', '2022-04-22'),
(12, 95, 60, 12, 5, 1, 'TEST', 20, 2, '', '2022-04-22'),
(13, 88, 60, 12, 5, 1, 'TEST', 20, 2, '', '2022-04-22'),
(14, 87, 60, 12, 5, 1, 'TEST', 20, 2, '', '2022-04-22');

-- --------------------------------------------------------

--
-- Structure de la table `punition`
--

CREATE TABLE `punition` (
  `idPunition` int(11) NOT NULL,
  `idEleve` int(11) NOT NULL,
  `idUtilisateur` int(11) NOT NULL,
  `motif` text NOT NULL,
  `ladate` date NOT NULL,
  `punition` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `retards`
--

CREATE TABLE `retards` (
  `idRetard` int(11) NOT NULL,
  `idUtilisateur` int(11) NOT NULL,
  `idProf` int(11) NOT NULL,
  `justification` varchar(100) NOT NULL,
  `verifJustification` varchar(3) NOT NULL,
  `idCours` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `retards`
--

INSERT INTO `retards` (`idRetard`, `idUtilisateur`, `idProf`, `justification`, `verifJustification`, `idCours`) VALUES
(1, 111, 60, 'TEST', 'non', 2);

--
-- Déclencheurs `retards`
--
DELIMITER $$
CREATE TRIGGER `AppelDoneBIS` AFTER INSERT ON `retards` FOR EACH ROW UPDATE edt SET edt.appel = 1 WHERE edt.idCours = idCours
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `salle`
--

CREATE TABLE `salle` (
  `idSalle` int(11) NOT NULL,
  `numero` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `salle`
--

INSERT INTO `salle` (`idSalle`, `numero`) VALUES
(1, 101),
(2, 102),
(3, 103),
(4, 104),
(5, 105),
(6, 106),
(7, 107),
(8, 108),
(9, 201),
(10, 202);

-- --------------------------------------------------------

--
-- Structure de la table `statuts`
--

CREATE TABLE `statuts` (
  `idStatut` int(11) NOT NULL,
  `statut` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `statuts`
--

INSERT INTO `statuts` (`idStatut`, `statut`) VALUES
(1, 'root'),
(2, 'Administration'),
(3, 'Professeur'),
(4, 'Etudiant');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `idUtilisateur` int(11) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `identifiant` varchar(100) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `prenom` varchar(100) NOT NULL,
  `dateNaiss` date NOT NULL,
  `mdp` varchar(100) NOT NULL,
  `mdpTemp` varchar(100) NOT NULL,
  `statut` varchar(100) DEFAULT NULL,
  `token` varchar(30) DEFAULT NULL,
  `PremiereConnexion` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`idUtilisateur`, `email`, `identifiant`, `nom`, `prenom`, `dateNaiss`, `mdp`, `mdpTemp`, `statut`, `token`, `PremiereConnexion`) VALUES
(1, 'superadmin@gmail.com', 'ASuper05', 'Super', 'Admin', '2000-01-01', '$2y$10$W035IQJDEm3PPnPJ0Y22cuRDZp1iCU9A8jjl7Wux7ic97K0zkD7OW', 'iRS2KwDs', 'Administration', NULL, 1),
(118, NULL, 'ttest65', 'test', 'test', '2022-04-18', '$2a$11$yPfgYuuRhspdBz3UBV.s6.WplbfpCoF.bMm/a9ztq2kUWmZTo1SZ.', '6GhqXmH3', 'Etudiant', NULL, 0),
(113, '', 'MLe Bras45', 'Mickael', 'Le Bras', '1991-04-14', '$2a$11$kP0d053DpcYPqEeh7fjFeujBX3df9piOAXAdCdzjA4M8ZgQdLhXpy', 'dhl2D7MW', 'Professeur', NULL, 1),
(112, '', 'ADe Fougas29', 'Alejandro', 'De Fougas', '1981-04-14', '$2a$11$srUgWPG4Mooc1HFZYb84EelUwherDQxKt2rHy107CnWBwXW5aDM9y', 'mdYKRZAN', 'Professeur', NULL, 0),
(111, '', 'TVincent41', 'Vincent', 'Tim', '2020-01-14', '$2a$11$lerffqjEf3iMU728y9WVeulKMVCrnhVX0UwolPP5LPCvrcXMOwA5y', 'AMWB43t6', 'Etudiant', NULL, 1),
(110, '', 'EVincenti15', 'Vincenti', 'Enzo', '2022-04-14', '$2a$11$ZP7SSEjiX/ZfY9IYMIn4f.CWyOZfohjGGdckliwCZzqDMMHT/MeqO', 'r5eLOTv9', 'Etudiant', NULL, 0),
(109, '', 'ADufour49', 'Dufour', 'Adrien', '2000-09-11', '$2a$11$AbEFaxZJlPHMNIVNZvrXz.eIi5S0sAtunlYpiO2HkGDW3HjzgDvlm', '7aLcd0wQ', 'Etudiant', NULL, 0),
(108, '', 'ADupont24', 'Dupont', 'Alexandre', '2000-09-27', '$2a$11$YZpAq19lJMlydJtJm0I1/.d/JDvj2cDtzJTyD4Ir2cctBTl4eH8Q2', '5AxyODBg', 'Etudiant', NULL, 0),
(107, '', 'ADupont49', 'Dupont', 'Andréa', '2000-09-27', '$2a$11$3JfnFaINsdIl/WyntFkE6OH25nkaAao0DHMyYAD4MwsP.d5p.Zx.y', '2tCjyKBF', 'Etudiant', NULL, 0),
(105, '', 'RCook91', 'Cook', 'Rachel', '2000-09-14', '$2a$11$oKU86AGzj.CPYbP4Pj3ZkeqC2IPCzpw3Qm/llHg9vCwKLhIBb4nOq', '6XJ7DSUH', 'Etudiant', NULL, 0),
(106, '', 'MRenault63', 'Renault', 'Megane', '2000-04-14', '$2a$11$tQpuRzNDY9ViKHPVtlb1beDlap0LaRWQbwxnWkg3ooyc0BNz2yAjK', '81AvD3ER', 'Etudiant', NULL, 0),
(104, '', 'RSanchez73', 'Sanchez', 'Roberto', '2022-04-14', '$2a$11$BjMRtg/DMwjFHM4xO62aMu0wV2sgw0dWqTtkaZdWHAJN5r30qXhcS', 'QSImNBx5', 'Etudiant', NULL, 0),
(103, '', 'RPoitiers02', 'Poitiers', 'Roger', '2022-04-14', '$2a$11$h1HFQQfZDsonU/q.yT.7MuSDh4CZJqhm0lDgmJm2YxUfLtNy1GgSG', 'D863goEa', 'Etudiant', NULL, 0),
(102, '', 'LGeorges42', 'Georges', 'Lucas', '2000-02-14', '$2a$11$whR2JUQmjQ07LwqwcGZc8OM.OYykRPGOKK5D7CqmYAebzkbH.gg5.', '3pfoSWrN', 'Etudiant', NULL, 0),
(101, '', 'LHauchard02', 'Hauchard', 'Lucas', '2022-04-14', '$2a$11$jIVcRXQkQ4C5x9RlnRg57O0ffsMVOMe5M.xODqN4UEE1d/khD/5w2', 'vjYnOeiW', 'Etudiant', NULL, 0),
(100, '', 'SRochu48', 'Rochu', 'Samy', '2000-04-14', '$2a$11$FYU5XpZCtaqHNYi0Lal9n.agxAEzmZpLcNXZ5fSGOaaOE/Y6FQP0q', 'ClBHTAbf', 'Etudiant', NULL, 0),
(99, '', 'LCanyon48', 'Canyon', 'Luc', '1995-03-01', '$2a$11$8MidpCaV9D45LmnTaqY0EuKWIqkHKlwU6GCCeDAjBk73gArrt5BKq', '1Sht23CD', 'Etudiant', NULL, 0),
(98, '', 'HMichel23', 'Michel', 'Hugo', '1995-03-01', '$2a$11$ZsVLdhC6rAQQnJUcW016zOKZyTpqESXHfzBNERUrb1RLdxBjlJsFK', 'VHqzBLyk', 'Etudiant', NULL, 0),
(97, NULL, 'LHasley71', 'Hasley', 'Loris', '2000-07-27', '$2a$11$LwtWEY8L1RjTuMEvcsJv2.bj2zIvvMWke1h1VA7oITKamf4YKFVEq', 'LaN7vrDU', 'Etudiant', NULL, 0),
(96, NULL, 'EDaval25', 'Daval', 'Enzo', '2000-02-01', '$2a$11$kskdKpBfdfjVw17hV5K0wOGeuZEmEIo0TIlmAaH8RTdQCj7OfdjvC', 'aQ7uBoUf', 'Etudiant', NULL, 0),
(95, NULL, 'CMaille43', 'Maille', 'Corentin', '2000-06-07', '$2a$11$tIGq76OCqM12FKvG7YTCbuhBmeiPk6jyFyv/WmfmyS8nuOV760Dee', 'ocsmDAfk', 'Etudiant', NULL, 0),
(94, NULL, 'NBarbier96', 'Barbier', 'Nathan', '2000-11-23', '$2a$11$KboG3qRlvIXCA5i8yr4MMu103GHAZlpcz34Z6fdkpOwIakcJhk9FS', 'aPhdSfAe', 'Etudiant', NULL, 0),
(60, NULL, 'MLapuce02', 'Lapuce', 'Marie', '2022-03-01', '$2a$11$0ziPD60bQ2b5pq0uuVEr5OmirDVXqwuTcBz/foKWkfcj/UBtMqvWO', 'zZVu8eo3', 'Professeur', 'byKBdOXlemsh6Et1Qkug093GoT', 1),
(93, NULL, 'DChauveau34', 'Chauveau', 'Damien', '2000-09-09', '$2a$11$1HrYnwSznPnJ.R0op31HnuhGtbj5zOgilPi8WIrb7LQJAZTPkGRBe', 'hikHC9Om', 'Etudiant', NULL, 0),
(92, NULL, 'RChaumont40', 'Chaumont', 'Romain', '2000-05-11', '$2a$11$IxfSPGhpJ2vJibHacw2d0ua2FDgVeFmrNk.4wYULJ51nIGQdCj2m2', 'rCo4PiVp', 'Etudiant', NULL, 0),
(91, NULL, 'BLeraut69', 'Leraut', 'Bastien', '2000-05-25', '$2a$11$hMJZSM7jepMT7rlJgoPgFu/jDUES2vdbPid.dBqH6r8d8kf15vV0u', 'qGJTBvh4', 'Etudiant', NULL, 0),
(90, NULL, 'CJulia30', 'Julia', 'Clément', '2000-11-17', '$2a$11$f5kefWLKI3WToRq5dFUPie1W.SR5WPcFCgtabuyem0rfPz1qVauIO', 'oJPRmLUx', 'Etudiant', NULL, 0),
(89, NULL, 'TCavaille-Coll95', 'Cavaille-Coll', 'Théodore', '2000-06-08', '$2a$11$28lonEnguXMXlAV9jSm8t.ZLuqY8ZsUoxJMYwfvUAVr6wFI52cxvG', 'yEaAOSfV', 'Etudiant', NULL, 0),
(88, NULL, 'RTisba60', 'Tisba', 'Raphaël', '1991-06-18', '$2a$11$Vn5W4mr9pkMbi6JaCS/Mw.YX1EsUZg/7uJHiKvn8GJlzooCqEMeZO', 'X1xngIie', 'Etudiant', NULL, 0),
(87, NULL, 'RTreflest58', 'Treflest', 'Remy', '1991-06-18', '$2a$11$UIKYP7Vz6zAEIW5HYzHJEeKg4I4KaGpD/Id3ZKF13KMQLfvTEI4MO', 'PegXN8Jp', 'Etudiant', NULL, 0),
(86, NULL, 'TLegalle65', 'Legalle', 'Thierry', '1974-02-01', '$2a$11$1dR8lADTp14AcAh8YozGJuHfTgq3Ulc7kWEeTGhllwBQeVGwAkaPa', '8eM29i0d', 'Professeur', NULL, 0),
(85, NULL, 'TLegalle89', 'Legalle', 'Thierry', '1974-02-01', '$2a$11$da70AOaVl/cdpim4MF.OYOZQD3OkBUyBU6BSRAgoWiooI6HhRUapG', 'wjb5QTnX', 'Professeur', NULL, 0),
(84, NULL, 'JJackson89', 'Jackson', 'John', '1973-06-06', '$2a$11$nU8IfmH9wBLHJuobQ5Dss.5h/llglhcmTJZhthqzgwgD1AW5sq5.O', '0eg6syEL', 'Professeur', NULL, 0),
(83, NULL, 'AFranck64', 'Franck', 'Anne', '1986-06-26', '$2a$11$7t5CKaEs89WkqJ4OvjNjkOc7IAa7a6BISaAQXRxt5.SR2/wTKCHQu', 'zEvWLhIJ', 'Professeur', NULL, 0),
(76, NULL, 'DCarneiro01', 'Carneiro', 'David', '2000-02-23', '$2y$10$M2KEwIP8e5o7vCTOKsFRJOasKLd/PcgTh5yVjVlprX9Qkh/vQgm02', 'ROfePk3B', 'Etudiant', NULL, 1),
(82, NULL, 'GLaplace13', 'Laplace', 'Géraldine', '1985-09-29', '$2a$11$AxX4MTxs3NNOF1GzF5JnVu26jhyAN2Ngs9mNcMFFB2n3qDrpVpa56', '9yqThQ0P', 'Professeur', NULL, 0),
(80, NULL, 'JPestel94', 'Pestel', 'Jean', '1974-09-29', '$2a$11$Sg2y3I2gUD2sNd9zTL.an.HAd8vwrNT6xsCZuJpMPzfxOJ1ukUlH.', 'k5QDyTIR', 'Professeur', NULL, 0),
(81, NULL, 'EDurand26', 'Durand', 'Emile', '1985-09-29', '$2a$11$Qc0h.JDfsFYUliOFj4iUSOCE4kyCFa7ny80xtNYv3Cj9Klleg0Rme', '1jw6FaXV', 'Professeur', NULL, 0);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `absence`
--
ALTER TABLE `absence`
  ADD PRIMARY KEY (`idAbsence`);

--
-- Index pour la table `conversations`
--
ALTER TABLE `conversations`
  ADD PRIMARY KEY (`idConversation`);

--
-- Index pour la table `devoirs`
--
ALTER TABLE `devoirs`
  ADD PRIMARY KEY (`idDevoir`);

--
-- Index pour la table `edt`
--
ALTER TABLE `edt`
  ADD PRIMARY KEY (`idCours`);

--
-- Index pour la table `eleve`
--
ALTER TABLE `eleve`
  ADD UNIQUE KEY `idUtilisateur` (`idUtilisateur`);

--
-- Index pour la table `enseignants`
--
ALTER TABLE `enseignants`
  ADD PRIMARY KEY (`idEnseignant`);

--
-- Index pour la table `etudes`
--
ALTER TABLE `etudes`
  ADD PRIMARY KEY (`idEtude`);

--
-- Index pour la table `examen`
--
ALTER TABLE `examen`
  ADD PRIMARY KEY (`idExamen`);

--
-- Index pour la table `filiere`
--
ALTER TABLE `filiere`
  ADD PRIMARY KEY (`IDfiliere`);

--
-- Index pour la table `ipadmin`
--
ALTER TABLE `ipadmin`
  ADD PRIMARY KEY (`idIpAllowed`);

--
-- Index pour la table `ipbanned`
--
ALTER TABLE `ipbanned`
  ADD PRIMARY KEY (`idBanIp`);

--
-- Index pour la table `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`idLog`);

--
-- Index pour la table `matieres`
--
ALTER TABLE `matieres`
  ADD PRIMARY KEY (`idMatiere`);

--
-- Index pour la table `messages`
--
ALTER TABLE `messages`
  ADD PRIMARY KEY (`idMessage`);

--
-- Index pour la table `notes`
--
ALTER TABLE `notes`
  ADD PRIMARY KEY (`idNote`);

--
-- Index pour la table `punition`
--
ALTER TABLE `punition`
  ADD PRIMARY KEY (`idPunition`);

--
-- Index pour la table `retards`
--
ALTER TABLE `retards`
  ADD PRIMARY KEY (`idRetard`);

--
-- Index pour la table `salle`
--
ALTER TABLE `salle`
  ADD PRIMARY KEY (`idSalle`);

--
-- Index pour la table `statuts`
--
ALTER TABLE `statuts`
  ADD PRIMARY KEY (`idStatut`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`idUtilisateur`),
  ADD UNIQUE KEY `token` (`token`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `absence`
--
ALTER TABLE `absence`
  MODIFY `idAbsence` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `conversations`
--
ALTER TABLE `conversations`
  MODIFY `idConversation` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `devoirs`
--
ALTER TABLE `devoirs`
  MODIFY `idDevoir` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `edt`
--
ALTER TABLE `edt`
  MODIFY `idCours` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `enseignants`
--
ALTER TABLE `enseignants`
  MODIFY `idEnseignant` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT pour la table `etudes`
--
ALTER TABLE `etudes`
  MODIFY `idEtude` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT pour la table `examen`
--
ALTER TABLE `examen`
  MODIFY `idExamen` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `filiere`
--
ALTER TABLE `filiere`
  MODIFY `IDfiliere` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `ipadmin`
--
ALTER TABLE `ipadmin`
  MODIFY `idIpAllowed` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `ipbanned`
--
ALTER TABLE `ipbanned`
  MODIFY `idBanIp` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `logs`
--
ALTER TABLE `logs`
  MODIFY `idLog` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT pour la table `matieres`
--
ALTER TABLE `matieres`
  MODIFY `idMatiere` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT pour la table `messages`
--
ALTER TABLE `messages`
  MODIFY `idMessage` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `notes`
--
ALTER TABLE `notes`
  MODIFY `idNote` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT pour la table `punition`
--
ALTER TABLE `punition`
  MODIFY `idPunition` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `retards`
--
ALTER TABLE `retards`
  MODIFY `idRetard` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `salle`
--
ALTER TABLE `salle`
  MODIFY `idSalle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT pour la table `statuts`
--
ALTER TABLE `statuts`
  MODIFY `idStatut` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `idUtilisateur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=119;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
