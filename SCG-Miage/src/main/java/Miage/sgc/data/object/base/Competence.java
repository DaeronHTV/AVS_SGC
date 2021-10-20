package Miage.sgc.data.object.base;

import Miage.sgc.data.object.BaseObject;

public class Competence extends BaseObject{
	private String code;
	private String libelle;
    private String description;
	
	@SuppressWarnings("unused") private Competence() { /*Pas modifier - Pour generation XML*/ }
	
	protected Competence(String code) { this(code, null); }
	
	protected Competence(String code, String libelle) { this(code, libelle, null); }
	
	protected Competence(String code, String libelle, String description) {
		this.code = code;
		this.libelle = libelle;
		this.description = description;
	}
	
	public String getDescription() { return description; }
	
	public void setDescription(String description) { this.description = description; }
	
	public String getLibelle() { return libelle; }
	
	public void setLibelle(String libelle) { this.libelle = libelle; }
	
	public String getCode() { return code; }
	
	public void setCode(String code) { this.code = code; }
}
