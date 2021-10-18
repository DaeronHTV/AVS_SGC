package dedalus.core.config.appsettings;

import java.util.List;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

@XmlRootElement(name = "ApiConf")
public class ApiConf {
	@XmlElement(name="Port") private List<Integer> ports;
	@XmlElementRef(name="Server") private Server server;
	
	public ApiConf() {}
	
	public ApiConf(List<Integer> ports, Server server) {
		this.ports = ports;
		this.server = server;
	}
	
	@XmlTransient
	public List<Integer> getPorts(){ return this.ports; }
	
	@XmlTransient
	public Server getServer() { return this.server; }
	
	@XmlTransient
	public int getMaxThreads() { return this.server.getMaxThreads(); }
	
	@XmlTransient
	public int getMinThreads() { return this.server.getMinThreads(); }
	
	@XmlTransient
	public int getIdleTimeOut() { return this.server.getIdleTimeOut(); }
}
