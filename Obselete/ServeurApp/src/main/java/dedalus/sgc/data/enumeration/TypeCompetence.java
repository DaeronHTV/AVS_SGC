package dedalus.sgc.data.enumeration;

import dedalus.core.helper.GenericMethodHelper;
import dedalus.core.patrons.enumeration.IBaseEnum;

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
