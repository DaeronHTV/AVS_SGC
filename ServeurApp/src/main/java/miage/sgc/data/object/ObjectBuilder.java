package Miage.sgc.data.object;

import java.sql.Date;

import Miage.sgc.data.enumeration.TypeCompetence;
import Miage.sgc.data.enumeration.TypeCompte;

public class ObjectBuilder {
	public static Service createService(String code) { return new Service(code); }
	
	public static Service createService(String code, String libelle) { return new Service(code, libelle); }
	
	public static Employe createEmploye(String code, String prenom, String mail) { return new Employe(code, prenom, mail); }
	
	public static Employe createEmploy(String code, String prenom, String nom, int telephone, String mail, String posteLibelle, Date dateArrivee, Date dateNaissance, String adresse) {
		return new Employe(code, prenom, nom, telephone, mail, posteLibelle, dateArrivee, dateNaissance, adresse);
	}
	
	public static Emploi createEmploi(String code) { return new Emploi(code); }
	
	public static Emploi createEmploi(String code, String libelle) { return new Emploi(code, libelle); }
	
	public static Emploi createEmploi(String code, String libelle, String description) {
		return new Emploi(code, libelle, description);
	}
	
	public static Compte createBaseAccount(String employeId, String serviceId, TypeCompte typeCompte) {
		return new Compte(employeId, serviceId, typeCompte);
	}
	
	public static Competence createCompetence(String code, TypeCompetence typeCompetence) {
		return new Competence(code, typeCompetence);
	}
	
	public static Competence createCompetence(String code, String libelle, TypeCompetence typeCompetence) {
		return new Competence(code, libelle, typeCompetence);
	}
	
	public static Competence createCompetence(String code, String libelle, String description, TypeCompetence typeCompetence) {
		return new Competence(code, libelle, description, typeCompetence);
	}
}
