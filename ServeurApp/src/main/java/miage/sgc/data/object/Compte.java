package Miage.sgc.data.object;

import java.sql.Date;

import Miage.sgc.data.enumeration.TypeCompte;

public class Compte {
	private String compteId;
	private String employeId;
	private String serviceId;
	private String password;
	private Date dateCreation;
	private Date dateMaj;
	private TypeCompte typeCompte;
}
