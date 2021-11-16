package Miage.sgc.api.object.controller;

import java.util.List;

import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import Miage.sgc.api.object.request.ConnaissanceRequest;
import Miage.sgc.data.dao.DAOBuilder;
import Miage.sgc.data.dao.base.DAOConnaissance;
import Miage.sgc.data.object.base.Connaissance;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import io.swagger.annotations.ApiParam;
import io.swagger.annotations.ApiResponses;
import io.swagger.annotations.ApiResponse;

@RestController
@Api(value="Controller which allows to manipulate the data of knowledge in database")
public class ConnaissanceController {
	
	
	@ApiOperation(value="Mets a jour les informations d'une connaissance")
	@RequestMapping(method = RequestMethod.POST, value="api/sgc/knowledge/update")
	public boolean updateConnaissance(@RequestBody Connaissance connaissance) {
		return false; // TODO
	}
	
	@ApiOperation(value="Creer une nouvelle connaissance dans la base de donnees")
	@RequestMapping(method=RequestMethod.PUT, value="api/sgc/knowledge/create")
	public boolean createConnaissance(@RequestBody Connaissance connaissance) {
		return false; // TODO
	}
	
	@ApiOperation(value="Retourne la connaissance associee a l'id")
	@ApiResponses(value = {
			@ApiResponse(code=200, message="successful operation", response=Connaissance.class),
			@ApiResponse(code=400, message="The Id sent isn't correct"),
			@ApiResponse(code=404, message="Connaissance not found"),
			@ApiResponse(code=500, message="Internal Servor Error !")
	})
	@RequestMapping(method=RequestMethod.GET, value="api/sgc/knowledge/{id}")
	public Connaissance getConnaissance(@ApiParam(value="Id de la connaissance à récupérer", required=true) @PathVariable("id") String id) {
		DAOConnaissance dao = DAOBuilder.DAOConnaissance();
		return dao.read(id);
	}
	
	@ApiOperation(value="Retourne l'ensemble des connaissances disponible")
	@ApiResponses(value = {
			@ApiResponse(code=200, message="successful operation", response=List.class),
			@ApiResponse(code=404, message="List Connaissance not found"),
			@ApiResponse(code=500, message="Internal Servor Error !")
	})
	@RequestMapping(method=RequestMethod.GET, value="api/sgc/knowledge/all")
	public List<Connaissance> getAllConnaissance(){
		DAOConnaissance dao = DAOBuilder.DAOConnaissance();
		return dao.readAll();
	}
	
	@ApiOperation(value="Retourne un ensemble de connaissance en fonction de parametre de recherche")
	@RequestMapping(method=RequestMethod.GET, value="api/sgc/knowledge/query")
	public List<Connaissance> getConnaissanceByQuery(@RequestBody ConnaissanceRequest query){
		return null; //TODO
	}
	
	@ApiOperation(value="Supprime connaissance presente en base de donnees")
	@RequestMapping(method=RequestMethod.DELETE, value="api/sgc/knowledge/delete/{id}")
	public boolean deleteConnaissanceById(@PathVariable String id) {
		return false; //TODO
	}
}
