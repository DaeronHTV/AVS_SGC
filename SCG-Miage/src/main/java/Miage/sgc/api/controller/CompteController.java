package Miage.sgc.api.controller;

import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import Miage.sgc.data.object.base.Compte;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;

/**
 * 
 * @author Avanzino.A
 *
 */
@RestController
@Api(value="Controller which allows to manipulate the data of account in database")
public class CompteController {
	
	@ApiOperation(value="Mets a jour les informations d'un compte")
	@RequestMapping(method = RequestMethod.POST, value = "/api/sgc/compte/update")
	public String updateAccount(@RequestBody Compte compte) { 
		return "1.0"; 
	}
	
	@ApiOperation(value="Creer un nouveau dans la base de donnees")
	@RequestMapping(method = RequestMethod.PUT, value = "/api/sgc/compte/create")
	public String createAccount(@RequestBody Compte compte) {
		return null;
	}
	
	@ApiOperation(value="Retourne le compte avec associe a l'id")
	@RequestMapping(method=RequestMethod.GET, value="/api/sgc/compte/{id}")
	public Compte getAccount(@PathVariable String id) {
		return null;
	}
	
	
}
