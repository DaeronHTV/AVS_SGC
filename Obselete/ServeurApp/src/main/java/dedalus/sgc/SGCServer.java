package dedalus.sgc;

import org.eclipse.jetty.server.Server;
import org.eclipse.jetty.server.ServerConnector;
import org.eclipse.jetty.server.Connector;
import org.eclipse.jetty.servlet.ServletHandler;
import org.eclipse.jetty.util.thread.QueuedThreadPool;
//Import des Services
import dedalus.sgc.api.mail.MailService;
import dedalus.sgc.api.compte.AuthService;
// Import des Servlet
import dedalus.sgc.api.mail.servlet.*;
import dedalus.sgc.api.BlockingServlet;
//Import des exceptions
import java.net.BindException;
import javax.xml.bind.JAXBException;
//Import des managers et configuration
import dedalus.core.config.ServerConfig;
import dedalus.core.config.appsettings.ApiConf;
import dedalus.core.helper.logs.LogHelper;
import dedalus.core.manager.config.ConfigManager;

public class SGCServer {
	private ApiConf serverConf;
    private Server server;
    private Thread mail;
    
    /**
     * On appelle les differents getInstance des managers afin
     * que ces derniers soit initialise des le debut afin d'eviter
     * tout probleme
     * @throws JAXBException
     */
    void InitManager() throws JAXBException {
    	ConfigManager.getInstance();
    	serverConf = ServerConfig.getInstance().appSettings.getApiConf();
    }
    
    void InitService() {
    	startMail();
    }
    
    void InitServlet(ServletHandler servletHandler) {
    	servletHandler.addServletWithMapping(BlockingServlet.class, "/status");
        servletHandler.addServletWithMapping(ContactMailServlet.class, "/api/mail/contact");
    }

    void start() throws Exception {
    	InitManager();
    	/*Initialisation base*/
        QueuedThreadPool threadPool = new QueuedThreadPool(serverConf.getMaxThreads(), serverConf.getMinThreads(), serverConf.getIdleTimeOut());
        server = new Server(threadPool);
        ServerConnector connector = new ServerConnector(server);
        ServletHandler servletHandler = new ServletHandler();
        server.setHandler(servletHandler);
        InitServlet(servletHandler);
        /*Lancement du serveur*/
        int i = 0;
        while(i < serverConf.getPorts().size() && !server.isStarted()) {
        	try {
        		connector.setPort(serverConf.getPorts().get(i));
        		server.setConnectors(new Connector[] { connector });
        		server.start();
        	}
        	catch(BindException be) { LogHelper.warning("Address already in use !", be); i++;}
        }
        if(i == serverConf.getPorts().size())
        	LogHelper.error("Impossible de lancer le serveur avec la configurationa actuel ! Veuillez changer les parametres...");
        else LogHelper.info("Le serveur ecoute sur le port : " + serverConf.getPorts().get(i));
    }

    void startMail() {
        MailService mService = MailService.getInstance();
        mService.setWaitTime(10000);
        mail = new Thread(mService);
        mail.setDaemon(true);
        mail.start();
    }

    void stop() throws Exception {
        System.out.println("Server stop");
        server.stop();
    }

    public static void main(String[] args) throws Exception {
        SGCServer server = new SGCServer();
        server.start();
    }
}
