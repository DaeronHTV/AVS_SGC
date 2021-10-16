package dedalus.core.helper.logs.config;

import java.io.File;
import java.io.IOException;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;

import dedalus.core.manager.config.ConfigManager;

@SuppressWarnings("unused")
public class GenerateXml {

	public static void main(String[] args) throws JAXBException, IOException {
		/*Logs logs = new Logs();
		logs.File = new FileElement();
		logs.Archive = new ArchiveElement();
		//Setup Balise File
		logs.File.ActivateElement = true;
		logs.File.FilePathElement = "C:\\Users\\IM2AG\\Desktop";
		logs.File.Extension = "log";
		logs.File.SizeMaxElement = new ValueUnit();
		logs.File.SizeMaxElement.unit = "Mo";
		logs.File.SizeMaxElement.value = 10;
		logs.File.SuffixNameElement = "_taceTest";
		//Setup Balise Archive
		logs.Archive.ArchivePathElement = "C:\\Users\\IM2AG\\Desktop";
		logs.Archive.DelaiPurge = new ValueUnit();
		logs.Archive.DelaiPurge.unit = "Jours";
		logs.Archive.DelaiPurge.value = 30;
		//Serialisation du fichier
		JAXBContext context = JAXBContext.newInstance(Logs.class);
	    Marshaller mar= context.createMarshaller();
	    mar.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, Boolean.TRUE);
	    mar.marshal(logs, new File("./src/main/resources/Avsoft/Helper/Logs/Config/Logs.config"));
	    mar.marshal(logs, new File("./Logs.config"));*/
		ConfigManager test = ConfigManager.getInstance();
		Logs configLogs = test.getConfigLogs();
		System.out.println(configLogs.Archive.ActivateElement);
	}

}
