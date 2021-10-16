package dedalus.core.helper;

import java.io.File;
import java.util.List;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Unmarshaller;

public final class GenericMethodHelper {
	
	/**
	 * @implNote L'appel : EnumTools.<String>fromValue(strings, {mon tableau...})
	 */
	public static <T> T fromValue(String v, T[] valuesToCheck) {
        for (T c: valuesToCheck) {
            if (c.toString().equals(v)) return c;
        }
        return null;
    }
	
	public static <T> boolean tryParrallelProcess(List<T> list, java.util.function.Consumer<? super T> arg0) {
		list.parallelStream().forEach(arg0);
		return true;
	}
	
	@SuppressWarnings("unchecked")
	public static <T> T getJaxbObjectFromFile(String fileName, Class<T> classe) throws JAXBException {
		JAXBContext context = JAXBContext.newInstance(classe);
		Unmarshaller unmarshaller = context.createUnmarshaller();
		return (T)unmarshaller.unmarshal(new File(fileName));
	}
}
