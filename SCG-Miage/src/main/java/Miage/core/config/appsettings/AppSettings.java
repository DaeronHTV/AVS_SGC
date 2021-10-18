package Miage.core.config.appsettings;

import java.util.List;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlTransient;

@XmlRootElement(name="AppSettings")
public class AppSettings {
	@XmlElement(name="CorsOrigin") private List<String> CorsOrigins;
	@XmlElement(name="AllowedHost") private String allowedHost;
	@XmlElementRef(name="ApiConf") private ApiConf apiConf;
	
	public AppSettings() { }
	
	public AppSettings(List<String> corsOrigins, String allowedHost, ApiConf apiConf) {
		this.CorsOrigins = corsOrigins;
		this.allowedHost = allowedHost;
		this.apiConf = apiConf;
	}
	
	@XmlTransient
	public List<String> getCorsOrigins(){ return this.CorsOrigins; }
	
	@XmlTransient
	public String getAllowedHost() { return this.allowedHost; }
	
	@XmlTransient
	public ApiConf getApiConf() { return this.apiConf; }
}
