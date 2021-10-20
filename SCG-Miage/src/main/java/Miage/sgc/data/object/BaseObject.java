package Miage.sgc.data.object;

import java.sql.Date;

public class BaseObject implements IBaseObject{
	private String id;
	private Date dateInsertion;
	private Date dateMaj;
	
	protected BaseObject() {
		this.dateInsertion = null;
		this.dateMaj = null;
	}
	
	protected BaseObject(String id, Date dateInsertion, Date dateMaj) {
		this.dateInsertion = dateInsertion;
		this.dateMaj = dateMaj;
		this.id = id;
	}

	public String getId() { return this.id; }

	public void setId(String id) { this.id = id; }

	public Date getDateInsertion() { return this.dateInsertion; }

	public Date getDateMaj() { return this.dateMaj; }

	public void setDateMaj(Date dateMaj) { this.dateMaj = dateMaj; }

	@Override
	public void setDateInsertion(Date dateInsertion) { this.dateInsertion = dateInsertion; }
}
