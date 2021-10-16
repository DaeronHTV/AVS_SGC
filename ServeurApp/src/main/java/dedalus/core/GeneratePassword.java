package dedalus.core;

import java.util.Random;

public class GeneratePassword {
	private static final String MinLetters = "abcdefghijklmnopqrstuvwxyz";
	private static final String MaxLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	private static final String Numbers = "0123456789";
	private static final String SpecialsChars = "&~#|`-_)('/?,;:.";
	
	/**
	 * Genere aleatoirement un mot de passe contenant un ensemble
	 * de lettre uniquement
	 * @param length La taille du mot de passe a generer
	 * @return Le mot de passe genere
	 */
	public static String basicPassword(final int length) {
		String result = "";
		final Random rand = new Random();
		while(result.length() != length) {
			int random = rand.nextInt(2);
			if(random == 0) result += MinLetters.charAt(rand.nextInt(25));
			else result += MaxLetters.charAt(rand.nextInt(25));
		}
		return result;
	}
	

	/**
	 * Genere aleatoirement un mot de passe contenant un ensemble
	 * de lettre et de chiffres
	 * @param length La taille du mot de passe a generer
	 * @return Le mot de passe genere
	 */
	public static String hardPassword(final int length) {
		String result = "";
		final Random rand = new Random();
		while(result.length() != length) {
			int random = rand.nextInt(3);
			if(random == 0) result += MinLetters.charAt(rand.nextInt(25));
			else if(random == 1) result += MaxLetters.charAt(rand.nextInt(25));
			else result += Numbers.charAt(rand.nextInt(9));
		}
		return result;
	}
	

	/**
	 * Genere aleatoirement un mot de passe contenant un ensemble
	 * de lettre de chiffres et de caracteres speciaux
	 * @param length La taille du mot de passe a generer
	 * @return Le mot de passe genere
	 */
	public static String complexPassword(final int length) {
		String result = "";
		final Random rand = new Random();
		while(result.length() != length) {
			switch(rand.nextInt(4)) {
				case 0:
					result += MinLetters.charAt(rand.nextInt(25));
					break;
				case 1:
					result += MaxLetters.charAt(rand.nextInt(25));
					break;
				case 2:
					result += Numbers.charAt(rand.nextInt(9));
					break;
				default:
					result += SpecialsChars.charAt(rand.nextInt(15));
					break;
			}
		}
		return result;
	}
}
