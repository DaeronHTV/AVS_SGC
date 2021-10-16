package dedalus.database;

import Avsoft.Helper.GenericMethodHelper;
import Avsoft.Patrons.Enumeration.IBaseEnum;

public enum DBTypeEnum implements IBaseEnum{
	ORACLE("oracle", "oracle.jdbc.driver.OracleDriver", ":"),
	MSSQL("mssql", "", "@"),
	MARIA("mariadb", "org.mariadb.jdbc.Driver", "@"),
	MONGO("mongodb", "com.mongodb.jdbc.MongoDriver", ""),
	MYSQL("mysql", "com.mysql.jdbc.Driver", "@"),
	SQLITE("Sqlite", "org.sqlite.JDBC", ":"),
	POSTGRE("postgresql", "org.postgresql.Driver", ":");
	
	private String symbol;
	private String code;
	private String providerClass;
	
	DBTypeEnum(String code, String providerClass, String symbol){
		this.code = code;
		this.providerClass = providerClass;
	}
	
	@Override
	public String getCode() {
		return code;
	}
	
	public String getProvider() {
		return providerClass;
	}
	
	public String getSymbol() {
		return symbol;
	}
	
	public static DBTypeEnum fromValue(String v) {
        return GenericMethodHelper.<DBTypeEnum>fromValue(v, DBTypeEnum.values());
    }
	
	public static DBTypeEnum fromProvider(String v) {
		for(DBTypeEnum type: DBTypeEnum.values()) {
			if(type.providerClass.equals(v)) return type; 
		}
		return null;
	}
}
