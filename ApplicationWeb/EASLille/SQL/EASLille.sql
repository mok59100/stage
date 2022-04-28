DROP DATABASE IF EXISTS EASLille; 
CREATE DATABASE EASLille DEFAULT CHARACTER SET utf8;
USE EASLille;

CREATE TABLE Actualites(
   IdActualite INT AUTO_INCREMENT PRIMARY KEY,
   Titre VARCHAR(50),
   Contenu TEXT,
   DateAffichage DATE 

)ENGINE=InnoDB;

CREATE TABLE Videos(
   IdVideo INT AUTO_INCREMENT PRIMARY KEY,
   Description VARCHAR(100),
   Videos VARCHAR(100)
   
)ENGINE=InnoDB;

CREATE TABLE Images(
   IdImage INT AUTO_INCREMENT PRIMARY KEY,
   Description VARCHAR(100),
   Images VARCHAR(100)
   
)ENGINE=InnoDB;

CREATE TABLE Roles(
   IdRole INT AUTO_INCREMENT PRIMARY KEY,
   LibelleRole VARCHAR(50)
  
)ENGINE=InnoDB;

CREATE TABLE Dons(
   IdDon INT AUTO_INCREMENT PRIMARY KEY,
   Nom VARCHAR(50),
   Prenom VARCHAR(50),
   LibelleDon TEXT,
   MontantDon DECIMAL(15,2)
   
)ENGINE=InnoDB;

CREATE TABLE Utilisateurs(
   IdUtilisateur INT AUTO_INCREMENT PRIMARY KEY,
   Nom varchar(50) NOT NULL,
   Prenom varchar(50) NOT NULL,
   AdresseMail varchar(50) UNIQUE NOT NULL,
   MotDePasse varchar(50) NOT NULL,
   TelephoneUtilisateur INT NULL,
   SituationProfessionnelle VARCHAR(50) NULL,
   Active BOOLEAN,
   IdRole INT NOT NULL
  
)ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS textes (
idTexte int (11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
codeTexte varchar (50) NOT NULL,
fr LONGTEXT NOT NULL,
en LONGTEXT NOT NULL

)ENGINE = InnoDB DEFAULT CHARSET = utf8;


CREATE TABLE Adhesions(
   IdAdhesion INT AUTO_INCREMENT PRIMARY KEY,
   DateDebutAdhesion DATE,
   DateFinAdhesion DATE,
   IdUtilisateur INT NOT NULL
  
)ENGINE=InnoDB;

CREATE TABLE Cotisations(
   IdCotisation INT AUTO_INCREMENT PRIMARY KEY,
   EtatCotisation VARCHAR(50),
   MontantCotisation VARCHAR(50),
   ModePaiement VARCHAR(50),
   DateCotisation DATE,
   IdUtilisateur INT NOT NULL
   
)ENGINE=InnoDB;

CREATE TABLE Messages(
  IdMessage INT AUTO_INCREMENT PRIMARY KEY,
   Dates VARCHAR(10) NOT NULL,
   Heure VARCHAR(30) NOT NULL,
   Auteur VARCHAR(50) NOT NULL,
   Message VARCHAR(200) NOT NULL

  
)ENGINE=InnoDB;

CREATE TABLE Appartient(
   IdActualite INT AUTO_INCREMENT PRIMARY KEY,
   IdVideo INT  NOT NULL
     
)ENGINE=InnoDB;

CREATE TABLE Contient(
   IdActualite INT AUTO_INCREMENT PRIMARY KEY,
   IdImage INT NOT NULL
  
)ENGINE=InnoDB;




ALTER TABLE Utilisateurs
ADD CONSTRAINT FK_Utilisateurs_Roles  FOREIGN KEY(IdRole) REFERENCES Roles(IdRole);


ALTER TABLE Adhesions
ADD CONSTRAINT FK_Adhesions_Utilisateurs FOREIGN KEY(IdUtilisateur) REFERENCES Utilisateurs(IdUtilisateur);

ALTER TABLE Cotisations
ADD CONSTRAINT FK_Cotisations_Utilisateurs  FOREIGN KEY(IdUtilisateur) REFERENCES Utilisateurs(IdUtilisateur);


ALTER TABLE Appartient
ADD CONSTRAINT FK_Appartient_Actualites FOREIGN KEY(IdActualite) REFERENCES Actualites(IdActualite),
ADD CONSTRAINT FK_Appartient_Videos  FOREIGN KEY(IdVideo) REFERENCES Videos(IdVideo);

ALTER TABLE Contient
ADD CONSTRAINT FK_Contient_Actualites FOREIGN KEY(IdActualite) REFERENCES Actualites(IdActualite),
ADD CONSTRAINT FK_Contient_Images FOREIGN KEY(IdImage) REFERENCES Images(IdImage);