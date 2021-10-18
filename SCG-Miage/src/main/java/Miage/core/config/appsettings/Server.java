package Miage.core.config.appsettings;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

@XmlRootElement(name="Server")
public class Server {
	@XmlElement(name="MaxThreads") private int MaxThreads;
	@XmlElement(name="MinThreads") private int MinThreads;
	@XmlElement(name="idleTimeout") private int idleTimeout;
	
	public Server() {}
	
	public Server(int maxThreads, int minThreads, int idleTimeOut) {
		this.MaxThreads = maxThreads;
		this.MinThreads = minThreads;
		this.idleTimeout = idleTimeOut;
	}
	
	@XmlTransient
	public int getMaxThreads() { return this.MaxThreads; }
	
	@XmlTransient
	public int getMinThreads() { return this.MinThreads; }
	
	@XmlTransient
	public int getIdleTimeOut() { return this.idleTimeout; }
}
