package patronSingleton_Java;

public class Main {
	public static void main(String[] args) {
		miSingleton a = miSingleton.getmiSingleton("Hola, esto se ha hecho con el patron singleton, ¡solo hay una instancia!");
		System.out.println(a.getX());

	}
}
