package Miage.sgc.data.enumeration;

import Miage.core.helper.GenericMethodHelper;
import Miage.core.patrons.enumeration.IBaseEnum;

public enum TypeCompte implements IBaseEnum{
	MEMBRE("MEMBRE"),
	ADMIN("ADMINISTRATEUR"),
	MANAGER("MANAGER");
	
	private String code;

	TypeCompte(String code){
		this.code = code;
	}
	
	public String getCode() {
		return code;
	}
	
	public static TypeCompte fromValue(String code) {
		return GenericMethodHelper.<TypeCompte>fromValue(code, TypeCompte.values());
	}
	
	@Override
	public String toString() { return this.code; }
}
