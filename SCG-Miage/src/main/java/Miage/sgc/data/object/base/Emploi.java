package Miage.sgc.data.object.base;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;
import Miage.sgc.data.object.BaseObject;

@XmlRootElement(name="Emploi")
public class Emploi extends BaseObject{
	@XmlElement(name="Code") private String code;
	@XmlElement(name="Libelle") private String libelle;
	@XmlElement(name="Description") private String description;
	
	@SuppressWarnings("unused") private Emploi() {}
	
	protected Emploi(String code) { this.code = code; }
	
	protected Emploi(String code, String libelle) { this(code, libelle, null); }
	
	protected Emploi(String code, String libelle, String description) {
		this.code = code;
		this.libelle = libelle;
		this.description = description;
	}

	@XmlTransient
	public String getCode() { return code; }

	public void setCode(String code) { this.code = code; }

	@XmlTransient
	public String getLibelle() { return libelle; }

	public void setLibelle(String libelle) { this.libelle = libelle; }

	@XmlTransient
	public String getDescription() { return description; }

	public void setDescription(String description) { this.description = description; }
}
