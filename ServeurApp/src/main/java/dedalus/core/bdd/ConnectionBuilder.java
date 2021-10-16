package dedalus.core.bdd;

import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.SQLTimeoutException;
import dedalus.core.helper.logs.LogHelper;

import java.sql.Connection;

public class ConnectionBuilder {
	private static volatile ConnectionBuilder connection = null;
	private Connection instance = null;

	private ConnectionBuilder(String url, String user, String pwd) {
		try {
			instance = (Connection) DriverManager.getConnection(url, user, pwd);
		} catch (SQLTimeoutException sqlte) {
			LogHelper.error("Erreur lors de la connexion. La base de donnees a mis trop de temps a repondre", sqlte);
		} catch (SQLException e) {
			LogHelper.error("Erreur lors de la connexion a la base de donnees ! Verifier que vous avez renseigne une adresse correcte",e);
		}
	}

	public static ConnectionBuilder getInstance(String url, String user, String pwd) {
		if (ConnectionBuilder.connection == null) {
			synchronized (ConnectionBuilder.class) {
				if (ConnectionBuilder.connection == null) {
					connection = new ConnectionBuilder(url, user, pwd);
				}
			}
		}
		return connection;
	}

	public Connection getConnection() {
		return instance;
	}
}
