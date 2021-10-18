package Miage.core.config.appconfig;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name="Config")
public class Config {
	@XmlAttribute(name="name") private String name;
	@XmlAttribute(name="ref") private String ref;
	
	public Config() { }
	
	public Config(String name, String ref) {
		this.name = name;
		this.ref = ref;
	}
}
