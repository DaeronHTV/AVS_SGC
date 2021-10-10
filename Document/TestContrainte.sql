/**INSERTION DES DONNEES DE TEST**/
INSERT INTO ETABLISSEMENT VALUES
(
    'A44C33115F24364F805513D4080527B0', 'Etablissement Test', '0011223344',
    'etablissement.test@test.com', '123 rue du test', 26000, 'VALENCE', 
    'FRANCE', 10, 3
);

INSERT INTO PERSONNE VALUES
(
    '297FEFCB4161C84F802C00B9AA5F2AD8','A44C33115F24364F805513D4080527B0',
    'COVERT', 'HARRY'
);

INSERT INTO PERSONNE VALUES
(
    'E1905D7FDE5A5F4E88FB89E2CAFF089A','A44C33115F24364F805513D4080527B0',
    'PAPIER', 'PIERRE'
);

INSERT INTO PERSONNE VALUES
(
    'A587B3685E752146A3854F166372B839', 'A44C33115F24364F805513D4080527B0',
    'PAPIER', 'PIERRE'
);

INSERT INTO PERSONNE VALUES
(
    'CB4C469ACD5AC84390DA5FC5754BE46D', 'A44C33115F24364F805513D4080527B0',
    'JACQUIE', 'MICHEL'
);

INSERT INTO UTILISATEUR VALUES
('297FEFCB4161C84F802C00B9AA5F2AD8', '0011223344', 'harry.covert@test.com');

INSERT INTO UTILISATEUR VALUES
('E1905D7FDE5A5F4E88FB89E2CAFF089A', '0011223344', 'harry.covert@test.com');

INSERT INTO CONTACT VALUES
('E1905D7FDE5A5F4E88FB89E2CAFF089A', 1);

INSERT INTO PERSONNEL VALUES
('297FEFCB4161C84F802C00B9AA5F2AD8', 'DOCTEUR');

INSERT INTO "UNITE" VALUES
('8E13B7A2F129894E9099FC87F925ECBA', 'A44C33115F24364F805513D4080527B0', 
'CHIRURGIE', 'FERMEE');

INSERT INTO RESIDENT VALUES
('E1905D7FDE5A5F4E88FB89E2CAFF089A', '8E13B7A2F129894E9099FC87F925ECBA',
'297FEFCB4161C84F802C00B9AA5F2AD8', CURRENT_TIMESTAMP, 'DISPONIBLE');

INSERT INTO CRENEAUVISIO VALUES
('D8FA863A50EC6846B0D88EA77F9C66AB','297FEFCB4161C84F802C00B9AA5F2AD8',
CURRENT_TIMESTAMP, 1, null, null);

/*******TEST SUR LES CONTRAINTES DE UNITE*******/
INSERT INTO "UNITE" VALUES --RESPECT DU PATTERN ETAT
('CF19FA563822774C87A1F1FF63020D88', 'A44C33115F24364F805513D4080527B0', 
'CHIRURGIE', 'FERMEE');

INSERT INTO "UNITE" VALUES --NON RESPECT DU PATTERN ETAT
('DF304D5855D4944E9D066786500868D1', 'A44C33115F24364F805513D4080527B0', 
'CHIRURGIE', 'BONJOUR');

/*******TEST SUR LES CONTRAINTES DE RESIDENT*******/
INSERT INTO RESIDENT VALUES --RESPECT DU PATTERN STATUT
('CB4C469ACD5AC84390DA5FC5754BE46D', 'CF19FA563822774C87A1F1FF63020D88',
'297FEFCB4161C84F802C00B9AA5F2AD8', CURRENT_TIMESTAMP, 'DISPONIBLE');

INSERT INTO RESIDENT VALUES --NON RESPECT DU PATTERN STATUT
('A587B3685E752146A3854F166372B839', 'CF19FA563822774C87A1F1FF63020D88',
'297FEFCB4161C84F802C00B9AA5F2AD8', CURRENT_TIMESTAMP, 'BONJOUR');

/*******TEST SUR LES CONTRAINTES DE CRENEAUVISIO*******/
INSERT INTO CRENEAUVISIO VALUES --RESPECT DU PATTERN DISPONIBLE
('25B4C0444649C74BAC00536E8FE238E2','297FEFCB4161C84F802C00B9AA5F2AD8',
CURRENT_TIMESTAMP, 0, null, null);

INSERT INTO CRENEAUVISIO VALUES --NON RESPECT DU PATTERN DISPONIBLE
('04740897B6E631479669DDB2AD80CEB2','297FEFCB4161C84F802C00B9AA5F2AD8',
CURRENT_TIMESTAMP, 9, null, null);

