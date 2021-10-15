package Miage.sgc.data.object;

import java.sql.Date;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;
import Avsoft.Helper.StringHelper;

@XmlRootElement(name="Employe")
public class Employe implements IBaseObject{
	@XmlElement(name="EmployeId") private String employeId;
	@XmlElement(name="Code") private String code;
	@XmlElement(name="Prenom") private String prenom;
	@XmlElement(name="Nom") private String nom;
	@XmlElement(name="Telephone") private int telephone;
	@XmlElement(name="Mail") private String mail;
	@XmlElement(name="PosteLibelle") private String posteLibelle;
	@XmlElement(name="DateArrivee") private Date dateArrivee;
	@XmlElement(name="DateNaissance") private Date dateNaissance;
	@XmlElement(name="Adresse") private String adresse;
	@XmlElement(name="PrenomASCII") private String prenomASCII;
	@XmlElement(name="NomASCII") private String nomASCII;
	
	@SuppressWarnings("unused") private Employe() {}
	
	protected Employe(String code, String prenom, String mail) {
		this.code = code;
		this.prenom = prenom;
		this.mail = mail;
	}
	
	protected Employe(String code, String prenom, String nom, int telephone, String mail, String posteLibelle, Date dateArrivee, Date dateNaissance, String adresse) {
		this.code = code;
		this.prenom = prenom;
		this.nom = nom;
		this.telephone = telephone;
		this.mail = mail;
		this.posteLibelle = posteLibelle;
		this.dateArrivee = dateArrivee;
		this.dateNaissance = dateNaissance;
		this.adresse = adresse;
		this.prenomASCII = StringHelper.ToASCII(prenom);
		this.nomASCII = StringHelper.ToASCII(nom);
	}
	
	@Override @XmlTransient
	public String getId() { return employeId; }
	
	@Override
	public void setId(String id) { this.employeId = id; }

	@XmlTransient
	public String getCode() { return code; }

	public void setCode(String code) { this.code = code; }

	@XmlTransient
	public String getPrenom() { return prenom; }

	public void setPrenom(String prenom) { this.prenom = prenom; }

	@XmlTransient
	public String getNom() { return nom; }

	public void setNom(String nom) { this.nom = nom; }

	@XmlTransient
	public int getTelephone() { return telephone; }

	public void setTelephone(int telephone) { this.telephone = telephone; }

	@XmlTransient
	public String getMail() { return mail; }

	public void setMail(String mail) { this.mail = mail; }

	@XmlTransient
	public String getPosteLibelle() { return posteLibelle; }

	public void setPosteLibelle(String posteLibelle) { this.posteLibelle = posteLibelle; }

	@XmlTransient
	public Date getDateArrivee() { return dateArrivee; }

	public void setDateArrivee(Date dateArrivee) { this.dateArrivee = dateArrivee; }

	@XmlTransient
	public Date getDateNaissance() { return dateNaissance; }

	public void setDateNaissance(Date dateNaissance) { this.dateNaissance = dateNaissance; }

	@XmlTransient
	public String getAdresse() { return adresse; }

	public void setAdresse(String adresse) { this.adresse = adresse; }

	@XmlTransient
	public String getPrenomASCII() { return prenomASCII; }

	public void setPrenomASCII(String prenomASCII) { this.prenomASCII = StringHelper.ToASCII(prenomASCII); }

	@XmlTransient
	public String getNomASCII() { return nomASCII; }

	public void setNomASCII(String nomASCII) { this.nomASCII = StringHelper.ToASCII(nomASCII); }
}
