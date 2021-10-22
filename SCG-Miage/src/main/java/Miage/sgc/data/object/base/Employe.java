package Miage.sgc.data.object.base;

import Miage.sgc.data.object.BaseObject;
import com.fasterxml.jackson.annotation.JsonIgnore;
import Miage.core.helper.StringHelper;

public class Employe extends BaseObject{
	private String code;
	private String prenom;
	private String nom;
	private String telephone;
	private String mail;
	private String prenomASCII;
	private String nomASCII;
	
	@SuppressWarnings("unused") private Employe() {}
	
	protected Employe(String code, String prenom, String mail) {
		this(code, prenom, null, null, mail);
	}
	
	protected Employe(String code, String prenom, String nom, String telephone, String mail) {
		this(null, code, prenom, nom, telephone, mail);
	}
	
	protected Employe(String id, String code, String prenom, String nom, String telephone, String mail) {
		super(id, null, null);
		this.code = code;
		this.prenom = prenom;
		this.nom = nom;
		this.telephone = telephone;
		this.mail = mail;
		this.prenomASCII = StringHelper.ToASCII(prenom);
		this.nomASCII = StringHelper.ToASCII(nom);
	}

	public String getCode() { return code; }

	public void setCode(String code) { this.code = code; }

	public String getPrenom() { return prenom; }

	public void setPrenom(String prenom) {
		this.prenom = prenom; 
		this.prenomASCII = StringHelper.ToASCII(prenom);
	}

	public String getNom() { return nom; }

	public void setNom(String nom) { 
		this.nom = nom; 
		this.nomASCII = StringHelper.ToASCII(nom);
	}

	public String getTelephone() { return telephone; }

	public void setTelephone(String telephone) { this.telephone = telephone; }

	public String getMail() { return mail; }

	public void setMail(String mail) { this.mail = mail; }
	
	@JsonIgnore
	public String getPrenomASCII() { return prenomASCII; }

	@JsonIgnore
	public String getNomASCII() { return nomASCII; }
}
