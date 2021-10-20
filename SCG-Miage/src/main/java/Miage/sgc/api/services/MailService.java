package Miage.sgc.api.services;

import java.util.ArrayList;
import java.util.Properties;
import javax.mail.Authenticator;
import javax.mail.MessagingException;
import javax.mail.PasswordAuthentication;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.MimeMessage;
import Miage.core.helper.logs.LogHelper;
import Miage.core.patrons.IService;

public class MailService implements IService {
	private Session session;
	private Transport transport;
    private ArrayList<MimeMessage> listeMail;
    private static volatile MailService instance = null;
    private boolean serviceRunning;

    public MailService() {
        this.listeMail = new ArrayList<MimeMessage>();
        this.serviceRunning = false;
        initTransport();
    }

    public final static MailService getInstance(){
        if(MailService.instance == null){
            synchronized(MailService.class){
                if(MailService.instance == null){
                    instance = new MailService();
                }
            }
        }
        return instance;
    }
    
    public boolean addMessage(MimeMessage message) { return this.listeMail.add(message); }
    
	@Override
	public boolean isRunning() { return this.serviceRunning; }

	@Override
	public String getServiceName() { return "MailService"; }
	
	public boolean transportConnected(){ return transport != null ? transport.isConnected() : false; }
	
	public Session getSession() { return this.session; }
	 
    @Override
    public void run() {
        LogHelper.info("Lancement du service Mail...");
        connect();
        this.serviceRunning = true;
        while (this.serviceRunning) {
        	try {
        		while (listeMail.size() > 0) {
                    MimeMessage message = listeMail.get(0);
                    sendMessage(message);
                    listeMail.remove(0);
                    LogHelper.info("Envoie reussi du mail " + message.getFileName());
                }
        		Thread.sleep(5000);
        	}
        	catch(Exception e) {
        		LogHelper.error("Erreur du service Mail !", e);
        		close();
        		this.serviceRunning = false;
        	}
        }
    }
    
    private Transport initTransport(){
        try
        {
            LogHelper.info("Création du transport smtp...");
            initSession();
            transport = session.getTransport("smtp");
        }
        catch(Exception e){ LogHelper.error("Erreur lors de l'initialisation du transport !", e); }
        return transport;
    }
    
    private Session initSession(){
        Authenticator auth = new Authenticator() {
            @Override
            protected PasswordAuthentication getPasswordAuthentication() {
                return new PasswordAuthentication("visiopad@outlook.com", "ASMRbdd2021");
            }
        };
        session = Session.getInstance(paramTransport(), auth);
        return session;
    }

    private void sendMessage(MimeMessage message) {
        try { Transport.send(message);} 
        catch (MessagingException e) { LogHelper.warning("Erreur lors de l'envoie du message !", e); }
    }

    private boolean close(){
        try 
        {
            transport.close();
            this.serviceRunning = false;
            LogHelper.warning("Fermeture de la connexion mail !");
  
        } 
        catch (MessagingException e) { LogHelper.error("Erreur lors de la fermeture du transport !", e); }
        return !serviceRunning;
    }
    
    private boolean connect(){
        try 
        {
            transport.connect("visiopad@outlook.com", "&");
            LogHelper.info("Connexion du ServiceMail etablie !");
            return true;
        } 
        catch (MessagingException e) { 
        	LogHelper.error("Erreur lors de la connection du transport !", e); 
        	return false;
        }
    }
    
    private Properties paramTransport() {
    	Properties prop = new Properties();
    	//prop.put("mail.transport.protocol", "smtp");
    	//prop.put("file.encoding", "UTF-8");
    	prop.put("mail.smtp.port", "587");
    	prop.put("mail.smtp.auth", "true");
    	prop.put("mail.smtp.starttls.enable", "true");
    	prop.put("mail.smtp.host", "smtp-mail.outlook.com");
    	return prop;
    }
}

