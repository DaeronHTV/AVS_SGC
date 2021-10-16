package dedalus.sgc.api.auth;

import java.time.Instant;
import java.util.Date;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Map.Entry;
import Avsoft.Helper.StringHelper;
import Avsoft.Helper.Logs.LogHelper;

public class AuthService implements Runnable{
	private static volatile AuthService instance = null;
	private HashMap<String, Date> listeConnexions;
	
	private AuthService() {
		this.listeConnexions = new HashMap<String, Date>();
	}
	
	public final static AuthService getInstance(){
		if(AuthService.instance == null){
			synchronized(AuthService.class){
				if(AuthService.instance == null){
					instance = new AuthService();
	            }
	        }
	    }
	    return instance;
	}
	
	public void addConnexion(String mail) {
		this.listeConnexions.put(mail, Date.from(Instant.now()));
	}
	
	public boolean removeConnexion(String mail) {
		return false; //TODO
	}
	
	@Override
	public void run() {
		LogHelper.info("Initialisation du service Mail...");
	    while (true) {
	    	Iterator<Entry<String, Date>> iterator = listeConnexions.entrySet().iterator();
	    	while(iterator.hasNext()) {
	    		Map.Entry<String, Date> entry = iterator.next();
	    		if(Date.from(Instant.now()) != entry.getValue()) {
	    			LogHelper.info(StringHelper.Concat("La connexion du compte ", entry.getKey(), " est devenue obselete."));
	    			if(this.listeConnexions.remove(entry.getKey(), entry.getValue())) {
	    				LogHelper.info(StringHelper.Concat("Suppression de la connexion ", entry.getKey(), " au serveur reussi !"));
	    			}
	    			else LogHelper.warning("Suppression de la connexion impossible..."); 
	    		}
	    	}
	        try { Thread.sleep(10000); } //TODO a charger par appconfig
	        catch (InterruptedException e) {LogHelper.error("Erreur lors du sommeil du Thread", e);}
	    }
	}
}
