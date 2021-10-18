package Miage.sgc.data.dao;

import java.sql.ResultSet;
import java.sql.SQLException;
import Miage.sgc.data.object.BaseObject;

public interface IDAO<T extends BaseObject> {
	static String INSERT = "INSERT INTO {0} {1} VALUES {2}";
    static String UPDATE = "UPDATE {0} SET {1}";
    static String DELETE = "DELETE FROM {0} WHERE ID=?";
    static String SELECT = "SELECT * FROM {0} WHERE ID=?";
    static String SELECTALL = "SELECT * FROM ";

    boolean create(T obj);

    T read(String id);

    boolean update(T obj);

    boolean delete(T obj);
    
    T setObjectResult(ResultSet resultSet) throws SQLException;
}