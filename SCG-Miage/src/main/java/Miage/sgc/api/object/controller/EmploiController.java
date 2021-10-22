package Miage.sgc.api.object.controller;

import java.util.List;

import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;
import Miage.sgc.api.object.request.EmploiRequest;
import Miage.sgc.data.object.base.Emploi;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;

@RestController
@Api(value="Controller which allows to manipulate the date of ")
public class EmploiController {
	
	@ApiOperation(value="Mets a jour les informations d'un emploi")
	@RequestMapping(method=RequestMethod.POST, value="/api/sgc/emploi/update")
	public boolean updateEmploi(@RequestBody Emploi emploi) {
		return false; // TODO
	}
	
	@ApiOperation(value="")
	@RequestMapping(method=RequestMethod.PUT, value="/api/sgc/emploi/create")
	public boolean createEmploi(@RequestBody Emploi emploi) {
		return false; //TODO
	}
	
	@ApiOperation(value="")
	@RequestMapping(method=RequestMethod.GET, value="/api/sgc/emploi?Id={id}")
	public Emploi getEmploi(@PathVariable String id) {
		return null; //TODO
	}
	
	@ApiOperation(value="")
	@RequestMapping(method=RequestMethod.GET, value="/api/sgc/emploi/all")
	public List<Emploi> getAllEmploi(){
		return null; //TODO
	}
	
	@ApiOperation(value="")
	@RequestMapping(method=RequestMethod.GET, value="/api/sgc/emploi/query")
	public List<Emploi> getEmploiByQuery(@RequestBody EmploiRequest query){
		return null; //TODO
	}
	
	@ApiOperation(value="")
	@RequestMapping(method=RequestMethod.DELETE, value="/api/sgc/emploi/delete?Id={id}")
	public boolean deleteEmploi(@PathVariable String id) {
		return false; //TODO
	}
}
