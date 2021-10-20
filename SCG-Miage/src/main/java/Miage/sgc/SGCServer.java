package Miage.sgc;
import javax.xml.bind.JAXBException;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import Miage.core.helper.logs.LogHelper;
import Miage.core.manager.ConfigManager;
import Miage.sgc.api.ServiceManager;
import Miage.sgc.api.services.MailService;

@SpringBootApplication
public class SGCServer {
	private static Thread serviceManager = null;
	
	/**
	 * Initialise l'ensemble des managers utilisé par le serveur
	 * Cette initialisation doti être fait avant tout autre lancement
	 * @throws JAXBException 
	 */
	public static void initManager() throws JAXBException {
		ConfigManager.getInstance();
		LogHelper.info("Initialisation des Managers...");
		serviceManager = new Thread(ServiceManager.getInstance());
		serviceManager.setDaemon(true); 
	}
	
	/**
	 * Initialise l'ensemble des services utilisées par le serveur
	 */
	public static void initService() {
		LogHelper.info("Initialisation des Services...");
		ServiceManager.getInstance()/*.addService("MailService", MailService.getInstance())*/;
		serviceManager.start();
	}
	
	public static void main(String[] args) throws JAXBException {
		SpringApplication.run(SGCServer.class, args);
		initManager(); initService();
	}
}
