package Miage.sgc.data.object.base;

import Miage.sgc.data.object.BaseObject;

public class Emploi extends BaseObject{
	private String code;
	private String libelle;
	private String description;
	
	@SuppressWarnings("unused") private Emploi() {}
	
	protected Emploi(String code) { this.code = code; }
	
	protected Emploi(String code, String libelle) { this(code, libelle, null); }
	
	protected Emploi(String code, String libelle, String description) {
		this(null, code, libelle, description);
	}
	
	protected Emploi(String id, String code, String libelle, String description) {
		super(id, null, null);
		this.code = code;
		this.libelle = libelle;
		this.description = description;
	}

	public String getCode() { return code; }

	public void setCode(String code) { this.code = code; }

	public String getLibelle() { return libelle; }

	public void setLibelle(String libelle) { this.libelle = libelle; }

	public String getDescription() { return description; }

	public void setDescription(String description) { this.description = description; }
}
