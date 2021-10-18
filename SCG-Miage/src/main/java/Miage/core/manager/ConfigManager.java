package Miage.core.manager;

import javax.xml.bind.JAXBException;
import Miage.core.bdd.config.ConnectionStrings;
import Miage.core.helper.logs.config.Logs;
import Miage.core.helper.GenericMethodHelper;

public class ConfigManager {
	//CONSTANTES
	public static final String extensionFichier = ".config";
	public static final String ParentConfigFileName = "AppSettings.config";
	public static final String LogConfigFileName = "Logs.config";
	public static final String ConnectionStringsFileName = "ConnectionStrings.config";
	//INSTANCE
	private static volatile ConfigManager instance = null;
	//ATTRIBUTS DE LA CLASSE
	private Logs configLogs;
	private ConnectionStrings connectionStrings;
	
	private ConfigManager() throws JAXBException {
		setConfigLogs();
		setConnectionStrings();
	}

	private ConfigManager(String FilePath) {
		
	}
	
	public static ConfigManager getInstance() throws JAXBException {
        if (ConfigManager.instance == null) {
           synchronized(ConfigManager.class) {
             if (ConfigManager.instance == null) {
            	 ConfigManager.instance = new ConfigManager();
             }
           }
        }
        return ConfigManager.instance;
	}
	
	private void setConfigLogs() throws JAXBException {
		configLogs = GenericMethodHelper.<Logs>getJaxbObjectFromFile(LogConfigFileName, Logs.class);
	}

	public Logs getConfigLogs() {
		return configLogs;
	}
	
	public ConnectionStrings getConnectionStrings() {
		return connectionStrings;
	}
	
	private void setConnectionStrings() throws JAXBException {
		connectionStrings = GenericMethodHelper.<ConnectionStrings>getJaxbObjectFromFile(ConnectionStringsFileName, ConnectionStrings.class);
	}
}
