package dedalus.sgc.data.enumeration;

import dedalus.core.helper.GenericMethodHelper;
import dedalus.core.patrons.enumeration.IBaseEnum;

public enum TypeCompte implements IBaseEnum{
	MEMBRE("MEMBRE"),
	ADMIN("ADMINISTRATEUR"),
	MANAGER("MANAGER");
	
	private String code;

	TypeCompte(String code){
		this.code = code;
	}
	
	@Override
	public String getCode() {
		return code;
	}
	
	public static TypeCompte fromValue(String code) {
		return GenericMethodHelper.<TypeCompte>fromValue(code, TypeCompte.values());
	}
	
}
