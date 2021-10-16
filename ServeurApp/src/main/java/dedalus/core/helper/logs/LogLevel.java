package dedalus.core.helper.logs;

import dedalus.core.helper.GenericMethodHelper;

public enum LogLevel implements ILogLevel{
	INFO("INFO"), ERROR("ERROR"), WARNING("WARNING"), DEBUG("DEBUG");

	private String code;

	LogLevel(String code) {
		this.code = code;
	}

	public String getCode() {
		return code;
	}
	
	public static LogLevel fromValue(String v) {
        return GenericMethodHelper.<LogLevel>fromValue(v, LogLevel.values());
    }
}
