package Miage.sgc.data.enumeration;

import Avsoft.Helper.GenericMethodHelper;
import Avsoft.Patrons.Enumeration.IBaseEnum;

public enum TypeCompetence implements IBaseEnum{
	TECH("TECHNIQUE"),
	HUMAINE("HUMAINE"),
	INTERNE("INTERNE");
	
	private String code;

	TypeCompetence(String code){
		this.code = code;
	}
	
	@Override
	public String getCode() {
		return code;
	}
	
	public TypeCompetence fromValue(String code) {
		return GenericMethodHelper.<TypeCompetence>fromValue(code, TypeCompetence.values());
	}

}
