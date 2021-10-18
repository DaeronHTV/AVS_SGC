package dedalus.sgc.data.object;

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

	@Override @XmlTransient
	public String getId() { return this.id; }

	@Override
	public void setId(String id) { this.id = id; }

	@Override @XmlTransient
	public Date getDateInsertion() { return this.dateInsertion; }

	@Override @XmlTransient
	public Date getDateMaj() { return this.dateMaj; }

	@Override
	public void setDateMaj(Date dateMaj) { this.dateMaj = dateMaj; }
}
