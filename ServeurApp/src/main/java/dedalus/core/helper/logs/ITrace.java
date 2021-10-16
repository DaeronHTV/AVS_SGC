package dedalus.core.helper.logs;

import java.util.List;

import dedalus.core.teams.Couple;

/**
 * This interfaces is here to give the possibility to save the log trace into
 * an specific object that implements this interface
 * @author Avanzino Aurelien
 * @since 15/08/2021
 * @version 1.0
 * @param <Couple> Object that represent the trace with code and description
 * @see Avsoft.Object.Teams.Couple
 */
public interface ITrace {
	
	/**
	 * Remove all the trace contained in the object
	 * @since 15/08/2021
	 */
	void removeTrace();
	
	/**
	 * Add a trace in the list contained in the object
	 * @since 15/08/2021
	 */
	void addTrace(Couple<ILogLevel,CharSequence> trace);
	
	/**
	 * Get the traces in a string format
	 * @return A String that contains the traces in the format : Code - Description
	 * @since 15/08/2021
	 */
	String traceToString();
	
	/**
	 * Give the trace at the position given
	 * @param i index of the trace
	 * @return Couple that represent the trace at the position given
	 */
	Couple<ILogLevel, CharSequence> getTrace(int i);
	
	/**
	 * Give all the trace saved in the current object in function of the specific code
	 * @param lvl - LogLevel Code of the traces
	 * @return A List<Couple>
	 */
	List<Couple<ILogLevel, CharSequence>> getTraces(ILogLevel lvl);
	
	/**
	 * Give all the trace saved in the current object in function of the specific code
	 * @param code - String code of the LogLevel
	 * @return A List<Couple>
	 */
	List<Couple<ILogLevel, CharSequence>> getTraces(String code);
}
