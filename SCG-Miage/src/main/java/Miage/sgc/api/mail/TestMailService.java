package Miage.sgc.api.mail;

public class TestMailService {

	public static void main(String[] args) {
		 MailService Mservice = MailService.getInstance();
	        Mservice.setWaitTime(10000);

	        Thread test = new Thread(Mservice);
	        test.start();
	        try {test.join();} 
	        catch (InterruptedException e) {e.printStackTrace();}

	}

}
