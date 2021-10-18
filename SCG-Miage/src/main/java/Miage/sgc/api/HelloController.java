package Miage.sgc.api;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HelloController {

	@RequestMapping(method = RequestMethod.GET, value = "/api/javainuse")
	public String sayHello() {
		return "Swagger Hello World";
	}
	
	@RequestMapping(method = RequestMethod.GET, value = "/api/javainuse/coucou")
	public String sayGoodBye() {
		return "Swagger says ggod bye";
	}
}
