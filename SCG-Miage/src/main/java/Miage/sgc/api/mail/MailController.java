package Miage.sgc.api.mail;

import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import Miage.sgc.api.mail.bodyrequest.MailContact;

@RestController
public class MailController {
	@RequestMapping(method = RequestMethod.PUT, value = "/api/mail/contact")
	public String sendContactMail(@RequestBody MailContact infoContact) {
		System.out.println(infoContact.getSenderMail());
		return "TODO";
	}
}
