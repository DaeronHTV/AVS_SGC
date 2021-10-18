package Miage.core.helper;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import Miage.core.helper.logs.LogHelper;

public class FileHelper {

	public static String fileToString(String path) {
		try {
			String line;
			StringBuffer builder = new StringBuffer();
			BufferedReader buffer = new BufferedReader(new InputStreamReader(new FileInputStream(path)));
			while((line = buffer.readLine()) != null) builder.append(line+"\n");
			buffer.close();
			return builder.toString();
		} catch (IOException e) {
			LogHelper.error(e);
			return null;
		}
	}

	public static String getRootPath() { return new File("").getAbsolutePath(); }

	// A TESTER
	public static boolean createFolder(String path, String name) {
		return createFolder(path + File.separatorChar + name);
	}
	
	//A TESTER
	public static boolean createFolder(String path) {
		File dir = new File(path);
		return (dir.exists() && dir.isDirectory()) ? true : dir.mkdirs();
	}
	
	//A TESTER
	public static boolean createFile(String filePath, String fileName) throws IOException {
		return createFile(filePath + File.separatorChar + fileName);
	}
	
	//A TESTER
	public static boolean createFile(String path) throws IOException {
		File file = new File(path);
		if(!file.exists()) return file.createNewFile();
		return true;
	}
}
