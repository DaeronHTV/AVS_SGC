package Miage.sgc.data.object;

import java.sql.Date;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlTransient;

public class BaseObject implements IBaseObject{
	@XmlElement(name="Id") private String id;
	@XmlElement(name="DateInsetion") private Date dateInsertion;
	@XmlElement(name="DateMaj") private Date dateMaj;
	
	protected BaseObject() {
		this.dateInsertion = null;
		this.dateMaj = null;
	}
	
	protected BaseObject(String id, Date dateInsertion, Date dateMaj) {
		this.dateInsertion = dateInsertion;
		this.dateMaj = dateMaj;
		this.id = id;
	}

	@XmlTransient
	public String getId() { return this.id; }

	public void setId(String id) { this.id = id; }

	@XmlTransient
	public Date getDateInsertion() { return this.dateInsertion; }

	@XmlTransient
	public Date getDateMaj() { return this.dateMaj; }

	public void setDateMaj(Date dateMaj) { this.dateMaj = dateMaj; }
}
