package dedalus.sgc.data.dao;

import dedalus.database.ConnectionBuilder;
import dedalus.database.IDBConnection;

public class DAOBuilder {
	private static IDBConnection connection;
	
	static { connection = ConnectionBuilder.ConnectionFromConfig(); }
}
