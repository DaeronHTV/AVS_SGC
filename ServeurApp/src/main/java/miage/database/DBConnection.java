package Miage.database;

import java.sql.Connection;

public class DBConnection implements IDBConnection{
	private DBTypeEnum typeBase;
	private Connection connection;
	
	public DBConnection(Connection connection, String provider) {
		this.connection = connection;
	}

	@Override
	public DBTypeEnum getConnectionType() {
		return typeBase;
	}

	@Override
	public Connection getConnection() {
		return connection;
	}

}