/*******TEST SUR LES CONTRAINTES DE TABLETTE*******/
INSERT INTO TABLETTE VALUES --RESPECT DU PATTERN ETATTABLETTE
('1723E87C4402A64297F055D35A29B4B9','ENCHARGEMENT');

INSERT INTO TABLETTE VALUES --NON RESPECT DU PATTERN ETATTABLETTE
('C2412999E12A304684A6310E865FD650','BONJOUR');

/*******TEST SUR LES CONTRAINTES DE RENDEZVOUS*******/
INSERT INTO RENDEZVOUS VALUES --RESPECT DES PATTERNS
(
    'D2751627DCA46140B667C0F0420D9001','CB4C469ACD5AC84390DA5FC5754BE46D',
    'D8FA863A50EC6846B0D88EA77F9C66AB', 'E1905D7FDE5A5F4E88FB89E2CAFF089A',
    '1723E87C4402A64297F055D35A29B4B9',
    CURRENT_TIMESTAMP, 30,'NORMAL', 'PROGRAMME', 0, null
);

INSERT INTO RENDEZVOUS VALUES --NON RESPECT DU PATTERN STATUTRDV
(
    '87D6D9EE239AF745A3CEE0C63879E617','CB4C469ACD5AC84390DA5FC5754BE46D',
    'D8FA863A50EC6846B0D88EA77F9C66AB', 'E1905D7FDE5A5F4E88FB89E2CAFF089A',
    '1723E87C4402A64297F055D35A29B4B9',
    CURRENT_TIMESTAMP, 30, 'BONJOUR', 'PROGRAMME', 0, null
);

INSERT INTO RENDEZVOUS VALUES --NON RESPECT DU PATTERN ETATRDV
(
    '2649C09FD313774BBF77A0BC3687A2E8','CB4C469ACD5AC84390DA5FC5754BE46D',
    'D8FA863A50EC6846B0D88EA77F9C66AB', 'NORMAL', 'BONJOUR'
);

/*******SUPPRESSION DES DONNEES DE TEST*******/
DELETE FROM RENDEZVOUS WHERE idrendezvous = 'D2751627DCA46140B667C0F0420D9001';
DELETE FROM CRENEAUVISIO WHERE IDCRENEAU = '25B4C0444649C74BAC00536E8FE238E2';
DELETE FROM RESIDENT WHERE IDRESIDENT = 'CB4C469ACD5AC84390DA5FC5754BE46D';
DELETE FROM "UNITE" WHERE IDUNITE = 'CF19FA563822774C87A1F1FF63020D88';
DELETE FROM "TABLETTE" WHERE IDTABLETTE  = '1723E87C4402A64297F055D35A29B4B9';

DELETE FROM CRENEAUVISIO WHERE IDCRENEAU = 'D8FA863A50EC6846B0D88EA77F9C66AB';
DELETE FROM RESIDENT WHERE IDRESIDENT = 'E1905D7FDE5A5F4E88FB89E2CAFF089A';
DELETE FROM "UNITE" WHERE IDUNITE = '8E13B7A2F129894E9099FC87F925ECBA';
DELETE FROM "CONTACT" WHERE IDCONTACT = 'E1905D7FDE5A5F4E88FB89E2CAFF089A';
DELETE FROM "PERSONNEL" WHERE IDPERSONNEL = '297FEFCB4161C84F802C00B9AA5F2AD8';
DELETE FROM "UTILISATEUR" WHERE IDUTILISATEUR = 'E1905D7FDE5A5F4E88FB89E2CAFF089A';
DELETE FROM "UTILISATEUR" WHERE IDUTILISATEUR = '297FEFCB4161C84F802C00B9AA5F2AD8';
DELETE FROM "PERSONNE" WHERE IDPERSONNE = 'CB4C469ACD5AC84390DA5FC5754BE46D';
DELETE FROM "PERSONNE" WHERE IDPERSONNE = 'A587B3685E752146A3854F166372B839';
DELETE FROM "PERSONNE" WHERE IDPERSONNE = 'E1905D7FDE5A5F4E88FB89E2CAFF089A';
DELETE FROM "PERSONNE" WHERE IDPERSONNE = '297FEFCB4161C84F802C00B9AA5F2AD8';
DELETE FROM "ETABLISSEMENT" WHERE IDETABLISSEMENT = 'A44C33115F24364F805513D4080527B0';