package dedalus.core.helper.logs;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import javax.xml.bind.JAXBException;
import dedalus.core.helper.FileHelper;
import dedalus.core.helper.TimeHelper;
import dedalus.core.helper.logs.config.FileElement;
import dedalus.core.manager.config.ConfigManager;
import dedalus.core.teams.Couple;
import static dedalus.core.helper.StringHelper.getErrorMessage;
import static dedalus.core.helper.StringHelper.Concat;


public final class LogHelper {
	private static FileElement logsConfig;
	private static String filePathName;
	
	static {
		try { 
			logsConfig = ConfigManager.getInstance().getConfigLogs().File; 
			filePathName = logsConfig.FilePathElement + File.separatorChar + "testName" + "." + logsConfig.Extension;
		} 
		catch (JAXBException e) { e.printStackTrace(); }
	}
	
	/********************************************/
	/*ENSEMBLE DES FONCTIONS D'ECRITURE DES LOGS*/
	/********************************************/	
	public static void info(CharSequence seq) { log(LogLevel.INFO, seq); }
	
	public static void info(Throwable e) { log(LogLevel.INFO, e); }
	
	public static void info(CharSequence seq, Throwable e) { log(LogLevel.INFO, seq, e); }
	
	public static void info(CharSequence seq, final ITrace trace) {
		log(LogLevel.INFO, seq);
		trace.addTrace(new Couple<ILogLevel, CharSequence>(LogLevel.INFO, seq));
	}
	
	public static void info(CharSequence seq, Exception e, final ITrace trace) {
		log(LogLevel.INFO, seq, e);
		trace.addTrace(new Couple<ILogLevel, CharSequence>(LogLevel.INFO, Concat(seq.toString(), getErrorMessage(e))));
	}
	
	public static void info(Throwable e, final ITrace trace) {
		log(LogLevel.INFO, e);
		trace.addTrace(new Couple<ILogLevel, CharSequence>(LogLevel.INFO, getErrorMessage(e)));
	}
	
	public static void warning(CharSequence seq) { log(LogLevel.WARNING, seq); }
	
	public static void warning(Throwable e) { log(LogLevel.WARNING, e); }
	
	public static void warning(CharSequence seq, Throwable e) { log(LogLevel.WARNING, seq, e); }

	public static void warning(CharSequence seq, ITrace trace) {
		log(LogLevel.WARNING, seq);
		trace.addTrace(new Couple<ILogLevel, CharSequence>(LogLevel.WARNING, seq));
	}
	
	public static void warning(CharSequence seq, Throwable e, ITrace trace) {
		log(LogLevel.WARNING, seq, e);
		trace.addTrace(new Couple<ILogLevel, CharSequence>(LogLevel.WARNING, Concat(seq.toString(), getErrorMessage(e))));
	}
	
	public static void warning(Throwable e, ITrace trace) {
		log(LogLevel.WARNING, e);
		trace.addTrace(new Couple<ILogLevel, CharSequence>(LogLevel.WARNING, getErrorMessage(e)));
	}

	public static void error(CharSequence seq) { log(LogLevel.ERROR, seq); }

	public static void error(Throwable e) { log(LogLevel.ERROR, e); }

	public static void error(CharSequence seq, Throwable e) { log(LogLevel.ERROR, seq, e); }
	
	public static void error(CharSequence seq, ITrace trace) {
		log(LogLevel.ERROR, seq);
		trace.addTrace(new Couple<ILogLevel, CharSequence>(LogLevel.ERROR, seq));
	}
	
	public static void error(CharSequence seq, Throwable e, ITrace trace) {
		log(LogLevel.ERROR, seq, e);
		trace.addTrace(new Couple<ILogLevel, CharSequence>(LogLevel.ERROR, Concat(seq.toString(), getErrorMessage(e))));
	}
	
	public static void error(Throwable e, ITrace trace) {
		log(LogLevel.ERROR, e);
		trace.addTrace(new Couple<ILogLevel, CharSequence>(LogLevel.ERROR, getErrorMessage(e)));
	}
	
	public static void log(ILogLevel level, Throwable e) {
		log(level, "", e);
	}

	public static void log(ILogLevel level, CharSequence seq) {
		CharSequence message = TimeHelper.Now() + " - " + level.getCode() + " : " + seq;
		System.out.println(message);
		if (logsConfig.ActivateElement) write(message + "\n");
	}

	public static void log(ILogLevel level, CharSequence seq, Throwable e) {
		log(level, seq + "\n" + getErrorMessage(e));
	}

	private static void write(String seq) {
		try {
			if (FileHelper.createFile(filePathName)) {
				FileWriter pw = new FileWriter(filePathName, true);
				pw.write(seq);
				pw.close();
			}
		}
		catch (IOException ioe) { ioe.printStackTrace(); }
	}
}
