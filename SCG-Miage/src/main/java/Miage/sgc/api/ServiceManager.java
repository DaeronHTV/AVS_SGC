package Miage.sgc.api;

import java.util.HashMap;
import java.util.Map;
import Miage.core.helper.StringHelper;
import Miage.core.helper.logs.LogHelper;
import Miage.core.patrons.IService;

/**
 * Class used in order to manage the different services running 
 * in parallel of the server.
 * @implSpec Use the singleton design pattern
 * @author Avanzino.A
 * @since 19/10/2021
 * @version 1.0
 */
public class ServiceManager implements Runnable{
	public static volatile ServiceManager instance = null;
	private HashMap<String, IService> threadList;
	
	/**
	 * Default constructor used only by the getInstance method
	 */
	private ServiceManager() { this.threadList = new HashMap<String, IService>(); }
	
	/**
	 * Get the instance of the class if it is already created
	 * else create the instance and return it
	 * @return The instance of the manager class
	 */
	public static ServiceManager getInstance() {
		if(ServiceManager.instance == null){
            synchronized(ServiceManager.class){
                if(ServiceManager.instance == null){
                    instance = new ServiceManager();
                }
            }
        }
        return instance;
	}
	
	/**
	 * Method which allow to add a service in the list of the running services
	 * @param code The code used to identify the service
	 * @param service The service to add in the list
	 */
	public void addService(String code, IService service) { this.threadList.put(code, service); }

	/**{@inheritDoc}**/
	@Override
	public void run() {
		LogHelper.info("Lancement du ServiceManager");
        while (true) {
        	try {
        		for(Map.Entry<String, IService> entry : threadList.entrySet()) {
        			if(!entry.getValue().isRunning()) 
        				startService(entry.getValue());
        		}
        		Thread.sleep(60000);
        		LogHelper.info("Relance de la scrutation");
        	}
        	catch(Exception e) { LogHelper.error("Erreur du ServiceManager !", e); }
        }
	}
	
	/**
	 * Launch the service given in parameter of the method
	 * @param service The service to start
	 */
	public static void startService(IService service) {
		LogHelper.info(StringHelper.Concat("Demarrage du service : ", service.getServiceName()));
        Thread thread = new Thread(service);
        thread.setDaemon(true); thread.start();
	}
}
