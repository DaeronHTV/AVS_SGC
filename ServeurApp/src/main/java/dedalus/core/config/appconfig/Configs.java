package dedalus.core.config.appconfig;

import java.util.List;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name="Configs")
public class Configs {
	@XmlElement(name="Config") private List<Config> configs;
	
	public Configs() { }
	
	public Configs(List<Config> configs) {
		this.configs = configs;
	}
}
