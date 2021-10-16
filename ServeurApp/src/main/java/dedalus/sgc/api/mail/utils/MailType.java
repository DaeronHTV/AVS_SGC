package dedalus.sgc.api.mail.utils;

import dedalus.core.ConstHelper;
import dedalus.core.helper.FileHelper;

/**
 * Il s'agit d'une enumeration gardant en mémoire l'ensemble des données
 * sur les différents mails envoyés automatiquement par le service mail
 * afin de simplifier leur utilisation
 * @author Avanzino Aurélien
 * @since 29/01/2021
 */
public enum MailType {
    /**
     * Contient l'ensemble des informations relatifs au mail automatique envoyé 
     * lorsqu'un nouveau compte est créé par un utilisateur
     */
    ACCOUNTCREATE(FileHelper.fileToString(ConstHelper.AccCreateMail), "SCG - Creation de compte reussi !"),
    CHANGEPWD(FileHelper.fileToString(ConstHelper.PwdChangeMail), "SGC - Demande de modification de mot de passe"),
    CONTACT(FileHelper.fileToString(ConstHelper.ContactMail), "Ticket Support");

    public interface Code{
        String ACCOUNTCREATE = "AccountCreate";
        String ACCOUNTVERIFIED = "AccountVerified";
        String RAPPELRDV = "RappelRdv";
        String CONTACT = "MailContact";
    }

    private String message;
    private String subject;
    
    /**
     * Cosntructeur par defaut d'un mail type
     * @param code Le code identifiant du message automatique
     */
    private MailType(String message, String subject){
        this.subject = subject;
        this.message = message;
    }

    /**
     * Le message formaté en html
     * @return The text and format of the message
     * @since 29/01/2021
     */
    public String message(){ return this.message; }

    /**
     * Obtient le sujet du message sous la forme d'un string
     * @return Le sujet du message
     */
    public String subject(){
        return this.subject;
    }
}
