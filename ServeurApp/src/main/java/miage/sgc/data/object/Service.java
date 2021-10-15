package Miage.sgc.data.object;

import java.sql.Date;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

@XmlRootElement(name="Service")
public class Service implements IBaseObject{
	@XmlElement(name="ServiceId") private String serviceId;
	@XmlElement(name="Code") private String code;
	@XmlElement(name="Libelle") private String libelle;
	@XmlElement(name="DateCreation") private Date dateCreation;
	
	public static Service createService(String code) { return new Service(code); }
	
	public static Service createService(String code, String libelle) { return new Service(code, libelle); }
	
	@SuppressWarnings("unused") private Service() {}
	
	protected Service(String code) { this(code, null); }
	
	protected Service(String code, String libelle) {
		this.code = code;
		this.libelle = libelle;
	}
	
	@Override @XmlTransient
	public String getId() { return serviceId; }
	
	@Override
	public void setId(String id) { this.serviceId = id; }

	@XmlTransient
	public String getCode() { return code; }

	public void setCode(String code) { this.code = code; }

	@XmlTransient
	public String getLibelle() { return libelle; }

	public void setLibelle(String libelle) { this.libelle = libelle; }

	@XmlTransient
	public Date getDateCreation() { return dateCreation; }

	public void setDateCreation(Date dateCreation) { this.dateCreation = dateCreation; }
}
