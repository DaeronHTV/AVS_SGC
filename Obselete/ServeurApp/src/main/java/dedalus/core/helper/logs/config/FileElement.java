package dedalus.core.helper.logs.config;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlAccessorType(XmlAccessType.FIELD)
@XmlRootElement(name = "File")
public class FileElement {
	@XmlElement(name = "SizeMax")
	public ValueUnit SizeMaxElement;
	@XmlElement(name="Extension")
	public String Extension;
	@XmlElement(name="SuffixName")
	public String SuffixNameElement;
	@XmlElement(name="Path")
	public String FilePathElement;
	@XmlElement(name="Activate")
	public boolean ActivateElement;
}
