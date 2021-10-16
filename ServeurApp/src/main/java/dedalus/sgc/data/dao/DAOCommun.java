package dedalus.sgc.data.dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import Avsoft.Helper.StringHelper;
import Avsoft.Helper.Logs.LogHelper;
import dedalus.database.IDBConnection;
import dedalus.sgc.data.object.BaseObject;

public abstract class DAOCommun<T extends BaseObject> implements IDAO<T>{
	protected IDBConnection connection;
	private String Table;
	
	public DAOCommun(IDBConnection connection) { this.connection = connection; }
	
	public abstract T setObjectResult(ResultSet resultSet) throws SQLException;

	public abstract boolean create(T obj);
	
	public abstract boolean update(T obj);
	
	public String getTable() { return Table; }
	
	protected void setTable(String Table) { this.Table = Table; }

	public T read(String id) {
		T bo = null;
        try 
        {
            PreparedStatement ps = connection.getConnection().prepareStatement(StringHelper.Format(SELECT, getTable()));
            ps.setString(1, id);
            ResultSet resultSet = ps.executeQuery();
            if (resultSet.next()) bo = setObjectResult(resultSet);
            resultSet.close(); ps.close();
        } 
        catch (SQLException e) { LogHelper.error(e); }
        return bo;
	}
	
	public boolean delete(T obj) {
		try {
			String requete = StringHelper.Format(DELETE, Table);
			PreparedStatement ps = connection.getConnection().prepareStatement(requete);
	        ps.setString(1, obj.getId());
	        ps.executeUpdate();
	        ps.close();
	    } 
		catch (SQLException e) { LogHelper.error(e); return false; }
		return true;
	}
}
