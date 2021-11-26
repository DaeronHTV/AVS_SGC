DROP TABLE "EMPLOYESERVICE";
DROP TABLE "EMPLOYECOMPTENCE";
DROP TABLE "EMPLOYEEMPLOI";
DROP TABLE "EMPLOICOMPETENCE";
DROP TABLE "EMPLOI";
DROP TABLE "SERVICE";
DROP TABLE "COMPTE";
DROP TABLE "COMPETENCE"
DROP TABLE "EMPLOYE";

/*CREATION DES TABLES PRIMAIRES*/
CREATE TABLE "EMPLOYE" 
(
    "EMPLOYEID"                     RAW(16) NOT NULL,
    "CODE"                          VARCHAR2(3) NOT NULL,
    "PRENOM"                        VARCHAR2(50) NULL,
    "NOM"                           VARCHAR2(50) NULL,
    "TELEPHONE"                     NUMBER(10) NULL,
    "MAIL"                          VARCHAR2(50) NOT NULL,
    "POSTELIBELLE"                  VARCHAR2(100) NULL,
    "DATEARRIVEE"                   DATE DEFAULT CURRENT_TIMESTAMP,
    "DATENAISSANCE"                 DATE NULL,
    "ADRESSE"                       VARCHAR2(100) NULL,
    CONSTRAINT PK_ETABLISSEMENT PRIMARY KEY("EMPLOYEID"),
    CONSTRAINT UK_MAIL_EMPLOYE UNIQUE ("MAIL"),
    CONSTRAINT UK_CODE_EMPLOYE UNIQUE ("CODE")
);

CREATE TABLE "COMPETENCE"
(
    "COMPETENCEID"      RAW(16) NOT NULL,
    "CODE"              VARCHAR2(10) NOT NULL,
    "LIBELLE"           VARCHAR2(100) NOT NULL,
    "DESCRIPTION"       VARCHAR2(500) NULL,
    "TYPECOMPETENCE"    VARCHAR2(30) DEFAULT "TECHNIQUE",
    CONSTRAINT PK_PERSONNE PRIMARY KEY("COMPETENCEID"),
    CONSTRAINT UK_CODE_COMPETENCE UNIQUE ("CODE"),
    CONSTRAINT C1_TYPECOMPTE CHECK (TYPECOMPETENCE IN ('TECHNIQUE', 'HUMAINE', 'INTERNE'))
);

CREATE TABLE "EMPLOI"(
    "EMPLOIID"      RAW(16) NOT NULL,
    "CODE"          VARCHAR2(10) NOT NULL,
    "LIBELLE"       VARCHAR2(100) NOT NULL,
    "DESCRIPTION"   VARCHAR2(500) NULL,
    CONSTRAINT PK_UTILISATEUR PRIMARY KEY ("EMPLOIID"),
    CONSTRAINT UK_CODE_EMPLOI UNIQUE ("CODE")
);

CREATE TABLE "COMPTE"(
    "COMPTEID"          RAW(16) NOT NULL,
    "EMPLOYEID"         RAW(16) NOT NULL,
    "SERVICEID"         RAW(16) NOT NULL,
    "PASSWORD"          VARCHAR2(50) NOT NULL,
    "DATECREATION"      TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    "DATEMAJ"           TIMESTAMP NULL,
    "TYPECOMPTE"        VARCHAR2(30) DEFAULT "MEMBRE",
    CONSTRAINT PK_INVITE PRIMARY KEY ("COMPTEID"),
    CONSTRAINT FK_EMPLOYE_COMPTE FOREIGN KEY ("EMPLOYEID") REFERENCES "EMPLOYE"("EMPLOYEID"),
    CONSTRAINT FK_SERVICE_COMPTE FOREIGN KEY ("SERVICEID") REFERENCES "SERVICE"("SERVICEID"),
    CONSTRAINT C1_TYPECOMPTE CHECK (TYPECOMPTE IN ('MEMBRE', 'ADMINISTRATEUR', 'MANAGER'))
);

