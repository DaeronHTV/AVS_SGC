package dedalus.database;

import java.sql.Connection;

public interface IDBConnection {
	DBTypeEnum getConnectionType();
	
	Connection getConnection();
}
