package Miage.sgc.data.enumeration;

import Miage.core.helper.GenericMethodHelper;
import Miage.core.patrons.enumeration.IBaseEnum;

public enum TypeCompetence implements IBaseEnum{
	TECH("TECHNIQUE"),
	HUMAINE("HUMAINE"),
	INTERNE("INTERNE");
	
	private String code;

	TypeCompetence(String code){
		this.code = code;
	}
	
	public String getCode() {
		return code;
	}
	
	public TypeCompetence fromValue(String code) {
		return GenericMethodHelper.<TypeCompetence>fromValue(code, TypeCompetence.values());
	}

}
