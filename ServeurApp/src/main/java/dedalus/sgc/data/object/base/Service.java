package dedalus.sgc.data.object.base;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

import dedalus.sgc.data.object.BaseObject;

@XmlRootElement(name="Services")
public class Service extends BaseObject{
	@XmlElement(name="Code") private String code;
	@XmlElement(name="Libelle") private String libelle;
	
	public static Service createService(String code) { return new Service(code); }
	
	public static Service createService(String code, String libelle) { return new Service(code, libelle); }
	
	@SuppressWarnings("unused") private Service() {}
	
	protected Service(String code) { this(code, null); }
	
	protected Service(String code, String libelle) {
		this.code = code;
		this.libelle = libelle;
	}

	@XmlTransient
	public String getCode() { return code; }

	public void setCode(String code) { this.code = code; }

	@XmlTransient
	public String getLibelle() { return libelle; }

	public void setLibelle(String libelle) { this.libelle = libelle; }
}
