package Miage.sgc.data.object;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

import Miage.sgc.data.enumeration.TypeCompetence;

@XmlRootElement(name="Competence")
public class Competence implements IBaseObject{
	@XmlElement(name="CompetenceId") private String competenceId;
	@XmlElement(name="Code") private String code;
	@XmlElement(name="Libelle") private String libelle;
	@XmlElement(name="Description") private String description;
	@XmlElement(name="typeCompetence") private TypeCompetence typeCompetence;
	
	@SuppressWarnings("unused") private Competence() { /*Pas modifier - Pour generation XML*/ }
	
	protected Competence(String code, TypeCompetence typeCompetence) {
		this(code, null, typeCompetence);
	}
	
	protected Competence(String code, String libelle, TypeCompetence typeCompetence) {
		this(code, libelle, null, typeCompetence);
	}
	
	protected Competence(String code, String libelle, String description, TypeCompetence typeCompetence) {
		this.code = code;
		this.libelle = libelle;
		this.description = description;
		this.typeCompetence = typeCompetence;
	}
	
	@Override @XmlTransient
	public String getId() { return competenceId; }

	@Override
	public void setId(String id) { this.competenceId = id; }
	
	@XmlTransient
	public TypeCompetence getTypeCompetence() { return typeCompetence; }
	
	public void setTypeCompetence(TypeCompetence typeCompetence) { this.typeCompetence = typeCompetence; }
	
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
