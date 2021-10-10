package Miage.sgc;

import java.sql.Connection;
import java.sql.SQLException;
import javax.xml.bind.JAXBException;
import Miage.database.ConnectionBuilder;
import Miage.database.IDBConnection;


public class TestConnection {

	public static void main(String[] args) throws JAXBException, SQLException {
		IDBConnection test = ConnectionBuilder.ConnectionFromConfig();
		Connection connection = test.getConnection();
		System.out.println(connection.getCatalog());
		
	}

}
