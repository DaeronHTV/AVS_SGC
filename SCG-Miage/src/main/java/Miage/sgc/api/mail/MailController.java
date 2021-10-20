package Miage.sgc.api.mail;

import javax.mail.internet.MimeMessage;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;
import Miage.core.helper.MailHelper;
import Miage.sgc.api.services.MailService;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;

/**
 * Controller used in order to communication with the mail service
 * @author Avanzino.A
 * @since 19/10/2021
 * @version 1.0
 */
@RestController
@Api(value="Controller used in order to communicate with the mail service")
public class MailController {
	private MailService instance = MailService.getInstance();
	
	@ApiOperation(value="Post the contact mail write by the user into the sending list of the mail service")
	@RequestMapping(method = RequestMethod.PUT, value = "/api/mail/contact")
	public String sendContactMail(@RequestBody MailBodyRequest mailContact) {
		MimeMessage mail = MailHelper.createMimeMessage(instance.getSession(), mailContact.getSenderName(), 
				mailContact.getSenderMail(), mailContact.getReceiversStringMail(), mailContact.getSubject(), 
				mailContact.getContent(), mailContact.getContentType());
		instance.addMessage(mail);
		return "TODO";
	}
}
