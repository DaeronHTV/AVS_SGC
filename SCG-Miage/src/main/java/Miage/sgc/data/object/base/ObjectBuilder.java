package Miage.sgc.data.object.base;

import Miage.sgc.data.enumeration.TypeCompte;

public class ObjectBuilder {
	/***********************TERMINE****************************/
	public static Compte createBaseAccount(String employeId, String mail, TypeCompte typeCompte) {
		return new Compte(employeId, mail, typeCompte);
	}
	
	public static Compte createAccount(String id, String employeId, String mail, String password, TypeCompte typeCompte) {
		return new Compte(id, employeId, mail, password, typeCompte);
	}
	
	public static Employe createEmploye(String id, String code, String prenom, String nom, String telephone, String mail) {
		return new Employe(id, code, prenom, nom, telephone, mail);
	}
	/***********************TERMINE****************************/
	
	@Deprecated
	public static Service createService(String code) { return new Service(code); }
	
	@Deprecated
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
	
	@Deprecated
	public static Competence createCompetence(String code) { return new Competence(code); }
	
	@Deprecated
	public static Competence createCompetence(String code, String libelle) { return new Competence(code, libelle); }
	
	@Deprecated
	public static Competence createCompetence(String code, String libelle, String description) {
		return new Competence(code, libelle, description);
	}
	
	public static Connaissance createConnaissance(String code) { return new Connaissance(code); }
	
	public static Connaissance createConnaissance(String code, String libelle) { return new Connaissance(code, libelle); }
	
	public static Connaissance createConnaissance(String code, String libelle, String description) {
		return new Connaissance(code, libelle, description);
	}
}
