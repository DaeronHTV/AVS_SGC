package Miage.core.config;

import javax.xml.bind.JAXBException;
import Miage.core.ConstHelper;
import Miage.core.config.appconfig.AppConfig;
import Miage.core.config.appsettings.AppSettings;
import Miage.core.helper.GenericMethodHelper;

public class ServerConfig {
	private static volatile ServerConfig instance = null;
	public AppSettings appSettings;
	public AppConfig appConfig;
	
	private ServerConfig() throws JAXBException {
		setAppSettings();
		setAppConfig();
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
		appSettings = GenericMethodHelper.<AppSettings>getJaxbObjectFromFile(ConstHelper.appSettingsPath, AppSettings.class);
	}
	
	private void setAppConfig() throws JAXBException {
		appConfig = GenericMethodHelper.<AppConfig>getJaxbObjectFromFile(ConstHelper.appConfigPath, AppConfig.class);
	}
}