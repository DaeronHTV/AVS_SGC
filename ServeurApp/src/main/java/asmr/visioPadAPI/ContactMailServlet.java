package asmr.visioPadAPI;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import asmr.Integration.mail.MailService;
import Avsoft.Helper.Logs.LogHelper;

public class ContactMailServlet extends HttpServlet{
    private static final long serialVersionUID = 1L;
    
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		response.setContentType("application/json");
		response.setStatus(HttpServletResponse.SC_OK);
		response.setHeader("Access-Control-Allow-Origin", "*");
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		response.setHeader("Access-Control-Allow-Origin", "*");
		response.setContentType("application/json");
		try {
			String name = request.getParameter("nom") + " " + request.getParameter("prenom");
            String adresse = request.getParameter("mail");
            String uSubject = request.getParameter("sujet");
            String uMessage = request.getParameter("message");
            String date = request.getParameter("date");
            MailService ms = MailService.getInstance();
            ms.addContact(adresse, name, uSubject, uMessage, date);

			response.setStatus(HttpServletResponse.SC_OK);
			response.getWriter().print("Le mail de contact a été ajouté à la liste...");
		} catch (Exception e) {
            LogHelper.error(e);
			response.setStatus(HttpServletResponse.SC_INTERNAL_SERVER_ERROR);
			response.getWriter().println(e.toString());
		}
	}   
}
