package Miage.core.config.appsettings;

import java.io.File;
import java.util.ArrayList;
import java.util.List;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;

public class GenerateAppSettings {

	public static void main(String[] args) throws JAXBException {
		Server server = new Server(100,10,120);
		List<Integer> ports = new ArrayList<Integer>();
		ports.add(5000); ports.add(5555); ports.add(8020);
		ApiConf apiConf = new ApiConf(ports, server);
		List<String> corsOrigins = new ArrayList<String>();
		corsOrigins.add("http://localhost:8020"); corsOrigins.add("http://localhost:4200");
		AppSettings appSettings = new AppSettings(corsOrigins, "*", apiConf);
		JAXBContext context = JAXBContext.newInstance(AppSettings.class);
	    Marshaller mar= context.createMarshaller();
	    mar.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, Boolean.TRUE);
	    mar.marshal(appSettings, new File("./src/main/resources/dedalus/core/config/appsettings/AppSettings.config"));
	    mar.marshal(appSettings, new File("./AppSettings.config"));
	}

}
