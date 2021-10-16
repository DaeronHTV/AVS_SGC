package dedalus.core.helper.logs.config;

import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;

@XmlRootElement(name="Logs")
@XmlType(name="Logs", propOrder = {"File", "Archive"})
public class Logs {
	@XmlElementRef(name = "File")
	public FileElement File;
	@XmlElementRef(name = "Archive")
	public ArchiveElement Archive;
}
