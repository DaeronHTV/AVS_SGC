package Miage.database;

import java.sql.DriverManager;
import java.sql.SQLException;
import javax.xml.bind.JAXBException;
import Avsoft.Helper.Logs.LogHelper;
import Avsoft.Manager.Config.ConfigManager;
import Avsoft.Bdd.Config.ConnectionString;
import java.sql.Connection;

public class ConnectionBuilder {
	private static ConfigManager config;

    static {
    	try { config = ConfigManager.getInstance(); } 
    	catch (JAXBException e) { LogHelper.error("Erreur durant la récupération de la config", e); }
    }
    
    public static IDBConnection ConnectionFromConfig() {
    	try {
    		ConnectionString strings = config.getConnectionStrings().connectionString;
    		LogHelper.info("Chargement du provider de la base...");
    		Class.forName(strings.providerName);
    		LogHelper.info("Creation de la connection a la base...");
    		return new DBConnection(getConnection(strings), strings.providerName);
    	}
    	catch(SQLException sqle) { LogHelper.error("Error lors de la connection a la base de donnees !", sqle); }
    	catch(ClassNotFoundException cnfe) { LogHelper.warning("Driver non supporte par l'application !", cnfe); }
    	return null;
    }
    
    private static Connection getConnection(ConnectionString config) throws SQLException {
    	DBTypeEnum typeConnection = DBTypeEnum.fromProvider(config.providerName);
    	if(typeConnection == DBTypeEnum.SQLITE || typeConnection == DBTypeEnum.MSSQL) {
    		return DriverManager.getConnection(config.url);
    	}
    	return DriverManager.getConnection(config.url, config.user, config.password);
    }    
    
    public static String TransformeRequete(IDBConnection connection, String requete) {
    	return null;
    }
    
    public static String TransformeRequete(String providerClass, String requete) {
    	return null;
    }
}
