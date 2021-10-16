package dedalus.sgc.data.object.base;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

import dedalus.sgc.data.object.BaseObject;

@XmlRootElement(name="Competence")
public class Competence extends BaseObject{
	@XmlElement(name="Code") private String code;
	@XmlElement(name="Libelle") private String libelle;
	@XmlElement(name="Description") private String description;
	
	@SuppressWarnings("unused") private Competence() { /*Pas modifier - Pour generation XML*/ }
	
	protected Competence(String code) { this(code, null); }
	
	protected Competence(String code, String libelle) { this(code, libelle, null); }
	
	protected Competence(String code, String libelle, String description) {
		this.code = code;
		this.libelle = libelle;
		this.description = description;
	}
	
	@XmlTransient
	public String getDescription() { return description; }
	
	public void setDescription(String description) { this.description = description; }
	
	@XmlTransient
	public String getLibelle() { return libelle; }
	
	public void setLibelle(String libelle) { this.libelle = libelle; }
	
	@XmlTransient
	public String getCode() { return code; }
	
	public void setCode(String code) { this.code = code; }
}
