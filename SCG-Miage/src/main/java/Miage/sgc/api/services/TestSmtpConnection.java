package Miage.sgc.api.services;

import org.apache.commons.mail.DefaultAuthenticator;
import org.apache.commons.mail.Email;
import org.apache.commons.mail.SimpleEmail;

public class TestSmtpConnection {

	public static void main(String[] args) {
		 try {            
	          Email email = new SimpleEmail();
	         
	          // Configuration
	          email.setHostName("smtp-mail.outlook.com");
	          email.setSmtpPort(587);
	          email.setAuthenticator(new DefaultAuthenticator("visiopad@outlook.com",
	                  "ASMRbdd2021"));
	         
	          // Required for gmail
	          email.setSSLOnConnect(true);
	         
	          // Sender
	          email.setFrom("visiopad@outlook.com");
	         
	          // Email title
	          email.setSubject("Test Email");
	         
	          // Email message.
	          email.setMsg("This is a test mail ... :-)");
	         
	          // Receiver
	          email.addTo("cita.avan@gmail.com");            
	          email.send();
	          System.out.println("Sent!!");
	      } catch (Exception e) {
	          e.printStackTrace();
	      }
	}

}
