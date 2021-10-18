package Miage.sgc.api.mail;

import java.util.ArrayList;
import java.util.Properties;

import javax.mail.Authenticator;
import javax.mail.MessagingException;
import javax.mail.PasswordAuthentication;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.MimeMessage;
import Miage.core.helper.logs.LogHelper;

public class MailService implements Runnable {
	private Session session;
	private Transport transport;
    private ArrayList<MimeMessage> listeMail;
    private static volatile MailService instance = null;
    private int waitTime;
    private boolean serviceRunning;

    public MailService() {
        this.listeMail = new ArrayList<MimeMessage>();
        this.waitTime = 5000;
        this.serviceRunning = false;
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
    
    public Transport initTransport(){
        try
        {
            LogHelper.info("Création du transport smtp...");
            initSession();
            transport = session.getTransport("smtp");
        }
        catch(Exception e){ LogHelper.error("Erreur lors de l'initialisation du transport !", e); }
        return transport;
    }
    
    public Session initSession(){
        Authenticator auth = new Authenticator() {
            @Override
            protected PasswordAuthentication getPasswordAuthentication() {
                return new PasswordAuthentication("visiopad@outlook.com", "ASMRbdd2021");
            }
        };
        session = Session.getInstance(paramTransport(), auth);
        return session;
    }

    public void setWaitTime(int millisecond){
        this.waitTime = millisecond;
    }

    public void sendMessage(MimeMessage message) {
        try { Transport.send(message);} 
        catch (MessagingException e) { LogHelper.warning("Erreur lors de l'envoie du message !", e); }
    }

    public boolean close(){
        boolean result = false;
        try 
        {
            transport.close();
            result = true;
        } 
        catch (MessagingException e) { LogHelper.error("Erreur lors de la fermeture du transport !", e); }
        return result;
    }
    
    public boolean connect(){
        boolean result = false;
        try 
        {
            transport.connect("visiopad@outlook.com", "ASMRbdd2021");
            result = true;
            LogHelper.info("Connexion établie !");
        } 
        catch (MessagingException e) { LogHelper.error("Erreur lors de la connection du transport !", e); }
        return result;
    }
    
    public boolean transportConnected(){ return transport != null ? transport.isConnected() : false; }
 
    @Override
    public void run() {
        LogHelper.info("Initialisation du service Mail...");
        initTransport();connect();
        this.serviceRunning = true;
        while (this.serviceRunning) {
        	try {
        		while (listeMail.size() > 0) {
                    MimeMessage message = listeMail.get(0);
                    sendMessage(message);
                    listeMail.remove(0);
                    LogHelper.info("Envoie reussi du mail " + message.getFileName());
                }
        		Thread.sleep(waitTime);
        	}
        	catch(Exception e) {
        		LogHelper.error("Erreur du service Mail !", e);
        		this.serviceRunning = false;
        	}
        }
    }
    
    private Properties paramTransport() {
    	Properties prop = new Properties();
    	prop.put("mail.transport.protocol", "smtp");
    	prop.put("file.encoding", "UTF-8");
    	prop.put("mail.smtp.port", 587);
    	prop.put("mail.smtp.auth", true);
    	prop.put("mail.smtp.host", "SMTP.office365.com");
    	return prop;
    }
}

