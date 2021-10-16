package dedalus.database;

import java.sql.Connection;

public class DBConnection implements IDBConnection{
	private DBTypeEnum typeBase;
	private Connection connection;
	
	public DBConnection(Connection connection, String provider) {
		this.connection = connection;
		this.typeBase = DBTypeEnum.fromProvider(provider);
	}

	@Override
	public DBTypeEnum getConnectionType() { return typeBase; }

	@Override
	public Connection getConnection() { return connection; }
}
