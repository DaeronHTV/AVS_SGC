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
import Miage.sgc.data.object.base.Emploi;
import Miage.sgc.data.object.base.ObjectBuilder;

public class DAOEmploi extends DAOCommun<Emploi>{
	private static final String Columns = "(ID,CODE,LIBELLE,DESCRIPTION)";
	private static final String Values = "(?,?,?,?)";
	private static final String updateValues = "CODE=?,LIBELLE=?,DESCRIPTION=?";

	public DAOEmploi(IDBConnection connection) { super(connection); setTable("EMPLOI"); }

	@Override
	public Emploi setObjectResult(ResultSet resultSet) throws SQLException {
		Emploi result = ObjectBuilder.createEmploi(resultSet.getString("ID"), resultSet.getString("CODE"),
				resultSet.getString("LIBELLE"), resultSet.getString("DESCRITPION"));
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
	public boolean create(Emploi obj) {
		try {
			String query = StringHelper.Format(INSERT, getTable(), Columns, Values);
			PreparedStatement ps = connection.getConnection().prepareStatement(query);
			ps.setString(1, ConnectionBuilder.GUID(connection));
			ps.setString(2, obj.getCode());
			ps.setString(3, obj.getLibelle());
			ps.setString(4, obj.getDescription());
			ps.executeUpdate();
			ps.close();
		}
		catch(SQLException sqle) { sqle.printStackTrace(); return false; }
		return true;
	}

	@Override
	public boolean update(Emploi obj) {
		try {
			String query = StringHelper.Format(UPDATE, getTable(), updateValues);
			PreparedStatement ps = connection.getConnection().prepareStatement(query);
			ps.setString(1, obj.getCode());
			ps.setString(2, obj.getLibelle());
			ps.setString(3, obj.getDescription());
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
