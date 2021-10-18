package Miage.sgc.data.dao;

import Miage.database.ConnectionBuilder;
import Miage.database.IDBConnection;

public class DAOBuilder {
	private static IDBConnection connection;
	
	static { connection = ConnectionBuilder.ConnectionFromConfig(); }
}
