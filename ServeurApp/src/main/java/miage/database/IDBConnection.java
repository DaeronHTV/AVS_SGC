package Miage.database;

import java.sql.Connection;

public interface IDBConnection {
	DBTypeEnum getConnectionType();
	
	Connection getConnection();
}
