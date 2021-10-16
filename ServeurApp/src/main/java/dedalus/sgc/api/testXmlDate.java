package dedalus.sgc.api;

import java.io.File;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;

import dedalus.sgc.data.object.base.Employe;
import dedalus.sgc.data.object.base.ObjectBuilder;

public class testXmlDate {

	public static void main(String[] args) throws JAXBException {
		Employe test = ObjectBuilder.createEmploye("AAV", "Aurélien", "aurelien.avanzino@dedalus.eu");
		JAXBContext context = JAXBContext.newInstance(Employe.class);
	    Marshaller mar= context.createMarshaller();
	    mar.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, Boolean.TRUE);
	    mar.marshal(test, new File("./Data.config"));
	}
}
