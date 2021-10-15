package Miage.sgc.api;

import java.io.File;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import Miage.sgc.data.enumeration.TypeCompte;
import Miage.sgc.data.object.Compte;
import Miage.sgc.data.object.ObjectBuilder;

public class testXmlDate {

	public static void main(String[] args) throws JAXBException {
		Compte test = ObjectBuilder.createBaseAccount("test", "test", TypeCompte.MEMBRE);
		JAXBContext context = JAXBContext.newInstance(Compte.class);
	    Marshaller mar= context.createMarshaller();
	    mar.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, Boolean.TRUE);
	    mar.marshal(test, new File("./Data.config"));
	}

}
