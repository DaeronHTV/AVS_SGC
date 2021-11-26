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
	ID uuid not null,
	EMPLOIID uuid not null,
	SERVICEID uuid not null,
	DATEDEBUT timestamp default current_timestamp,
	DATEFIN timestamp null,
	constraint PK_EMPLOISERVICE primary key (ID),
	constraint FK_EMPLOI_EMPLOISERVICE foreign key (EMPLOIID) references EMPLOI(ID),
	constraint FK_SERVICE_EMPLOISERVICE foreign key (SERVICEID) references SERVICE(ID)
);

create table public.EMPLOYEEMPLOI(
	ID uuid not null,
	EMPLOYEID uuid not null,
	EMPLOIID uuid not null,
	DATEDEBUT timestamp default current_timestamp,
	DATEFIN timestamp null,
	constraint PK_EMPLOYEEMPLOI primary key (ID),
	constraint FK_EMPLOYE_EMPLOYEEMPLOI foreign key (EMPLOYEID) references EMPLOYE(ID),
	constraint FK_EMPLOI_EMPLOYEEMPLOI foreign key (EMPLOIID) references EMPLOI(ID)
);

create table public.EMPLOYECOMPETENCE(
	ID uuid not null,
	COMPETENCEID uuid not null,
	EMPLOYEID uuid not null,
	NIVEAU int default 0,
	DATEACQUISITION timestamp null,
	constraint PK_EMPLOYECOMPETENCE primary key (ID),
	constraint FK_COMPETENCE_EMPLOYECOMPETENCE foreign key (COMPETENCEID) references COMPETENCE(ID),
	constraint FK_EMPLOYE_EMPLOYECOMPETENCE foreign key (EMPLOYEID) references EMPLOYE(ID),
	constraint C3_NIVEAU check (NIVEAU between 0 and 5)
);

create table public.EMPLOICOMPETENCE(
	ID uuid not null,
	COMPETENCEID uuid not null,
	EMPLOIID uuid not null,
	DATEDEBUT timestamp default current_timestamp,
	DATEFIN timestamp null,
	constraint PK_EMPLOICOMPETENCE primary key (ID),
	constraint FK_EMPLOI_EMPLOICOMPETENCE foreign key (EMPLOIID) references EMPLOI(ID),
	constraint FK_COMPETENCE_EMPLOICOMPETENCE foreign key (COMPETENCEID) references COMPETENCE(ID)
);

create table public.EMPLOYECONNAISSANCE(
	ID uuid not null,
	CONNAISSANCEID uuid not null,
	EMPLOYEID uuid not null,
	NIVEAU int default 0,
	DATEACQUISITION timestamp null,
	constraint PK_EMPLOYECONNAISSANCE primary key (ID),
	constraint FK_CONNAISSANCE_EMPLOYECONNAISSANCE foreign key (CONNAISSANCEID) references CONNAISSANCE(ID),
	constraint FK_EMPLOYE_EMPLOYECONNAISSANCE foreign key (EMPLOYEID) references EMPLOYE(ID),
	constraint C3_NIVEAU_EMPLOYECONNAISSANCE check (NIVEAU between 0 and 5)
);

create table public.EMPLOICONNAISSANCE(
	ID uuid not null,
	CONNAISSANCEID uuid not null,
	EMPLOIID uuid not null,
	DATEDEBUT timestamp default current_timestamp,
	DATEFIN timestamp null,
	constraint PK_EMPLOICONNAISSANCE primary key (ID),
	constraint FK_EMPLOI_EMPLOICONNAISSANCE foreign key (EMPLOIID) references EMPLOI(ID),
	constraint FK_CONNAISSANCE_EMPLOICONNAISSANCE foreign key (CONNAISSANCEID) references CONNAISSANCE(ID)
);

CREATE INDEX Employe_Trigramme ON EMPLOYE(CODE);
CREATE INDEX Employe_Emploi_Date ON EMPLOYEEMPLOI(DATEDEBUT, DATEFIN);
CREATE INDEX Employe_Competence_Niveau ON EMPLOYECOMPETENCE(NIVEAU);
CREATE INDEX Emploi_Service_Date ON EMPLOISERVICE(DATEDEBUT, DATEFIN);