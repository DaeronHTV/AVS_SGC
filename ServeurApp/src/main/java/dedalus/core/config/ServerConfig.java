package dedalus.core.config;

import javax.xml.bind.JAXBException;

import Avsoft.Helper.GenericMethodHelper;
import dedalus.core.config.appsettings.AppSettings;

public class ServerConfig {
	private static volatile ServerConfig instance = null;
	public AppSettings appSettings;
	
	private ServerConfig() throws JAXBException {
		setAppSettings();
	}
	
	public static ServerConfig getInstance() throws JAXBException {
        if (ServerConfig.instance == null) {
           synchronized(ServerConfig.class) {
             if (ServerConfig.instance == null) {
            	 ServerConfig.instance = new ServerConfig();
             }
           }
        }
        return ServerConfig.instance;
	}
	
	private void setAppSettings() throws JAXBException {
		appSettings = GenericMethodHelper.<AppSettings>getJaxbObjectFromFile("AppSettings.config", AppSettings.class);
	}
	
	private void setAppConfig() {
		
	}
}
