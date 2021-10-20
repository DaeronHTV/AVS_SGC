package Miage.sgc.data.dao;

import Miage.database.ConnectionBuilder;
import Miage.database.IDBConnection;
import Miage.sgc.data.dao.base.DAOCompte;

public class DAOBuilder {
	private static IDBConnection connection;
	
	static { connection = ConnectionBuilder.ConnectionFromConfig(); }
	
	public static DAOCompte createCompteDAO() { return new DAOCompte(connection); }
}
