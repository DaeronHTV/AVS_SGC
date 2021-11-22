drop table public.EMPLOYE;

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