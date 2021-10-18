package Miage.sgc.api;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

/**
 * Controller permettant d'avoir l'ensemble des informations
 * sur l'api en cours d'utilisation
 * @author Avanzino.A
 * @since 18/10/2021
 * @version 1.0
 */
@RestController
public class ApiController {
	@RequestMapping(method = RequestMethod.GET, value = "/api/sgc/infos/version")
	public String getVersion() { return "1.0"; }
}
