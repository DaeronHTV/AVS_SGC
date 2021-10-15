package Miage.sgc.data.object;

import java.sql.Date;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;
import Miage.sgc.data.enumeration.TypeCompte;

@XmlRootElement(name="Compte")
public class Compte implements IBaseObject{
	@XmlElement(name="CompteId") private String compteId;
	@XmlElement(name="EmployeId") private String employeId;
	@XmlElement(name="ServiceId") private String serviceId;
	@XmlElement(name="Password") private String password;
	@XmlElement(name="DateCreation") private Date dateCreation;
	@XmlElement(name="DateMaj") private Date dateMaj;
	@XmlElement(name="TypeCompte") private TypeCompte typeCompte;
	
	@SuppressWarnings("unused") private Compte() { /*Pas modifier - Pour generation XML*/ }
	
	protected Compte(String employeId, String serviceId, TypeCompte typeCompte) {
		this(null, employeId, serviceId, Date.valueOf("2021-10-10"), null, typeCompte);
	}
	
	protected Compte(String password, String employeId, String serviceId, Date dateCreation, Date dateMaj, TypeCompte typeCompte) {
		this.password = password;
		this.employeId = employeId;
		this.serviceId = serviceId;
		this.dateCreation = dateCreation;
		this.dateMaj = dateMaj;
		this.typeCompte = typeCompte;
	}

	@Override @XmlTransient
	public String getId() { return compteId; }

	@Override
	public void setId(String id) { this.compteId = id; }
	
	@XmlTransient
	public String getEmployeId() { return employeId; }
	
	public void setEmployeId(String employeId) { this.employeId = employeId; }
	
	@XmlTransient
	public String getServiceId() { return this.serviceId; }
	
	public void setServiceId(String serviceId) { this.serviceId = serviceId; }

	@XmlTransient
	public String getPassword() { return password; }

	public void setPassword(String password) { this.password = password; }

	@XmlTransient
	public Date getDateCreation() { return dateCreation; }

	public void setDateCreation(Date dateCreation) { this.dateCreation = dateCreation; }

	@XmlTransient
	public Date getDateMaj() { return dateMaj; }

	public void setDateMaj(Date dateMaj) { this.dateMaj = dateMaj; }

	@XmlTransient
	public TypeCompte getTypeCompte() { return typeCompte; }

	public void setTypeCompte(TypeCompte typeCompte) { this.typeCompte = typeCompte; }
}
