package Miage.sgc.data.enumeration;

import Avsoft.Helper.GenericMethodHelper;
import Avsoft.Patrons.Enumeration.IBaseEnum;

public enum TypeCompte implements IBaseEnum{
	MEMBRE("Membre"),
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
	
	public TypeCompte fromValue(String code) {
		return GenericMethodHelper.<TypeCompte>fromValue(code, TypeCompte.values());
	}
	
}
