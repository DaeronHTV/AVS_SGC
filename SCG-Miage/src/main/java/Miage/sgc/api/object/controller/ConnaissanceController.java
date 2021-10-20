package Miage.sgc.api.object.controller;

import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;
import Miage.sgc.data.object.base.Connaissance;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;

@RestController
@Api(value="Controller which allows to manipulate the data of knowledge in database")
public class ConnaissanceController {
	
	@ApiOperation(value="Mets a jour les informations d'une connaissance")
	@RequestMapping(method = RequestMethod.POST, value="/api/sgc/knowledge/update")
	public boolean updateConnaissance(@RequestBody Connaissance connaissance) {
		return false; // TODO
	}
	
	@ApiOperation(value="Creer une nouvelle connaissance dans la base de donnees")
	@RequestMapping(method=RequestMethod.PUT, value="api/sgc/knowledge/create")
	public boolean createConnaissance(@RequestBody Connaissance connaissance) {
		return false; // TODO
	}
	
	@ApiOperation(value="Retourne la connaissance associee a l'id")
	@RequestMapping(method=RequestMethod.GET, value="api/sgc/knowledge/{id}")
	public Connaissance getConnaissance(@PathVariable String id) {
		return null; // TODO
	}

}