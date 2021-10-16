/*
 * Copyright 2018-2021 the original author or authors.
 *
 * All rights reserved. This program and the accompanying materials are
 * made available under the terms of the Eclipse Public License v2.0 which
 * accompanies this distribution and is available at
 *
 */
package dedalus.core.helper;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.Objects;
import java.util.regex.Pattern;
import java.util.regex.PatternSyntaxException;

import javax.annotation.Nonnull;
import javax.annotation.Nullable;

/**
 * This class contains all the methods used in order to manipulate easily the String and CharSequence
 * object. This is a static class.
 * @apiNote This class 
 * @author Avanzino.A
 * @since 1.0
 * @see String
 */
public final class StringHelper{
	public static final String SepRegex = "SepRegex";
	
	public static final CharSequence[] accents = { "À", "Á", "Â", "Ä", "Ç", "É", "È", "Ê", "Ë", "Í", "Ì", "Î", "Ï", "Ñ", "Ó", "Ò",
			"Ô", "Ö", "Ú", "Ù", "Û", "Ü" };
	public static final CharSequence[] saccents = { "A", "A", "A", "A", "C", "E", "E", "E", "E", "I", "I", "I", "I", "N", "O", "O",
			"O", "O", "U", "U", "U", "U" };
	
	public static final String Empty = "";
	
	/**
	 * Says if the string object is null
	 * @param object The string object to test
	 * @return True if the string is null, else false
	 * @since 1.0
	 */
	public static boolean IsNull(@Nullable final CharSequence object) {
		return Objects.isNull(object);
	}

	/**
	 * Says if the string object is null or empty
	 * @param object The string object to test
	 * @return True if the string is null or empty, else false
	 * @since 1.0
	 */
	public static boolean IsNullOrEmpty(@Nullable final CharSequence object) {
		return Objects.isNull(object) || object.isEmpty();
	}
	
	/**
	 * Says if the string object is null, empty or contains only whitespace character
	 * @param object The string object to test
	 * @return True if the string is null, empty or contains only whitespace character, else false
	 * @since 1.0
	 */
	public static boolean IsNullOrWhiteSpace(@Nullable final String object) {
		return Objects.isNull(object) || object.isBlank();
	}

	/**
	 * Get the message contains in the StackTrace of a Throwable element
	 * @param e The Throwable where we get the message
	 * @exception NullPointerException if the throwable given is null
	 * @return A CharSequence which represents the message contains in the stackTrace of the Throwable element
	 * @since 1.0
	 */
	public static String getErrorMessage(@Nonnull final Throwable e) throws NullPointerException{
		String result = "";
		for (final StackTraceElement st : e.getStackTrace()) 
			result += "at " + st.toString() + "\n";
		return result;
	}

	/**
	 * Transform the string object into the ASCII format
	 * @param chaine The string object to transform
	 * @return The string object converted into ASCII format
	 * @throws NullPointerException If the string object given is null
	 * @since 1.0
	 */
	public static String ToASCII(@Nonnull String chaine) throws NullPointerException{
		int i = 0;
		String result = chaine.toUpperCase();
		for (final CharSequence s : accents) {
			result = result.replace(s, saccents[i]);
			i++;
		}
		return result;
	}
	
	/**
	 * Concatenation of the objects strings
	 * @param args The strings object to concat
	 * @return The concatenation of all the object string into one string
	 * @since 1.0
	 */
	public static String Concat(final String... args) {
		String result = "";
		for(int i = 0; i < args.length; i++) result += args[i];
		return result;
	}
	
	/*************************ALL THE ORTHER METHOD TO TEST*******************************/
	/**
	 * 
	 * @param text
	 * @param regex
	 * @param replace
	 * @return
	 */
	public static String Regex(String text, @Nonnull final String regex, @Nonnull final String replace) throws PatternSyntaxException, NullPointerException{
		//Pattern pattern = Pattern.compile(regex);
		//Matcher matcher = pattern.matcher(text);
		return Pattern.compile(regex).matcher(text).replaceAll(replace);
	}
	
	/**
	 * 
	 * @param text
	 * @param regex
	 * @return
	 */
	public static String Regex(String text, final String regex) {
		final String[] patterns = regex.split(SepRegex);
		if(!(patterns.length == 2)) { return null; }
		else {
			//Pattern pattern = Pattern.compile(patterns[0]);
			//Matcher matcher = pattern.matcher(text);
			return Pattern.compile(patterns[0]).matcher(text).replaceAll(patterns[1]);
		}		
	}
	
	/**
	 * 
	 * @param texte
	 * @param args
	 * @return
	 */
	public static String Format(String texte, final String... args) {
		for(int i = 0; i < args.length; i++) {
			final String elt = "{"+i+"}";
			if(!texte.contains(elt)) { return null; }
			texte = texte.replace(elt, args[i]);
		}
		return texte;
	}
	
	public static String streamToString(InputStream stream) throws Exception {
        String result = ""; String line = "";
        BufferedReader reader = new BufferedReader(new InputStreamReader(stream));
        while ((line = reader.readLine()) != null) { result += line; }
        return result;
    }
}
