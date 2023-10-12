DROP DATABASE IF EXISTS creditceleste;

CREATE DATABASE creditceleste;

USE creditceleste;

CREATE TABLE CIVILITES (
codeCivilite CHAR(4) PRIMARY KEY,
libelle VARCHAR(20) NOT NULL
);

INSERT INTO CIVILITES (codeCivilite, libelle) VALUES
('M', 'M.'), ('MAD', 'Mme.'), ('MLLE', 'Mademoiselle');

CREATE TABLE ETATS (
codeEtat CHAR(5) PRIMARY KEY,
libelle VARCHAR(50) NOT NULL
);

INSERT INTO ETATS (codeEtat, libelle) VALUES
('NF', 'Neuf'), ('OCC3', 'Occasion - de 3 ans'), ('OCC35', 'Occasion de 3 à 5 ans'), ('OCC5', 'Occasion 5 ans ou plus');

CREATE TABLE BOITES (
codeBoite CHAR(4) PRIMARY KEY,
libelle VARCHAR(20) NOT NULL
);

INSERT INTO BOITES (codeBoite, libelle) VALUES
('AUTO', 'Automatique'), ('MANU', 'Manuelle');

CREATE TABLE TYPES (
codeType CHAR(4) PRIMARY KEY,
libelle VARCHAR(20) NOT NULL
);

INSERT INTO TYPES (codeType, libelle) VALUES
('ELEC', 'Electrique'), ('ES', 'Essence'), ('DI', 'Diesel'), ('HYB', 'Hybride');

CREATE TABLE TYPESPAIEMENT (
codeType CHAR(4) PRIMARY KEY,
libelle VARCHAR(20) NOT NULL
);

INSERT INTO TYPESPAIEMENT (codeType, libelle) VALUES
('CRED', 'Crédit'), ('CASH', 'Comptant');

CREATE TABLE ESSENCES (
codeEssence CHAR(4) PRIMARY KEY,
libelle VARCHAR(20) NOT NULL
);

INSERT INTO ESSENCES (codeEssence, libelle) VALUES
('SP', 'Super'), ('GAZ', 'Gazole'), ('E85', 'Ethanol');

CREATE TABLE UTILISATEUR (
id INT PRIMARY KEY AUTO_INCREMENT, -- changer AUTO_INCREMENT en IDENTITY pour SQL Server
codeCivilite CHAR(4) NOT NULL,
nom VARCHAR(50) NOT NULL,
prenom VARCHAR(50) NOT NULL,
FOREIGN KEY (codeCivilite) REFERENCES CIVILITES(codeCivilite)
);

CREATE TABLE VEHICULES (
id INT PRIMARY KEY AUTO_INCREMENT, -- changer AUTO_INCREMENT en IDENTITY pour SQL Server
modele VARCHAR(50) NOT NULL,
marque VARCHAR(50) NOT NULL,
plaqueImma VARCHAR(10) NOT NULL,
puissance INT NOT NULL,
codeBoite CHAR(4) NOT NULL,
codeType CHAR(4) NOT NULL,
codeEssence CHAR(4),
annee INT NOT NULL,
kilometrage INT NOT NULL,
couleur VARCHAR(20) NOT NULL,
codeEtat CHAR(5) NOT NULL,
prix DECIMAL(10,2) NOT NULL,
FOREIGN KEY (codeBoite) REFERENCES BOITES(codeBoite),
FOREIGN KEY (codeType) REFERENCES TYPES(codeType),
FOREIGN KEY (codeEssence) REFERENCES ESSENCES(codeEssence),
FOREIGN KEY (codeEtat) REFERENCES ETATS(codeEtat)
);

CREATE TABLE VENDEURS (
id INT PRIMARY KEY AUTO_INCREMENT, -- changer AUTO_INCREMENT en IDENTITY pour SQL Server
codeCivilite CHAR(4) NOT NULL,
nom VARCHAR(50) NOT NULL,
prenom VARCHAR(50) NOT NULL,
FOREIGN KEY (codeCivilite) REFERENCES CIVILITES(codeCivilite)
);

