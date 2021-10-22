package Miage.sgc.data.dao.base;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import Miage.core.helper.StringHelper;
import Miage.core.helper.TimeHelper;
import Miage.database.ConnectionBuilder;
import Miage.database.DBTypeEnum;
import Miage.database.IDBConnection;
import Miage.sgc.data.dao.DAOCommun;
import Miage.sgc.data.object.base.Employe;
import Miage.sgc.data.object.base.ObjectBuilder;

public class DAOEmploye extends DAOCommun<Employe>{
	private static final String Colums = "(ID,CODE,PRENOM,NOM,TELEPHONE,MAIL,PRENOMASCII,NOMASCII)";
	private static final String Values = "(?,?,?,?,?,?,?,?)";
	private static final String updateValues = "CODE=?,PRENOM=?,NOM=?,TELEPHONE=?,MAIL=?,PRENOMASCII=?,NOMASCII=?,DATEMAJ=?";

	public DAOEmploye(IDBConnection connection) { super(connection); setTable("EMPLOYE"); }

	@Override
	public Employe setObjectResult(ResultSet resultSet) throws SQLException {
		Employe result = ObjectBuilder.createEmploye(resultSet.getString("ID"), resultSet.getString("CODE"),
				resultSet.getString("PRENOM"), resultSet.getString("NOM"), resultSet.getString("TELEPHONE"), 
				resultSet.getString("MAIL"));
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
	public boolean create(Employe obj) {
		try {
			String query = StringHelper.Format(INSERT, getTable(), Colums, Values);
			PreparedStatement ps = connection.getConnection().prepareStatement(query);
			ps.setString(1, ConnectionBuilder.GUID(connection));
			ps.setString(2, obj.getCode());
			ps.setString(3, obj.getPrenom());
			ps.setString(4, obj.getNom());
			ps.setString(5, obj.getTelephone());
			ps.setString(6, obj.getMail());
			ps.setString(7, obj.getPrenomASCII());
			ps.setString(8, obj.getNomASCII());
			ps.executeUpdate();
			ps.close();
		}
		catch(SQLException sqle) { sqle.printStackTrace(); return false; }
		return true;
	}

	@Override
	public boolean update(Employe obj) {
		try {
			String query = StringHelper.Format(UPDATE, getTable(), updateValues);
			PreparedStatement ps = connection.getConnection().prepareStatement(query);
			ps.setString(1, obj.getCode());
			ps.setString(2, obj.getPrenom());
			ps.setString(3, obj.getNom());
			ps.setString(4, obj.getTelephone());
			ps.setString(5, obj.getMail());
			ps.setString(6, obj.getPrenomASCII());
			ps.setString(7, obj.getNomASCII());
			if(connection.getConnectionType() == DBTypeEnum.SQLITE) ps.setString(8, TimeHelper.Now());
			else ps.setDate(8, java.sql.Date.valueOf(java.time.LocalDate.now()));
			ps.setString(9, obj.getId());
			ps.executeUpdate();
			ps.close();
		}
		catch(SQLException sqle) { sqle.printStackTrace(); return false; }		
		return true;
	}
}
