package dedalus.core.config.appconfig;

import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

@XmlRootElement(name="App")
public class AppConfig {
	@XmlElementRef(name="Configs") private Configs configs;
	@XmlElementRef(name="Services") private Services services;
	
	public AppConfig() { }
	
	public AppConfig(Configs configs, Services services) {
		this.services = services;
		this.configs = configs;
	}
	
	@XmlTransient
	public Configs getConfigs() { return this.configs; }
	
	@XmlTransient
	public Services getServices() { return this.services; }
}
