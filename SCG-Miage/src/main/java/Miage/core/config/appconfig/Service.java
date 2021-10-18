package Miage.core.config.appconfig;

import java.util.List;
import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name="Service")
public class Service {
	@XmlAttribute(name="name") private String name;
	@XmlElement(name="add") private List<Add> adds; 
	
	public Service() {}
	
	public Service(String name, List<Add> adds) { this.name = name; this.adds = adds; }
}
