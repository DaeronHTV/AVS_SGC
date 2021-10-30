package Miage.sgc.api.object.controller;

import java.util.List;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;
import Miage.sgc.api.object.request.CompteRequest;
import Miage.sgc.data.dao.DAOBuilder;
import Miage.sgc.data.dao.base.DAOCompte;
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
	public boolean updateAccount(@RequestBody Compte compte) {
		DAOCompte dao = DAOBuilder.CompteDAO();
		return dao.update(compte);
	}
	
	@ApiOperation(value="Creer un nouveau dans la base de donnees")
	@RequestMapping(method = RequestMethod.PUT, value = "/api/sgc/compte/create")
	public boolean createAccount(@RequestBody(required=false) Compte compte) {
		DAOCompte dao = DAOBuilder.CompteDAO();
		return dao.create(compte);
	}
	
	@ApiOperation(value="Retourne le compte avec associe a l'id")
	@RequestMapping(method=RequestMethod.GET, value="/api/sgc/compte/{id}")
	public Compte getAccount(@PathVariable String id) {
		DAOCompte dao = DAOBuilder.CompteDAO();
		Compte result = dao.read(id);
		return result;
	}
	
	@ApiOperation(value="Retourne l'ensemble des comptes presents en base de donnees")
	@RequestMapping(method=RequestMethod.GET, value="/api/sgc/compte/all")
	public List<Compte> getAllAccount(){
		DAOCompte dao = DAOBuilder.CompteDAO();
		return dao.readAll();
	}
	
	@ApiOperation(value="Retourne une liste de compte en fonction de parametre")
	@RequestMapping(method=RequestMethod.GET, value="/api/sgc/compte/query")
	public List<Compte> getCompteByQuery(@RequestBody CompteRequest query){
		return null; // TODO
	}
	
	@ApiOperation(value="Supprimer un compte de la base")
	@RequestMapping(method=RequestMethod.DELETE, value="/api/sgc/compte/delete/{id}")
	public boolean deleteCompteById(@PathVariable String id) {
		DAOCompte dao = DAOBuilder.CompteDAO();
		return dao.delete(id);
	}
}
