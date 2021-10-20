package Miage.sgc.data.object.base;

import Miage.sgc.data.object.BaseObject;

public class Service extends BaseObject{
	private String code;
	private String libelle;
	
	public static Service createService(String code) { return new Service(code); }
	
	public static Service createService(String code, String libelle) { return new Service(code, libelle); }
	
	@SuppressWarnings("unused") private Service() {}
	
	protected Service(String code) { this(code, null); }
	
	protected Service(String code, String libelle) {
		this.code = code;
		this.libelle = libelle;
	}

	public String getCode() { return code; }

	public void setCode(String code) { this.code = code; }

	public String getLibelle() { return libelle; }

	public void setLibelle(String libelle) { this.libelle = libelle; }
}
