package Miage.sgc.data.dao.base;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import Miage.core.helper.StringHelper;
import Miage.core.helper.TimeHelper;
import Miage.core.GeneratePassword;
import Miage.database.ConnectionBuilder;
import Miage.database.DBTypeEnum;
import Miage.database.IDBConnection;
import Miage.sgc.data.dao.DAOCommun;
import Miage.sgc.data.enumeration.TypeCompte;
import Miage.sgc.data.object.base.Compte;
import Miage.sgc.data.object.base.ObjectBuilder;

/**
 * Cette classe permet de faire le lien entre la base de donnees
 * et l'objet Compte courant present dans le serveur
 * @implSpec C'est ici qu'on generera le nouvel Id lors de
 * la creation d'un compte
 * @author Avanzino.A
 * @since 16/10/2021
 * @version 1.0
 */
public class DAOCompte extends DAOCommun<Compte>{
	private static final String Colums = "(ID,EMPLOYEID,MAIL,PASSWORD,TYPECOMPTE)";
	private static final String Values = "(?,?,?,?,?)";
	private static final String updateValues = "EMPLOYEID=?,MAIL=?,PASSWORD=?,TYPECOMPTE=?,DATEMAJ=?";
	
	public DAOCompte(IDBConnection connection) { super(connection); setTable("COMPTE"); }
	
	@Override
	public Compte setObjectResult(ResultSet resultSet) throws SQLException {
		Compte result = ObjectBuilder.createAccount(resultSet.getString("ID"),resultSet.getString("EMPLOYEID"), 
				resultSet.getString("MAIL"), resultSet.getString("PASSWORD"), TypeCompte.fromValue(resultSet.getString("TYPECOMPTE")));
		if(connection.getConnectionType() == DBTypeEnum.SQLITE) {
			if(!StringHelper.IsNullOrEmpty(resultSet.getString("DATEMAJ"))) {
				result.setDateMaj(TimeHelper.stringToSqlDate(resultSet.getString("DATEMAJ")));
			}
			result.setDateInsertion(TimeHelper.stringToSqlDate(resultSet.getString("DATEINSERTION")));
		}
		else {
			result.setDateMaj(resultSet.getDate("DATEMAJ"));
			result.setDateInsertion(resultSet.getDate("DATEINSERTION"));
		}
		return result;
	}

	@Override
	public boolean create(Compte obj) {
		try {
			String query = StringHelper.Format(INSERT, getTable(), Colums, Values);
			PreparedStatement ps = connection.getConnection().prepareStatement(query);
			ps.setString(1, ConnectionBuilder.GUID(connection));
			ps.setString(2, obj.getEmployeId());
			ps.setString(3, obj.getMail());
			ps.setString(4, GeneratePassword.hardPassword(6));
			ps.setString(5, obj.getTypeCompte().getCode());
			ps.executeUpdate();
	        ps.close();
		}
		catch(SQLException sqle) { sqle.printStackTrace(); return false;}
		return true;
	}

	@Override
	public boolean update(Compte obj) {
		try {
			String query = StringHelper.Format(UPDATE, getTable(), updateValues);
			PreparedStatement ps = connection.getConnection().prepareStatement(query);
			ps.setString(1, obj.getEmployeId());
			ps.setString(2, obj.getMail());
			ps.setString(3, obj.getPassword());
			ps.setString(4, obj.getTypeCompte().getCode());
			if(connection.getConnectionType() == DBTypeEnum.SQLITE) ps.setString(5, TimeHelper.Now());
			else ps.setDate(5, java.sql.Date.valueOf(java.time.LocalDate.now()));
			ps.setString(6, obj.getId());
			ps.executeUpdate();
	        ps.close();
		} 
		catch (SQLException sqle) { sqle.printStackTrace(); return false; }
		return true;
	}
}
