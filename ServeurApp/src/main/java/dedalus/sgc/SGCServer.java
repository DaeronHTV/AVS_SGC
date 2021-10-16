package dedalus.sgc;

import org.eclipse.jetty.server.Server;
import org.eclipse.jetty.server.ServerConnector;

import javax.xml.bind.JAXBException;

import org.eclipse.jetty.server.Connector;
import org.eclipse.jetty.servlet.ServletHandler;
import org.eclipse.jetty.util.thread.QueuedThreadPool;

import Avsoft.Manager.Config.ConfigManager;
import asmr.Integration.mail.MailService;
import asmr.visioPadAPI.*;
import dedalus.core.config.ServerConfig;

public class SGCServer {
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
    	ServerConfig.getInstance();
    }

    void start() throws Exception {
    	InitManager();
        int maxThreads = 100;
        int minThreads = 10;
        int idleTimeout = 120;

        QueuedThreadPool threadPool = new QueuedThreadPool(maxThreads, minThreads, idleTimeout);
        server = new Server(threadPool);
        ServerConnector connector = new ServerConnector(server);
        connector.setPort(5555);
        server.setConnectors(new Connector[] { connector });
        ServletHandler servletHandler = new ServletHandler();
        server.setHandler(servletHandler);
        servletHandler.addServletWithMapping(BlockingServlet.class, "/status");
        servletHandler.addServletWithMapping(ContactMailServlet.class, "/api/mail/contact");
        server.start();
        //startMail();
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