CREATE TABLE "SERVICE"
(
    "SERVICEID"     RAW(16) NOT NULL,
    "CODE"          VARCHAR2(10) NOT NULL,
    "LIBELLE"       VARCHAR2(50) NOT NULL,
    "DATECREATION"  DATE DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT PK_PERSONNEL PRIMARY KEY ("SERVICEID"),
    CONSTRAINT UK_CODE_SERVICE UNIQUE ("CODE")
);

/*CREATION DES TABLES RELATIONNELLES*/
CREATE TABLE "EMPLOYESERVICE"
(
    "EMPLOYEID"     RAW(16) NOT NULL,
    "SERVICEID"     RAW(16) NOT NULL,
    "DATEDEBUT"     DATE DEFAULT CURRENT_TIMESTAMP,
    "DATEFIN"       DATE NULL,
    CONSTRAINT FK_EMPLOYE_EMPLOYESERVICE FOREIGN KEY ("EMPLOYEID") REFERENCES "EMPLOYE"("EMPLOYEID"),
    CONSTRAINT FK_SERVICE_EMPLOYESERVICE FOREIGN KEY ("SERVICEID") REFERENCES "SERVICE"("SERVICEID")
);

CREATE TABLE "EMPLOYEEMPLOI"
(
    "EMPLOYEID"     RAW(16) NOT NULL,
    "EMPLOIID"      RAW(16) NOT NULL,
    "DATEDEBUT"     DATE DEFAULT CURRENT_TIMESTAMP,
    "DATEFIN"       DATE NULL,
    CONSTRAINT FK_EMPLOYE_EMPLOYEEMPLOI FOREIGN KEY ("EMPLOYEID") REFERENCES "EMPLOYE"("EMPLOYEID"),
    CONSTRAINT FK_EMPLOI_EMPLOYEEMPLOI FOREIGN KEY ("EMPLOIID") REFERENCES "EMPLOI"("EMPLOIID")
);

CREATE TABLE "EMPLOYECOMPETENCE"
(
    "COMPETENCEID"      RAW(16) NOT NULL,
    "EMPLOYEID"         RAW(16) NOT NULL,
    "NIVEAU"            NUMBER(1) DEFAULT 0,
    "DATEACQUISITION"   DATE NULL,
    CONSTRAINT FK_COMPETENCE_EMPLOYECOMPETENCE FOREIGN KEY ("COMPETENCEID") REFERENCES "COMPETENCE"("COMPETENCEID"),
    CONSTRAINT FK_EMPLOYE_EMPLOYECOMPETENCE FOREIGN KEY ("EMPLOYEID") REFERENCES "EMPLOYE"("EMPLOYEID")
);

CREATE TABLE "EMPLOICOMPETENCE"
(
    "COMPETENCEID"      RAW(16) NOT NULL,
    "EMPLOIID"          RAW(16) NOT NULL,
    "DATEDEBUT"         DATE DEFAULT CURRENT_TIMESTAMP,
    "DATEFIN"           DATE NULL,
    CONSTRAINT FK_EMPLOI_EMPLOICOMPETENCE FOREIGN KEY ("EMPLOIID") REFERENCES "EMPLOI"("EMPLOIID"),
    CONSTRAINT FK_COMPETENCE_EMPLOICOMPETENCE FOREIGN KEY ("COMPETENCEID") REFERENCES "COMPETENCE"("COMPETENCEID")
);

/*REQUETE DE CREATION D'INDEX*/
CREATE INDEX Employe_Trigramme ON "EMPLOYE"("CODE");
CREATE INDEX Employe_Emploi_Date ON "EMPLOYEEMPLOI"("DATEDEBUT", "DATEFIN");
CREATE INDEX Employe_Competence_Niveau ON "EMPLOYECOMPETENCE"("NIVEAU");
CREATE INDEX Employe_Service_Date ON "EMPLOYESERVICE"("DATEDEBUT", "DATEFIN");