package dedalus.core.config.appconfig;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name="add")
public class Add {
	@XmlAttribute(name="name") private String name;
	@XmlAttribute(name="value") private String value;
	
	public Add() {}
	
	public Add(String name, String value) {
		this.name = name;
		this.value = value;
	}
}
