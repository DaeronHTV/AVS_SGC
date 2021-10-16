package dedalus.core.helper.logs;

import dedalus.core.patrons.enumeration.IEnum;

public interface ILogLevel extends IEnum<ILogLevel> {
	String getCode();
}
