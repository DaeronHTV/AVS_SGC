package Miage.sgc.api.services;

import Miage.core.helper.MailHelper;

public class TestMailService {

	public static void main(String[] args) {
		 MailService Mservice = MailService.getInstance();
	     Thread test = new Thread(Mservice);
	     test.start();
	     MailService.getInstance().addMessage(MailHelper.createMimeMessage(MailService.getInstance().getSession(), 
	    		 "Bonjour monsieur", "visiopad@outlook.com", "cita.avan@gmail.com", "sujet du message", "bonjourcontenudumessage", "text/html; charset=UTF-8"));
	     try {test.join();} 
	     catch (InterruptedException e) {e.printStackTrace();}
	}

}
