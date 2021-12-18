drop table public.EMPLOYE;

--Version 1.0
create table public.EMPLOYE (
	ID uuid not null,
	CODE varchar(3) not null,
	PRENOM varchar(50) null,
	NOM varchar(50) null,
	PRENOMASCII varchar(50) null,
	NOMASCII varchar(50) null,
	PHOTO bytea null,
	TELEPHONE int null,
	MAIL varchar(50) not null,
	DATEINSERTION timestamp default current_timestamp,
	DATEMAJ timestamp null,
	constraint PK_EMPLOYE primary key (ID),
	constraint UK_MAIL_EMPLOYE unique (MAIL),
	constraint UK_CODE_EMPLOYE unique (CODE)
);

create table public.COMPETENCE(
	ID uuid not null,
	CODE varchar(10) not null,
	LIBELLE varchar(100) not null,
	DESCRIPTION varchar(500) null,
	DATEINSERTION timestamp default current_timestamp,
	DATEMAJ timestamp null,
	constraint PK_COMPETENCE primary key (ID),
	constraint UK_CODE_COMPETENCE unique (CODE)
);

create table public.EMPLOI(
	ID uuid not null,
	CODE varchar(10) not null,
	LIBELLE varchar(100) not null,
	DESCRIPTION varchar(500) null,
	DATEINSERTION timestamp default current_timestamp,
	DATEMAJ timestamp null,
	constraint PK_EMPLOI primary key (ID),
	constraint UK_CODE_EMPLOI unique (CODE)
);

create table public.COMPTE(
	ID uuid not null,
	EMPLOYEID uuid not null,
	MAIL varchar(50) not null,
	PASSWORD varchar(50) not null,
	TYPECOMPTE varchar(30) default 'MEMBRE',
	DATEINSERTION timestamp default current_timestamp,
	DATEMAJ timestamp null,
	constraint PK_COMPTE primary key (ID),
	constraint FK_EMPLOYE_COMPTE foreign key (EMPLOYEID) references EMPLOYE(ID),
	constraint C1_TYPECOMPTE check (TYPECOMPTE in ('MEMBRE', 'ADMINISTRATEUR', 'MANAGER'))
);

create table public.SERVICE(
	ID uuid not null,
	CODE varchar(10) not null,
	LIBELLE varchar(50) not null,
	DATEINSERTION timestamp default current_timestamp,
	DATEMAJ timestamp null,
	constraint PK_PERSONNEL primary key (ID),
	constraint UK_CODE_SERVICE unique (CODE)
);

create table public.CONNAISSANCE(
	ID uuid not null,
	CODE varchar(10) not null,
	LIBELLE varchar(100) not null,
	DESCRIPTION varchar(500) not null,
	DATEINSERTION timestamp default current_timestamp,
	DATEMAJ timestamp null,
	constraint PK_CONNAISSANCE primary key (ID),
	constraint UK_CODE_CONNAISSANCE unique (CODE)
);

create table public.EMPLOISERVICE(
	EMPLOIID uuid not null,
	SERVICEID uuid not null,
	DATEDEBUT timestamp default current_timestamp,
	DATEFIN timestamp null,
	constraint FK_EMPLOI_EMPLOISERVICE foreign key (EMPLOIID) references EMPLOI(ID),
	constraint FK_SERVICE_EMPLOISERVICE foreign key (SERVICEID) references SERVICE(ID)
);

create table public.EMPLOYEEMPLOI(
	EMPLOYEID uuid not null,
	EMPLOIID uuid not null,
	DATEDEBUT timestamp default current_timestamp,
	DATEFIN timestamp null,
	constraint FK_EMPLOYE_EMPLOYEEMPLOI foreign key (EMPLOYEID) references EMPLOYE(ID),
	constraint FK_EMPLOI_EMPLOYEEMPLOI foreign key (EMPLOIID) references EMPLOI(ID)
);

create table public.EMPLOYECOMPETENCE(
	COMPETENCEID uuid not null,
	EMPLOYEID uuid not null,
	NIVEAU int default 0,
	DATEACQUISITION timestamp null,
	constraint FK_COMPETENCE_EMPLOYECOMPETENCE foreign key (COMPETENCEID) references COMPETENCE(ID),
	constraint FK_EMPLOYE_EMPLOYECOMPETENCE foreign key (EMPLOYEID) references EMPLOYE(ID),
	constraint C3_NIVEAU check (NIVEAU between 0 and 5)
);

create table public.EMPLOICOMPETENCE(
	COMPETENCEID uuid not null,
	EMPLOIID uuid not null,
	DATEDEBUT timestamp default current_timestamp,
	DATEFIN timestamp null,
	constraint FK_EMPLOI_EMPLOICOMPETENCE foreign key (EMPLOIID) references EMPLOI(ID),
	constraint FK_COMPETENCE_EMPLOICOMPETENCE foreign key (COMPETENCEID) references COMPETENCE(ID)
);

create table public.EMPLOYECONNAISSANCE(
	CONNAISSANCEID uuid not null,
	EMPLOYEID uuid not null,
	NIVEAU int default 0,
	DATEACQUISITION timestamp null,
	constraint FK_CONNAISSANCE_EMPLOYECONNAISSANCE foreign key (CONNAISSANCEID) references CONNAISSANCE(ID),
	constraint FK_EMPLOYE_EMPLOYECONNAISSANCE foreign key (EMPLOYEID) references EMPLOYE(ID),
	constraint C3_NIVEAU_EMPLOYECONNAISSANCE check (NIVEAU between 0 and 5)
);

