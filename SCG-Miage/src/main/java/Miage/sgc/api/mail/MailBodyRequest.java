package Miage.sgc.api.mail;

import java.beans.Transient;

public class MailBodyRequest {
	private String senderMail;
	private String[] receiversMail;
	private String content;
	private String contentType;
	private String senderName;
	private String subject;

	public String getSenderMail() { return senderMail; }

	public void setSenderMail(String senderMail) { this.senderMail = senderMail; }

	public String[] getReceiversMail() { return receiversMail; }
	
	@Transient
	public String getReceiversStringMail() {
		String result = "";
		for(String s : receiversMail) result += s+",";
		return result;
	}

	public void setReceiversMail(String[] receiversMail) { this.receiversMail = receiversMail; }

	public String getContent() { return content; }

	public void setContent(String content) { this.content = content; }

	public String getContentType() { return contentType; }

	public void setContentType(String contentType) { this.contentType = contentType; }

	public String getSenderName() { return senderName; }

	public void setSenderName(String senderName) { this.senderName = senderName; }

	public String getSubject() {
		return subject;
	}

	public void setSubject(String subject) {
		this.subject = subject;
	}
}
