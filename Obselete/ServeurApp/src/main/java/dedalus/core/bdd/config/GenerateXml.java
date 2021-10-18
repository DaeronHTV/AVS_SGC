package dedalus.core.bdd.config;

import java.io.File;
import java.io.IOException;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import dedalus.core.manager.config.ConfigManager;

@SuppressWarnings("unused")
public class GenerateXml {

	public static void main(String[] args) throws JAXBException, IOException {
		//GENERATION DU XML
		/*ConnectionStrings connect = new ConnectionStrings();
		ConnectionString strings = new ConnectionString();
		strings.name = "BaseDeTest";
		strings.url = "jdbc:oracle:thin:@adresseIP:port:nomBase";
		strings.user = "test";
		strings.password = "test";
		strings.providerName = "oracle.jdbc.driver.OracleDriver";
		connect.connectionString = strings;
		JAXBContext context = JAXBContext.newInstance(ConnectionStrings.class);
	    Marshaller mar= context.createMarshaller();
	    mar.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, Boolean.TRUE);
	    mar.marshal(connect, new File("./src/main/resources/Avsoft/Bdd/Config/ConnectionStrings.config"));
	    mar.marshal(connect, new File("./ConnectionStrings.config"));*/
	    //TEST RECUPERATION XML
	    ConfigManager test = ConfigManager.getInstance();
	    ConnectionStrings connect = test.getConnectionStrings();
	    System.out.println(connect.connectionString.providerName);
	}
}
