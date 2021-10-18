package dedalus.sgc;

import java.sql.Connection;
import java.sql.SQLException;
import javax.xml.bind.JAXBException;
import dedalus.core.config.ServerConfig;
import dedalus.database.ConnectionBuilder;
import dedalus.database.IDBConnection;
import dedalus.sgc.data.dao.base.DAOCompte;
import dedalus.sgc.data.enumeration.TypeCompte;
import dedalus.sgc.data.object.base.Compte;
import dedalus.sgc.data.object.base.ObjectBuilder;

@SuppressWarnings("unused")
public class TestConnection {
	public static void main(String[] args) throws JAXBException, SQLException {
		IDBConnection test = ConnectionBuilder.ConnectionFromConfig();
		Connection connection = test.getConnection();
		DAOCompte compte = new DAOCompte(test);
		//Compte compte1 = ObjectBuilder.createBaseAccount("8cb55f6a-d498-4785-a34e-2474854d2e01", "test@test.com", TypeCompte.MEMBRE);
		//compte.create(compte1);
		Compte compte2 = compte.read("b7f3f1db-4d52-498e-bf55-f67390ad2622");
		//compte1.setId("2ba43dc6-d1a9-4b19-9825-0e90b527ab48");
		//compte.delete(compte1);
		System.out.println(compte2.getId());
		System.out.println(compte2.getTypeCompte());
	}
}
