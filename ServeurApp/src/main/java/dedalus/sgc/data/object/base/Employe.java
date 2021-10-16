package dedalus.sgc.data.object.base;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;
import dedalus.sgc.data.object.BaseObject;
import dedalus.core.helper.StringHelper;

@XmlRootElement(name="Employe")
public class Employe extends BaseObject{
	@XmlElement(name="Code") private String code;
	@XmlElement(name="Prenom") private String prenom;
	@XmlElement(name="Nom") private String nom;
	@XmlElement(name="Telephone") private String telephone;
	@XmlElement(name="Mail") private String mail;
	@XmlElement(name="PrenomASCII") private String prenomASCII;
	@XmlElement(name="NomASCII") private String nomASCII;
	
	@SuppressWarnings("unused") private Employe() {}
	
	protected Employe(String code, String prenom, String mail) {
		this.code = code;
		this.prenom = prenom;
		this.mail = mail;
	}
	
	protected Employe(String code, String prenom, String nom, String telephone, String mail) {
		this.code = code;
		this.prenom = prenom;
		this.nom = nom;
		this.telephone = telephone;
		this.mail = mail;
		this.prenomASCII = StringHelper.ToASCII(prenom);
		this.nomASCII = StringHelper.ToASCII(nom);
	}

	@XmlTransient
	public String getCode() { return code; }

	public void setCode(String code) { this.code = code; }

	@XmlTransient
	public String getPrenom() { return prenom; }

	public void setPrenom(String prenom) {
		this.prenom = prenom; 
		this.prenomASCII = StringHelper.ToASCII(prenom);
	}

	@XmlTransient
	public String getNom() { return nom; }

	public void setNom(String nom) { 
		this.nom = nom; 
		this.nomASCII = StringHelper.ToASCII(nom);
	}

	@XmlTransient
	public String getTelephone() { return telephone; }

	public void setTelephone(String telephone) { this.telephone = telephone; }

	@XmlTransient
	public String getMail() { return mail; }

	public void setMail(String mail) { this.mail = mail; }

	@XmlTransient
	public String getPrenomASCII() { return prenomASCII; }

	@XmlTransient
	public String getNomASCII() { return nomASCII; }
}
