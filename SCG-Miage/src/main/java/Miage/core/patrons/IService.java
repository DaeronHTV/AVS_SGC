package Miage.core.patrons;

public interface IService extends Runnable{
	boolean isRunning();
	
	String getServiceName();
}
