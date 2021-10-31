package Miage.sgc.api;

import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;

/**
 * Controller permettant d'avoir l'ensemble des informations
 * sur l'api en cours d'utilisation
 * @author Avanzino.A
 * @since 18/10/2021
 * @version 1.0
 */
@RestController
//@CrossOrigin(origins = "http://localhost:4200")
@Api(value="Controller permettant d'avoir l'ensembe des informations sur l'api en cours d'utilisation")
public class ApiController {
	@ApiOperation(value="Retourne la version actuelle de l'api")
	@RequestMapping(method = RequestMethod.GET, value = "/api/infos/version")
	public String getVersion() { return "1.0"; }
	
	@ApiOperation(value="Retourne le système actuel java utilise pour le serveur")
	@RequestMapping(method=RequestMethod.GET, value="/api/infos/javaVersion")
	public String getJavaVersion() { return System.getProperty("JAVA_HOME"); }
}
