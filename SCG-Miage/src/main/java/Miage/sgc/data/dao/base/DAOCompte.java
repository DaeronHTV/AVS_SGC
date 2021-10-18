package Miage.sgc.data.dao.base;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import Miage.core.helper.StringHelper;
import Miage.core.GeneratePassword;
import Miage.database.ConnectionBuilder;
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
	
	public DAOCompte(IDBConnection connection) { super(connection); setTable("COMPTE"); }
	
	@Override
	public Compte setObjectResult(ResultSet resultSet) throws SQLException {
		Compte result = ObjectBuilder.createBaseAccount(resultSet.getString("EMPLOYEID"), resultSet.getString("MAIL"),
    			TypeCompte.fromValue(resultSet.getString("TYPECOMPTE")));
		result.setId(resultSet.getString("ID"));
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
		// TODO Auto-generated method stub
		return false;
	}
}
