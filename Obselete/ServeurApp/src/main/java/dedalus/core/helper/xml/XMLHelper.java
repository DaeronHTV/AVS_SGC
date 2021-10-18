package dedalus.core.helper.xml;

import java.beans.XMLDecoder;
import java.beans.XMLEncoder;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.StringWriter;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import dedalus.core.helper.logs.LogHelper;

public class XMLHelper {
	/**
	 * R�cup�re le fichier XML et extrait son contenu sous la forme d'un objet XML
	 * parseable
	 * @param filepath Le chemin du fichier XML
	 * @return Le document repr�sentant le XML du fichier
	 * @since 27/01/2021
	 */
	public static Document getXmlDocument(String filepath) {
		try {
			DocumentBuilder builder = DocumentBuilderFactory.newInstance().newDocumentBuilder();
			return builder.parse(new File(filepath));
		} 
		catch (Exception e) { 
			LogHelper.error(e); 
			return null;
		}
	}
	
	public static Document emptyDocument() {
		try { return DocumentBuilderFactory.newInstance().newDocumentBuilder().newDocument(); }
		catch(ParserConfigurationException pce) {
			LogHelper.error("Erreur lors de la creation du document !", pce);
			return null;
		}
	}

	/**
	 * Enregistre dans un String l'arborescence enti�re du document XML donn�e en
	 * param�tre
	 * @return Le contenu entier du Document XML
	 * @since 30/01/2021
	 */
	public static String XmlToString(Document xmlDocument) {
		return XmlToString(xmlDocument, "UTF-8");
	}
	
	public static String XmlToString(Document xmlDocument, String encoding) {
		String result = null;
		try {
			Transformer transformer = TransformerFactory.newInstance().newTransformer();
			transformer.setOutputProperty("encoding", encoding);
			StringWriter writer = new StringWriter();
			transformer.transform(new DOMSource(xmlDocument), new StreamResult(writer));
			result = writer.getBuffer().toString();
		} catch (Exception e) {
			LogHelper.error(e);
		}
		return result;
	}

	@Deprecated
	public static Element getRootElement(String filepath) {
		DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
		try {
			DocumentBuilder builder = factory.newDocumentBuilder();
			Document xml = builder.parse(new File(filepath));
			return xml.getDocumentElement();
		} 
		catch (Exception e) { 
			LogHelper.error(e); 
			return null;
		}
	}

	/**
	 * Serialise un objet java dans un fichier XML
	 * 
	 * @param object   L'objet � encoder dans le fichier XML
	 * @param fileName Le path ou le fichier va �tre enregistr�
	 * @throws FileNotFoundException - Si le fichier n'est pas trouv�
	 * @throws IOException           - Lors d'un probl�me d'�criture de l'objet
	 * @since 25/01/2021
	 */
	public static void encodeToFile(Object object, String fileName) throws FileNotFoundException, IOException {
		XMLEncoder encoder = new XMLEncoder(new FileOutputStream(fileName));
		try {
			encoder.writeObject(object);
			encoder.flush();
		} 
		catch (Exception e) { LogHelper.error(e); } 
		finally { encoder.close(); }
	}

	/**
	 * R�cup�rer les donn�es d'un objet JAVA dans un fichier XML
	 * @param fileName Le path du fichier � serialiser
	 * @return L'objet se trouvant dans le fichier XML donn�
	 * @throws FileNotFoundException - Si le fichier n'est pas trouv�
	 * @throws IOException           - Si il y a probl�me lors de la lecture
	 */
	public static Object decodeFromFile(String fileName) throws FileNotFoundException, IOException {
		Object object = null;
		XMLDecoder decoder = new XMLDecoder(new FileInputStream(fileName));
		try { object = decoder.readObject(); } 
		catch (Exception e) { LogHelper.error(e); } 
		finally { decoder.close(); }
		return object;
	}
}
