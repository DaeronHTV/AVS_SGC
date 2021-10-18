package dedalus.core.config.appconfig;

import java.util.List;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name="Services")
public class Services {
	@XmlElement(name="Service") private List<Service> services;
	
	public Services() {}
	
	public Services(List<Service> services) { this.services = services; }
}
