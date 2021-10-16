package dedalus.sgc.data.dao.base;

import java.sql.ResultSet;
import java.sql.SQLException;

import dedalus.database.IDBConnection;
import dedalus.sgc.data.dao.DAOCommun;
import dedalus.sgc.data.object.base.Connaissance;
import dedalus.sgc.data.object.base.ObjectBuilder;

public class DAOConnaissance extends DAOCommun<Connaissance>{
	
	public DAOConnaissance(IDBConnection connection) { super(connection); setTable("CONNAISSANCE"); }
	
	@Override
	public Connaissance setObjectResult(ResultSet resultSet) throws SQLException {
		Connaissance connaissance = ObjectBuilder.createConnaissance(resultSet.getString("CODE"), 
    			resultSet.getString("LIBELLE"), resultSet.getString("DESCRIPTION"));
    	connaissance.setId(resultSet.getString("ID"));
    	return connaissance;
	}

	@Override
	public boolean create(Connaissance obj) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean update(Connaissance obj) {
		// TODO Auto-generated method stub
		return false;
	}
}