CREATE TABLE ACHATS (
id INT PRIMARY KEY AUTO_INCREMENT, -- changer AUTO_INCREMENT en IDENTITY pour SQL Server
typePaiement CHAr(4) NOT NULL,
idUtilisateur INT NOT NULL,
idVehicule INT NOT NULL,
dateAchat DATE NOT NULL,
montant DECIMAL(10, 2) NOT NULL,
plaqueImmaAncienVehicule VARCHAR(10) NOT NULL,
kilometrageAncienVehicule INT NOT NULL,
ageAncienVehicule CHAR(5) NOT NULL,
FOREIGN KEY (typePaiement) REFERENCES TYPESPAIEMENT(codeType),
FOREIGN KEY (idUtilisateur) REFERENCES UTILISATEUR(id),
FOREIGN KEY (idVehicule) REFERENCES VEHICULES(id),
FOREIGN KEY (ageAncienVehicule) REFERENCES ETATS(codeEtat)
);


INSERT INTO VEHICULES (modele, marque, plaqueImma, puissance, codeBoite, codeType, codeEssence, annee, kilometrage, couleur, codeEtat, prix)
VALUES
('Clio IV', 'Renault', 'AA-123-BB', 90, 'MANU', 'DI', 'GAZ', 2015, 80000, 'Bleu', 'OCC3', 9000),
('Golf VII', 'Volkswagen', 'CC-456-DD', 150, 'AUTO', 'DI', 'GAZ', 2017, 50000, 'Noir', 'OCC35', 18000),
('308', 'Peugeot', 'EE-789-FF', 130, 'MANU', 'DI', 'GAZ', 2018, 60000, 'Blanc', 'OCC35', 15000),
('Serie 1', 'BMW', 'GG-101-HH', 116, 'MANU', 'DI', 'GAZ', 2016, 70000, 'Noir', 'OCC35', 21000),
('C3', 'Citroen', 'II-345-JJ', 82, 'MANU', 'ES', 'SP', 2017, 40000, 'Rouge', 'OCC35', 10000),
('Megane III', 'Renault', 'KK-678-LL', 110, 'MANU', 'DI', 'GAZ', 2014, 90000, 'Noir', 'OCC5', 12000),
('208', 'Peugeot', 'MM-910-NN', 82, 'MANU', 'ES', 'SP', 2016, 50000, 'Gris', 'OCC35', 9500),
('Clio V', 'Renault', 'OO-111-PP', 90, 'AUTO', 'ELEC', NULL, 2019, 20000, 'Blanc', 'NF', 12000),
('Ibiza', 'Seat', 'QQ-121-RR', 95, 'MANU', 'ES', 'SP', 2018, 45000, 'Rouge', 'OCC35', 11000),
('A3', 'Audi', 'SS-131-TT', 150, 'AUTO', 'DI', 'GAZ', 2016, 70000, 'Noir', 'OCC35', 22000),
('C4 Picasso', 'Citroen', 'UU-141-VV', 120, 'MANU', 'DI', 'GAZ', 2015, 80000, 'Gris', 'OCC3', 14000),
('Golf VI', 'Volkswagen', 'XX-151-YY', 105, 'MANU', 'DI', 'GAZ', 2013, 100000, 'Noir', 'OCC5', 10000),
('Tiguan', 'Volkswagen', 'ZZ-161-AB', 150, 'AUTO', 'DI', 'GAZ', 2017, 55000, 'Blanc', 'OCC35', 20000),
('Clio III', 'Renault', 'AC-171-CD', 75, 'MANU', 'DI', 'GAZ', 2012, 120000, 'Rouge', 'OCC5', 8000);

INSERT INTO VENDEURS (codeCivilite, nom, prenom)
VALUES
('M', 'CIPOR', 'Alexandre');

INSERT INTO UTILISATEUR (codeCivilite, nom, prenom)
VALUES
('M', 'Bernardo', 'Julian');
