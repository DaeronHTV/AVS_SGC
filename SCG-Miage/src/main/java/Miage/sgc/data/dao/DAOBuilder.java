package Miage.sgc.data.dao;

import Miage.core.helper.logs.LogHelper;
import Miage.database.ConnectionBuilder;
import Miage.database.IDBConnection;
import Miage.sgc.data.dao.base.DAOCompte;

public class DAOBuilder {
	private static IDBConnection connection;
	
	static {
		LogHelper.info("Connexion a la base de donnees...");
		connection = ConnectionBuilder.ConnectionFromConfig();
	}
	
	public static DAOCompte CompteDAO() { return new DAOCompte(connection); }
}
