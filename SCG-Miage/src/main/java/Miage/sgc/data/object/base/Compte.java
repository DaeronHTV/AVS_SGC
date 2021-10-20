package Miage.sgc.data.object.base;

import Miage.sgc.data.enumeration.TypeCompte;
import Miage.sgc.data.object.BaseObject;

/**
 * Classe representant l'objet Compte present en base de donnees
 * @apiNote Cette derniere n'a aucun lien directe avec la base de donnees
 * et les connexions. Ces derniers sont present dans la classe DAO associe
 * @implSpec Impossible de creer l'objet directement via la classe. La
 * construction doit être effectue via la classe ObjectBuilder
 * @since 16/10/2021
 * @version 1.0
 * @author Avanzino.A
 */
public class Compte extends BaseObject{
	private String employeId;
	private String mail;
	private String password;
	private TypeCompte typeCompte;
	
	@SuppressWarnings("unused") private Compte() { /*Pas modifier - Pour generation XML*/ }
	
	/**
	 * Constructeur pour creation de la base du compte
	 * @param employeId Identifiant de l'employe associe au compte
	 * @param typeCompte Le type de Compte
	 */
	protected Compte(String employeId, String mail, TypeCompte typeCompte) {
		this.employeId = employeId;
		this.typeCompte = typeCompte;
		this.mail = mail;
	}
	
	/**
	 * Constructeur prenant l'ensemble des donnees Compte en parametre
	 * @apiNote A utiliser uniquement pour la lecture d'un objet compte
	 * @param id Identifiant unique de l'objet
	 * @param employeId Identifiant de l'employe associe au compte
	 * @param password Mot de passe du compte
	 * @param typeCompte Le type de Compte
	 * @param dateInsertion Date a laquelle ce compte a ete insere en base de donnees
	 * @param dateMaj Date de la derniere mise a jour de l'objet en BD
	 */
	protected Compte(String id, String employeId, String mail, String password, TypeCompte typeCompte) {
		super(id, null, null);
		this.employeId = employeId;
		this.password = password;
		this.typeCompte = typeCompte;
		this.mail = mail;
	}
	
	/**
	 * @return L'identifiant de l'employe associe au compte
	 */
	public String getEmployeId() { return employeId; }
	
	/**
	 * Permet de changer l'employe associe a un compte
	 * @param employeId Le nouvel employe a associe au compte
	 */
	public void setEmployeId(String employeId) { this.employeId = employeId; }

	/**
	 * @return Le mot de passe du compte
	 */
	public String getPassword() { return password; }

	/**
	 * Change le mot de passe du compte
	 * @param password Le nouveau mot de passe
	 */
	public void setPassword(String password) { this.password = password; }
	
	/**
	 * @return Le type du compte
	 */
	public TypeCompte getTypeCompte() { return typeCompte; }
	
	/**
	 * @param typeCompte Change le type du compte
	 * @apiNote Le type du compte permet d'avoir des privileges sur la 
	 * modification des donnees en base
	 */
	public void setTypeCompte(TypeCompte typeCompte) { this.typeCompte = typeCompte; }
	
	public String getMail() { return this.mail; }
	
	public void setMail(String mail) { this.mail = mail; }
}