create table public.EMPLOICONNAISSANCE(
	CONNAISSANCEID uuid not null,
	EMPLOIID uuid not null,
	DATEDEBUT timestamp default current_timestamp,
	DATEFIN timestamp null,
	constraint FK_EMPLOI_EMPLOICONNAISSANCE foreign key (EMPLOIID) references EMPLOI(ID),
	constraint FK_CONNAISSANCE_EMPLOICONNAISSANCE foreign key (CONNAISSANCEID) references CONNAISSANCE(ID)
);

CREATE INDEX Employe_Trigramme ON EMPLOYE(CODE);
CREATE INDEX Employe_Emploi_Date ON EMPLOYEEMPLOI(DATEDEBUT, DATEFIN);
CREATE INDEX Employe_Competence_Niveau ON EMPLOYECOMPETENCE(NIVEAU);
CREATE INDEX Emploi_Service_Date ON EMPLOISERVICE(DATEDEBUT, DATEFIN);

/*Version 2.0*/
alter table public.EMPLOYE 
alter column MAIL type varchar(100);

--Ajout des champs DATEDEBUTVALIDITE et DATEFINVALIDITE
alter table public.employe add column DATEDEBUTVALDITE timestamp default current_timestamp;
alter table public.employe add column DATEFINVALIDITE timestamp default '3000-12-31';
alter table public.compte add column DATEDEBUTVALDITE timestamp default current_timestamp;
alter table public.compte add column DATEFINVALIDITE timestamp default '3000-12-31';
alter table public.service add column DATEDEBUTVALDITE timestamp default current_timestamp;
alter table public.service add column DATEFINVALIDITE timestamp default '3000-12-31';
alter table public.emploi add column DATEDEBUTVALDITE timestamp default current_timestamp;
alter table public.emploi add column DATEFINVALIDITE timestamp default '3000-12-31';

--Modification de la table employe competence
alter table public.employecompetence drop constraint C3_NIVEAU;
alter table public.employecompetence drop column NIVEAU;
alter table public.employecompetence add column NIVEAU varchar(30) default 'NONE';
alter table public.employecompetence add constraint C4_CHECK_NIVEAU 
check (NIVEAU in ('NONE', 'INITIE', 'DEBUTANT', 'INTERMEDIAIRE', 'CONFIRME', 'EXPERT'));

--Modification de la table employe connaissance
alter table public.employeconnaissance drop constraint C3_NIVEAU_EMPLOYECONNAISSANCE;
alter table public.employeconnaissance drop column NIVEAU;
alter table public.employeconnaissance add column NIVEAU varchar(30) default 'NONE';
alter table public.employeconnaissance add constraint C4_CHECK_NIVEAU 
check (NIVEAU in ('NONE', 'INITIE', 'DEBUTANT', 'INTERMEDIAIRE', 'CONFIRME', 'EXPERT'));

--Creation des nouvelles tables principales
create table public.AUTEUR(
	ID uuid not null,
	EMPLOYEID uuid null,
	CODE varchar(3) not null,
	PRENOM varchar(50) null,
	NOM varchar(50) null,
	PRENOMASCII varchar(50) null,
	NOMASCII varchar(50) null,
	MAIL varchar(100) not null,
	DATEINSERTION timestamp default current_timestamp,
	DATEMAJ timestamp null,
	DATEDEBUTVALIDITE timestamp default current_timestamp,
	DATEFINVALIDITE timestamp default '3000-12-31',
	constraint PK_AUTEUR primary key (ID),
	constraint UK_CODE_AUTEUR unique (CODE),
	constraint UK_MAIL_AUTEUR unique (MAIL)
);

create table public.FORMATION(
	ID uuid not null,
	CODE varchar(20) not null,
	LIBELLE varchar(100) not null,
	DESCRIPTION varchar(500) null,
	TAGS varchar(1000) null,
	NIVEAU varchar(30) not null default 'INITIE',
	constraint PK_FORMATION primary key (ID),
	constraint UK_CODE_FORMATION unique (CODE),
	constraint C5_NIVEAU_FORMATION check (NIVEAU in ('NONE', 'INITIE', 'DEBUTANT', 'INTERMEDIAIRE', 'CONFIRME', 'EXPERT'))
);

create table public.CONTENUE(
	ID uuid not null,
	
	constraint PK_CONTENUE primary key (ID)
);

--Creation des nouvelles tables relationnelles
create table public.FORMATIONCONTENUE(
	
);

create table public.FORMATIONEMPLOYE(

);

CREATE TABLE public.PARAMETRES(
	ID uuid NOT NULL,
	CODE varchar(20) NOT NULL,
	LIBELLE varchar(100) NOT NULL,
	VALEUR varchar(50) NOT NULL,
	CONSTRAINT PK_PARAMETRES PRIMARY KEY (ID),
	CONSTRAINT UK_CODE_PARAMETRES UNIQUE (CODE)
);

--Creation des INDEX
--INDEX POUR RECHERCHER UNE FORMATION AVEC LE TUPLE (TAG,NIVEAU)
--INDEX POUR RECHERCHER


