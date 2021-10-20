package Miage.sgc.data.dao;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

import Miage.sgc.data.object.BaseObject;

public interface IDAO<T extends BaseObject> {
	static String INSERT = "INSERT INTO {0} {1} VALUES {2}";
    static String UPDATE = "UPDATE {0} SET {1} WHERE ID=?";
    static String UPDATE_QUERY = "UPDATE {0} SET {1} WHERE {3}";
    static String DELETE = "DELETE FROM {0} WHERE ID=?";
    static String DELETE_QUERY = "DELETE FROM {0} WHERE {1}";
    static String SELECT = "SELECT * FROM {0} WHERE ID=?";
    static String SELECT_QUERY = "SELECT * FROM {0} WHERE {1}";
    static String SELECTALL = "SELECT * FROM ";

    /**
     * 
     * @param obj l'objet à créer
     * @return True si la création c'est bien passé, false sinon
     */
    boolean create(T obj);

    /**
     * 
     * @param id
     * @return
     */
    T read(String id);
    
    //List<T> readQuery(); TODO
    
    List<T> readAll();

    boolean update(T obj);
    
    //boolean updateQuery(); TODO

    /**
     * 
     * @param id
     * @return
     */
    boolean delete(String id);
    
    //boolean deleteQuery(); TODO
    
    T setObjectResult(ResultSet resultSet) throws SQLException;
}