package Miage.core.helper;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.time.Instant;
import java.util.Date;

/**
 * 
 * @author Avanzino.A
 * @author Avsoft Studio
 * @since 1.0
 */
public class TimeHelper {
	private static Date currentDeviceDate = new Date();
	
	/**
	 * Get the current date and time from the devices used
	 * @return the current date and time into the format YYYY/MM/DD HH:MM:SS
	 * @since 1.0
	 */
	public static String Now() {
		DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
		return dateFormat.format(Date.from(Instant.now()));
	}
	
	public static String Now(String format) {
		DateFormat dateFormat = new SimpleDateFormat(format);
		return dateFormat.format(Date.from(Instant.now()));
	}
	
	public static String Now(DateFormat dateFormat) {
		return dateFormat.format(Date.from(Instant.now()));
	}
	
	public static java.sql.Date stringToSqlDate(String date) {
		if (date == null) { return null; }
	    java.sql.Date d = null;
	    int firstDash = date.indexOf('-');
	    int secondDash = date.indexOf('-', firstDash + 1);
	    int len = date.length();
	    if ((firstDash > 0) && (secondDash > 0) && (secondDash < len - 1)) {
	    	int year = Integer.parseInt(date, 0, firstDash, 10);
	        int month = Integer.parseInt(date, firstDash + 1, secondDash, 10);
	        int day = Integer.parseInt(date, secondDash + 1, 10, 10);
	        if ((month >= 1 && month <= 12) && (day >= 1 && day <= 31)) {
	        	d = new java.sql.Date(year - 1900, month - 1, day);
	        }
	    }
	    return d;
	}
	
	public static String SqlDateToString(java.sql.Date date) {
		DateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
		return dateFormat.format(date);
	}
}
