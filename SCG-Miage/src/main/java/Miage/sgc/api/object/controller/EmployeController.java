package Miage.sgc.api.object.controller;

import java.util.List;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;
import Miage.sgc.api.object.request.EmployeRequest;
import Miage.sgc.data.dao.DAOBuilder;
import Miage.sgc.data.dao.base.DAOEmploye;
import Miage.sgc.data.object.base.Employe;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;

@RestController
@Api(value="Controller which allows to manipulate the date of ")
public class EmployeController {
	
	@ApiOperation(value="Mets a jour les informations d'un emploi")
	@RequestMapping(method=RequestMethod.POST, value="/api/sgc/employe/update")
	public boolean updateEmploye(@RequestBody Employe employe) {
		DAOEmploye dao = DAOBuilder.DAOEmploye();
		return dao.update(employe);
	}
	
	@ApiOperation(value="Creer un nouvel employe dans la base de donnees")
	@RequestMapping(method=RequestMethod.PUT, value="/api/sgc/employe/create")
	public boolean createEmploye(@RequestBody Employe employe) {
		DAOEmploye dao = DAOBuilder.DAOEmploye();
		return dao.create(employe);
	}
	
	@ApiOperation(value="Retourne l'employe associe a l'id donne")
	@RequestMapping(method=RequestMethod.GET, value="/api/sgc/employe?Id={id}")
	public Employe getEmploye(@PathVariable String id) {
		DAOEmploye dao = DAOBuilder.DAOEmploye();
		return dao.read(id);
	}
	
	@ApiOperation(value="Retourne l'ensemble des employes present dans la base de donnees")
	@RequestMapping(method=RequestMethod.GET, value="/api/sgc/employe/all")
	public List<Employe> getAllEmploye(){
		DAOEmploye dao = DAOBuilder.DAOEmploye();
		return dao.readAll();
	}
	
	@ApiOperation(value="")
	@RequestMapping(method=RequestMethod.GET, value="/api/sgc/employe/query")
	public List<Employe> getEmploiByQuery(@RequestBody EmployeRequest query){
		return null; //TODO
	}
	
	@ApiOperation(value="")
	@RequestMapping(method=RequestMethod.DELETE, value="/api/sgc/employe/delete?Id={id}")
	public boolean deleteEmploye(@PathVariable String id) {
		return false; //TODO
	}
}
