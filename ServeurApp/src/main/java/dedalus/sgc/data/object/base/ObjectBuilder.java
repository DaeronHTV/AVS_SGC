package dedalus.sgc.data.object.base;

import java.sql.Date;

import dedalus.sgc.data.enumeration.TypeCompte;

public class ObjectBuilder {
	public static Service createService(String code) { return new Service(code); }
	
	public static Service createService(String code, String libelle) { return new Service(code, libelle); }
	
	public static Employe createEmploye(String code, String prenom, String mail) { return new Employe(code, prenom, mail); }
	
	public static Employe createEmploye(String code, String prenom, String nom, String telephone, String mail) {
		return new Employe(code, prenom, nom, telephone, mail);
	}
	
	public static Emploi createEmploi(String code) { return new Emploi(code); }
	
	public static Emploi createEmploi(String code, String libelle) { return new Emploi(code, libelle); }
	
	public static Emploi createEmploi(String code, String libelle, String description) {
		return new Emploi(code, libelle, description);
	}
	
	public static Compte createBaseAccount(String employeId, String mail, TypeCompte typeCompte) {
		return new Compte(employeId, mail, typeCompte);
	}
	
	public static Compte createAccount(String id, String employeId, String mail, String password, TypeCompte typeCompte, Date dateInsertion, Date dateMaj) {
		return new Compte(id, employeId, mail, password, typeCompte, dateInsertion, dateMaj);
	}
	
	public static Competence createCompetence(String code) { return new Competence(code); }
	
	public static Competence createCompetence(String code, String libelle) { return new Competence(code, libelle); }
	
	public static Competence createCompetence(String code, String libelle, String description) {
		return new Competence(code, libelle, description);
	}
	
	public static Connaissance createConnaissance(String code) { return new Connaissance(code); }
	
	public static Connaissance createConnaissance(String code, String libelle) { return new Connaissance(code, libelle); }
	
	public static Connaissance createConnaissance(String code, String libelle, String description) {
		return new Connaissance(code, libelle, description);
	}
}
