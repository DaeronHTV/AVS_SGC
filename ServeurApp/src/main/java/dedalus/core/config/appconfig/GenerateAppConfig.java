package dedalus.core.config.appconfig;

import java.io.File;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;

public class GenerateAppConfig {

	public static void main(String[] args) throws JAXBException {
		List<Add> adds = new ArrayList<Add>();
		adds.add(new Add("mail.transport.protocol", "smtp"));
		adds.add(new Add("mail.smtp.port", "587"));
		List<Service> services = new ArrayList<Service>();
		List<Config> configs = new ArrayList<Config>();
		services.add(new Service("MailService", adds));
		configs.add(new Config("Logging", "./Logs.config"));
		configs.add(new Config("ConnectionStrings", "./ConnectionStrings.config"));
		Configs oconfigs = new Configs(configs);
		Services oservices = new Services(services);
		AppConfig app = new AppConfig(oconfigs, oservices);
		JAXBContext context = JAXBContext.newInstance(AppConfig.class);
	    Marshaller mar= context.createMarshaller();
	    mar.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, Boolean.TRUE);
	    mar.marshal(app, new File("./src/main/resources/dedalus/core/config/appconfig/App.config"));
	    mar.marshal(app, new File("./App.config"));
	}

}
