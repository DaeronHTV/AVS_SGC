package Miage.core.helper.logs.config;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlRootElement(name = "Archive")
public class ArchiveElement {
	@XmlElement(name="Path")
	public String ArchivePathElement;
	@XmlElement(name="Activate")
	public boolean ActivateElement;
	@XmlElement(name = "DelaiPurge")
	public ValueUnit DelaiPurge;
}
