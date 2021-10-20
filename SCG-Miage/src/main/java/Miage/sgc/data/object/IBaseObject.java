package Miage.sgc.data.object;

import java.sql.Date;

public interface IBaseObject {
	String getId();
	
	void setId(String id);
	
	Date getDateInsertion();
	
	void setDateInsertion(Date dateInsertion);
	
	Date getDateMaj();
	
	void setDateMaj(Date dateMaj);
}
