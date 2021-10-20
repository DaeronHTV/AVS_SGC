package Miage.core.helper;

import javax.mail.Session;
import java.util.Properties;
import javax.mail.Message.RecipientType;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;
import Miage.core.helper.logs.LogHelper;

public class MailHelper {
	public static MimeMessage createMimeMessage(Session session, Properties prop) {
        //message.setHeader("Content-Type", "text/html; charset=UTF-8");
        return createMimeMessage(session, prop.getProperty("mail.user"), prop.getProperty("mail.senderName"), prop.getProperty("mail.to"), 
        		prop.getProperty("mail.subject"), prop.getProperty("mail.message"), prop.getProperty("mail.contentType"));
	}
	
	public static MimeMessage createMimeMessage(Session session, String senderName, String senderMail, String receiversMail, String subject,
			String content, String ContentType) {
		MimeMessage message = new MimeMessage(session);
		try {
	            message.setFrom(new InternetAddress(senderMail, senderName)); 
	            message.setRecipients(RecipientType.TO, InternetAddress.parse(receiversMail));
	            message.setHeader("Content-Type", ContentType);
	            message.setSubject(subject, "UTF-8");
	            message.setContent(content, ContentType);
		}
		catch(Exception e) {
			LogHelper.warning("Erreur lors de la création du message !", e);
			message = null;
		}
		return message;
	}
}
